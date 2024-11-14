using HRMaster_API_Project.BLL.Services.Models.DTOs.LoginDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.UserDTO;
using HRMaster_API_Project.BLL.Services.Models;
using HRMaster_API_Project.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using HRMaster_API_Project.BLL.Services.AdminService;
using HRMaster_API_Project.BLL.Services.Models.DTOs.AdminDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.DepartmentDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.CompanyDTO;
using HRMaster_API_Project.BLL.Services.CompanyService;
using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class AdminServices : IAdminService
{
    private readonly UserManager<User> _userManager;
    private readonly UserHelper _userHelper;
    private readonly ICompanyService _companyService;

    public AdminServices(UserManager<User> userManager, UserHelper userHelper, ICompanyService companyService)
    {
        _userManager = userManager;
        _userHelper = userHelper;
        _companyService = companyService;
    }

    public int GetUserID(ClaimsPrincipal principal)
    {
        return int.Parse(_userManager.GetUserId(principal));
    }

    public async Task<ServiceResult> AddNewManagerAsync(AddNewUserDTO newUserDTO)
    {
        if (newUserDTO.CompanyID.GetValueOrDefault() != 0)
        {
            if (await _companyService.CheckCeoExists(newUserDTO.CompanyID.GetValueOrDefault()) == true)
            {
                return new ServiceResult { Success = false, Message = $"This company has already assigned with another CEO" };
                
            }
            else
            {
               var result= await _userHelper.AddUserAsync(newUserDTO, "Manager", "Manager123");
                if (result.Success)
                {
                    return result;
                }
                return new ServiceResult { Success = false, Message = $"There has been a problem when you try to assign the CEO!" };
            }

        }
        return new ServiceResult { Success = false, Message = $"This company has already assigned with another CEO" };

        
    }

    public async Task<AdminSummaryDTO> GetAdminSummaryAsync(int adminId)
    {
        var user = await _userManager.FindByIdAsync(adminId.ToString());

        if (user == null)
        {
            return null;
        }

        var adminSummary = new AdminSummaryDTO
        {
            Id = user.Id,
            PicturePath = user.PicturePath,
            Name = user.Name,
            Surname = user.Surname,
            Job = user.Job,
            Email = user.Email,
            Address = user.Address,
            PhoneNumber = user.PhoneNumber,
            Department = user.Department != null ? user.Department.DepartmentName : null,

        };

        return adminSummary;
    }

    public async Task<AdminDTO> GetAdminDetailAsync(int adminId)
    {
        var user = await _userManager.FindByIdAsync(adminId.ToString());

        if (user == null)
        {
            return null; // Veya uygun bir hata yönetimi
        }

        var adminDetail = new AdminDTO
        {
            Id = user.Id,
            PicturePath = user.PicturePath,
            Name = user.Name,
            SecondName = user.SecondName,
            Surname = user.Surname,
            SecondSurname = user.SecondSurname,
            BirthDate = user.BirthDate,
            BirthState = user.BirthState,
            IdentityNumber = user.IdentityNumber,
            HireDate = user.HireDate,
            TerminationDate = user.TerminationDate,
            Job = user.Job,
            Email = user.Email,
            Address = user.Address,
            PhoneNumber = user.PhoneNumber,
            Department = user.Department != null ? new Department_DTO
            {
                ID = user.Department.ID,
                DepartmentName = user.Department.DepartmentName
            } : null,


        };

        return adminDetail;
    }

    public async Task<ServiceResult> UpdateAdminDetailsAsync(int id, UpdateAdminDetailDTO updateDto)
    {
        var userId = id.ToString();

        var admin = await _userManager.FindByIdAsync(userId);
        if (admin == null)
        {
            return new ServiceResult { Success = false, Message = "Admin not found." };
        }
        if(updateDto.PicturePath != null) 
        {
            admin.PicturePath = updateDto.PicturePath;
        }
        if(updateDto.Address != null)
        {
            admin.Address = updateDto.Address;
        }
        if(updateDto.Phone != null)
        {
            admin.PhoneNumber = updateDto.Phone;
        }
        var result = await _userManager.UpdateAsync(admin);

        if (!result.Succeeded)
        {
            return new ServiceResult { Success = false, Message = "Update failed", Errors = result.Errors.Select(e => e.Description).ToList() };
        }

        return new ServiceResult { Success = true, Message = "Details updated successfully." };
    }

}