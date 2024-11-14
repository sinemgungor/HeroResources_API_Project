using HRMaster_API_Project.BLL.Services.Models.DTOs.LoginDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.UserDTO;
using HRMaster_API_Project.BLL.Services.Models;
using HRMaster_API_Project.DAL.Repositories.Concrete;
using HRMaster_API_Project.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using HRMaster_API_Project.BLL.Services.Models.DTOs;
using System.Threading.Tasks;
using HRMaster_API_Project.BLL.Services.Models.DTOs.DepartmentDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.ManagerDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.CompanyDTO;
using HRMaster_API_Project.BLL.Services.ManagerService;
using System.Security.Claims;
using HRMaster_API_Project.DAL.Repositories.Abstract;
using HRMaster_MVC_Project.Areas.CEOPanel.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using HRMaster_API_Project.BLL.Services.Models.EmployeeDTO;
using System.ComponentModel.Design;

public class ManagerServices : IManagerServices
{
    private readonly UserManager<User> _userManager;
    private readonly UserHelper _userHelper;
    private readonly IDepartmentManager _departmentManager;
    private readonly SignInManager<User> _signInManager;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IMapper _mapper;

    public ManagerServices(UserManager<User> userManager, UserHelper userHelper, IDepartmentManager departmentManager, SignInManager<User> signInManager, IHttpContextAccessor httpContextAccessor, IMapper mapper)
    {
        _userManager = userManager;
        _userHelper = userHelper;
        _departmentManager = departmentManager;
        _signInManager = signInManager;
        _httpContextAccessor = httpContextAccessor;
        _mapper = mapper;
    }

    public async Task<ServiceResult> AddNewEmployeeAsync(AddNewUserDTO newUserDTO)
    {
        return await _userHelper.AddUserAsync(newUserDTO, "Employee", "Employee123");
    }

    public async Task<ServiceResult> AssignDepartmentManagerRoleAsync(int employeeId)
    {
        var employee = await _userManager.FindByIdAsync(employeeId.ToString());
        if (employee == null)
        {
            return new ServiceResult { Success = false, Message = "Çalışan bulunamadı." };
        }

        if (employee.Department == null)
        {
            return new ServiceResult { Success = false, Message = "Çalışan herhangi bir departmana bağlı değildir." };
        }

        var result = await _userManager.AddToRoleAsync(employee, "DepartmentManager");
        if (!result.Succeeded)
        {
            return new ServiceResult { Success = false, Message = string.Join(", ", result.Errors.Select(e => e.Description)) };
        }

        return new ServiceResult { Success = true, Message = "Çalışanımız Departman Yöneticisi olarak başarıyla atandı." };
    }

    public async Task<ServiceResult> GetLoggedInManagerAsync()
    {
        var user = _httpContextAccessor.HttpContext.User;
        if (user == null)
        {
            return new ServiceResult { Success = false, Message = "Hiçbir kullanıcı giriş yapmadı." };
        }

        var userId = _userManager.GetUserId(user);
        var manager = await _userManager.FindByIdAsync(userId);
        if (manager == null)
        {
            return new ServiceResult { Success = false, Message = "Yönetici bulunamadı." };
        }

        var roles = await _userManager.GetRolesAsync(manager);
        if (!roles.Contains("Manager"))
        {
            return new ServiceResult { Success = false, Message = "Kullanıcı yönetici değil." };
        }

        var managerInfo = new Manager_DTO
        {
            Id = manager.Id,
            Name = manager.Name,
            SecondName = manager.SecondName,
            Surname = manager.Surname,
            SecondSurname = manager.SecondSurname,
            Email = manager.Email,
            PhoneNumber = manager.PhoneNumber,
            PicturePath = manager.PicturePath,
            BirthDate = manager.BirthDate,
            BirthState = manager.BirthState,
            IdentityNumber = manager.IdentityNumber,
            HireDate = manager.HireDate,
            TerminationDate = manager.TerminationDate,
            Job = manager.Job,
            Address = manager.Address,
            Salary = manager.Salary,
            Title = manager.Title,
            BloodGroup = manager.BloodGroup,
            Gender = manager.Gender,
            MarialStatus = manager.MarialStatus,
            Department = manager.Department != null ? new Department_DTO
            {
                ID = manager.Department.ID,
                DepartmentName = manager.Department.DepartmentName
            } : null,
            Company = manager.CEORelatedCompany != null ? new CompanyForManagerDTO
            {
                ID = manager.CEORelatedCompany.ID,
                CompanyName = manager.CEORelatedCompany.CompanyName
            } : null
        };

        return new ServiceResult { Success = true, Data = managerInfo };
    }
    public async Task<ServiceResult> UpdateManagerDetailsAsync(int id, UpdateManagerDetailsDTO updateDto)
    {
        var userId = id.ToString();

        var manager = await _userManager.FindByIdAsync(userId);
        if (manager == null)
        {
            return new ServiceResult { Success = false, Message = "Yönetici bulunamadı." };
        }

        if (updateDto.PicturePath != null)
        {
            manager.PicturePath = updateDto.PicturePath;
        }
        if (updateDto.Address != null)
        {
            manager.Address = updateDto.Address;
        }
        if (updateDto.Phone != null)
        {
            manager.PhoneNumber = updateDto.Phone;
        }

        var result = await _userManager.UpdateAsync(manager);
        if (!result.Succeeded)
        {
            return new ServiceResult { Success = false, Message = "Güncelleme başarısız oldu.", Errors = result.Errors.Select(e => e.Description).ToList() };
        }

        return new ServiceResult { Success = true, Message = "Details updated successfully." };
    }

