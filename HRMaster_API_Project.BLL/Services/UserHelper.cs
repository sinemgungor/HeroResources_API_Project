using HRMaster_API_Project.BLL.Services.Models.DTOs.LoginDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.UserDTO;
using HRMaster_API_Project.BLL.Services.Models;
using HRMaster_API_Project.DAL.Repositories.Concrete;
using HRMaster_API_Project.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using HRMaster_API_Project.BLL.Services.Models.DTOs;
using HRMaster_API_Project.DAL.Repositories.Abstract;

public class UserHelper
{
    private readonly UserManager<User> _userManager;
    private readonly IEmailSender _emailSender;
    private readonly IDepartmentManager _departmentManager;
    private readonly SignInManager<User> _signInManager;
    private readonly ICompanyManager _companyManager;

    public UserHelper(UserManager<User> userManager, IEmailSender emailSender, IDepartmentManager departmentManager, SignInManager<User> signInManager,ICompanyManager companyManager )
    {
        _companyManager= companyManager;
        _userManager = userManager;
        _emailSender = emailSender;
        _departmentManager = departmentManager;
        _signInManager = signInManager;
    }

    public async Task<ServiceResult> AddUserAsync(AddNewUserDTO newUserDTO, string roleName, string defaultPassword)
    {

        User newUser = new User
        {
            Name = newUserDTO.Name,
            Surname = newUserDTO.Surname,
            SecondName = newUserDTO.SecondName,
            SecondSurname = newUserDTO.SecondSurname,
            UserName = newUserDTO.Email,
            NormalizedUserName=newUserDTO.Email.ToUpper(),
            Email = newUserDTO.Email,
            NormalizedEmail=newUserDTO.Email.ToUpper(),
            Job = newUserDTO.Job,
            Title = newUserDTO.Title,
            IdentityNumber = newUserDTO.IdentityNumber,
            PicturePath = newUserDTO.Picture,
            BirthDate = newUserDTO.BirthDate,
            BirthState = newUserDTO.BirthState,
            Address = newUserDTO.Address,
            HireDate = newUserDTO.HireDate,
            Salary = newUserDTO.Salary,
            PhoneNumber = newUserDTO.PhoneNumber,
            Gender = newUserDTO.Gender,
            MarialStatus = newUserDTO.MarialStatus,
            BloodGroup = newUserDTO.BloodGroup,   
        };
        if (roleName == "Manager")
        {
            var company = _companyManager.GetByIdAsync(newUserDTO.CompanyID.GetValueOrDefault());
            if (company.Result.CEOId != null)
            {
                return new ServiceResult { Success = false, Message = "Bu şirketin bir CEO'su bulunmaktadır başka şirket yöneticisi ekleyemezsiniz!" };
            }
            newUser.CEORelatedCompanyID = newUserDTO.CompanyID;

        }

        else
            newUser.EmployeeRelatedCompanyID = newUserDTO.CompanyID; 

        //if (newUserDTO.Department != null)
        //{
        //    Department userDepartment = await _departmentManager.GetDepartmentByNameAsync(newUserDTO.Department,);
        //    if (userDepartment != null)
        //        newUser.Department = userDepartment;
        //}

        PasswordHasher<User> passwordHasher = new PasswordHasher<User>();
        newUser.PasswordHash = passwordHasher.HashPassword(newUser, defaultPassword);

        var result = await _userManager.CreateAsync(newUser);
        if (!result.Succeeded)
        {
            return new ServiceResult { Success = false, Message = string.Join(", ", result.Errors.Select(e => e.Description)) };
        }
        if(newUserDTO.CompanyID != null)
        {
            var company = await _companyManager.GetByIdAsync(newUserDTO.CompanyID.GetValueOrDefault());
            
        }


        await _userManager.AddToRoleAsync(newUser, roleName);

        var token = await _userManager.GenerateEmailConfirmationTokenAsync(newUser);

        var confirmationLink = $"https://hrmastermvcproject20240825202734.azurewebsites.net/Login/ConfirmEmail?userId={newUser.Id}&token={Uri.EscapeDataString(token)}";
        if (roleName == "Manager")
        {

            var response = await _companyManager.AddCeoToCompany(newUserDTO.CompanyID.GetValueOrDefault(), newUserDTO.Email);
            
            if (!response)
            {
                return new ServiceResult { Success = false, Message = string.Join(", ", result.Errors.Select(e => e.Description)) };
            }           
        }

        
        var subject = "Email Confirmation";
        var htmlMessage = $"Emailinizi onaylamak için lütfen onay linkine tıklayınız <a href='{confirmationLink}'>Emailimi Onayla</a><br>Kullanıcı Adınız:'{newUserDTO.Email}'<br>Şifreniz:'{defaultPassword}'<br><b>Uygulamayı güvenli bir şekilde kullanabilmek için lütfen şifremi unuttum sayfasından şifrenizi güncelleyiniz!</b>";
        await _emailSender.SendEmailAsync(newUser.Email, subject, htmlMessage);

        return new ServiceResult { Success = true, Message = "User created successfully. Please confirm your email. Password:" + defaultPassword };
    }

