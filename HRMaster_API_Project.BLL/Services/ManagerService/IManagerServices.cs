using HRMaster_API_Project.BLL.Services.Models.DTOs.UserDTO;
using HRMaster_API_Project.BLL.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMaster_API_Project.BLL.Services.Models.DTOs.LoginDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs;
using HRMaster_API_Project.BLL.Services.Models.DTOs.ManagerDTO;
using HRMaster_MVC_Project.Areas.CEOPanel.Models;

namespace HRMaster_API_Project.BLL.Services.ManagerService
{
    public interface IManagerServices
    {
        Task<ServiceResult> AddNewEmployeeAsync(AddNewUserDTO newUserDTO);

        Task<ServiceResult> AssignDepartmentManagerRoleAsync(int employeeId);

        Task<ServiceResult> GetLoggedInManagerAsync();


        Task<ServiceResult> UpdateManagerDetailsAsync(int id,UpdateManagerDetailsDTO updateDto);

        Task<ManagerDetailDTO> GetManagerDetailAsync(int managerID);

        Task<ManagerIndexDTO> GetManagerIndexVMAsync(int managerID);

        Task<List<ManagerListDTO>> GetAllCEOsAsync();
        Task<ServiceResult> AssignDepartmentToEmployeeAsync(int employeeId, int departmentId);
    }
}