    public async Task<ManagerIndexDTO> GetManagerIndexVMAsync(int managerID)
    {
        var userId = managerID.ToString();
        var manager = await _userManager.FindByIdAsync(userId);
        ManagerSumInfoDTO sumInfoDTO = new ManagerSumInfoDTO();
        _mapper.Map(manager, sumInfoDTO);
        List<EmployeeSummary_DTO> showEmployee_DTOs = new List<EmployeeSummary_DTO>();
        var employees = await _userManager.Users
                                 .Where(u => u.EmployeeRelatedCompanyID==manager.CEORelatedCompanyID).Include(u => u.Department)
                                 .ToListAsync();
        _mapper.Map(employees, showEmployee_DTOs);
        ManagerIndexDTO indexDTO = new ManagerIndexDTO();
        indexDTO.ManagerSumInfo = sumInfoDTO;
        indexDTO.ShowEmployees = showEmployee_DTOs;
        return indexDTO;

    }

    public async Task<ManagerDetailDTO> GetManagerDetailAsync(int managerID)
    {
        ManagerDetailDTO managerDetailDTO = new ManagerDetailDTO();
        var manager = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == managerID);
        _mapper.Map(manager, managerDetailDTO);
        return managerDetailDTO;

    }
    public async Task<List<ManagerListDTO>> GetAllCEOsAsync()
    {
        var allUsers = await _userManager.Users
       .Include(u => u.CEORelatedCompany)
       .Where(u => u.CEORelatedCompany != null)
       .ToListAsync();

        var managers = new List<User>();
        foreach (var user in allUsers)
        {
            var roles = await _userManager.GetRolesAsync(user);
            if (roles.Contains("Manager") && user.CEORelatedCompanyID != null)
            {
                managers.Add(user);
            }
        }

        List<ManagerListDTO> ceoList = _mapper.Map<List<ManagerListDTO>>(managers);

        return ceoList;
    }

    public async Task<ServiceResult> AssignDepartmentToEmployeeAsync(int employeeId, int departmentId)
    {
        var result = new ServiceResult();

       
        var employee = await _userManager.Users.Include(u => u.EmployeeRelatedCompany).FirstOrDefaultAsync(u => u.Id == employeeId);
        if (employee == null)
        {
            result.Success = false;
            result.Message = "Çalışan bulunamadı.";
            return result;
        }

        int companyId = employee.EmployeeRelatedCompany.ID;

        var departments = await _departmentManager.GetAllCompanyDepartment(companyId);
        var department = departments.FirstOrDefault(d => d.ID == departmentId);

        if (department == null)
        {
            result.Success = false;
            result.Message = "Departman bulunamadı veya çalışanın şirketine ait değil.";
            return result;
        }

        employee.DepartmentID = departmentId;
        var updateResult = await _userManager.UpdateAsync(employee);

        if (!updateResult.Succeeded)
        {
            result.Success = false;
            result.Message = "Departman ataması sırasında bir hata oluştu.";
            return result;
        }

        result.Success = true;
        result.Message = "Departman başarıyla atandı.";
        return result;
    }

}