    public async Task<LoginResult> LoginAsync(LoginUserDTO login)
    {
        var user = await _userManager.FindByEmailAsync(login.Email);
        if (user != null)
        {
            bool isPasswordCorrect = await _userManager.CheckPasswordAsync(user, login.Password);

            if (isPasswordCorrect)
            {
                var userRoles = await _userManager.GetRolesAsync(user);
                return new LoginResult { User = user, Roles = userRoles };
            }
        }

        return new LoginResult { User = null, Roles = null };
    }

    public async Task<ServiceResult> ConfirmEmailAsync(string userId, string token)
    {
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            return new ServiceResult { Success = false, Message = "Geçersiz kullanıcı kimliği." };
        }

        // Token'ı doğrulama
        var result = await _userManager.ConfirmEmailAsync(user, Uri.UnescapeDataString(token));
        if (!result.Succeeded)
        {
            var errors = string.Join(", ", result.Errors.Select(e => e.Description));
            return new ServiceResult { Success = false, Message = $"E-posta onayı başarısız oldu. Hatalar: {errors}" };
        }

        // EmailConfirmed alanını true olarak güncelle
        user.EmailConfirmed = true;
        var updateResult = await _userManager.UpdateAsync(user);
        if (!updateResult.Succeeded)
        {
            var errors = string.Join(", ", updateResult.Errors.Select(e => e.Description));
            return new ServiceResult { Success = false, Message = $"E-posta onay durumu güncellenemedi. Hatalar: {errors}" };
        }

        return new ServiceResult { Success = true, Message = "E-posta başarıyla onaylandı." };
    }

    public async Task<ServiceResult> GeneratePasswordResetTokenAsync(string email)
    {
        var user = await _userManager.FindByEmailAsync(email);
        if (user == null)
        {
            return new ServiceResult { Success = false, Message = "Geçersiz e-posta." };
        }

        var token = await _userManager.GeneratePasswordResetTokenAsync(user);
        var resetLink = $"https://hrmastermvcproject20240825202734.azurewebsites.net/Login/ResetPassword?email={email}&token={Uri.EscapeDataString(token)}";

        var subject = "Şifre Sıfırlama";
        var htmlMessage = $"Şifrenizi bu bağlantıya tıklayarak sıfırlayabilirsiniz: <a href='{resetLink}'>Şifre Sıfırlama</a>";
        await _emailSender.SendEmailAsync(email, subject, htmlMessage);

        return new ServiceResult { Success = true, Message = "Şifre sıfırlama belirteci başarıyla oluşturuldu. Lütfen e-postanızı kontrol edin." };
    }

    public async Task<ServiceResult> ResetPasswordAsync(ResetPasswordDTO model)
    {
        var user = await _userManager.FindByEmailAsync(model.Email);
        if (user == null)
        {
            return new ServiceResult { Success = false, Message = "Geçersiz e-posta." };
        }

        var result = await _userManager.ResetPasswordAsync(user, model.Token, model.NewPassword);
        if (!result.Succeeded)
        {
            return new ServiceResult { Success = false, Message = "Şifre sıfırlama başarısız oldu.", Errors = result.Errors.Select(e => e.Description).ToList() };
        }

        return new ServiceResult { Success = true, Message = "Şifreniz başarıyla yenilendi. Yeni şifrenizle giriş yapabilirsiniz." };
    }
    public async Task<ServiceResult> LogoutAsync()
    {
        await _signInManager.SignOutAsync();
        return new ServiceResult { Success = true, Message = "Başarıyla çıkış yapıldı." };
    }

}
