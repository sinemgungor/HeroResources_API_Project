using HRMaster_API_Project.BLL.Services.Models.DTOs.LoginDTO;
using HRMaster_API_Project.BLL.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using HRMaster_API_Project.BLL.Services.Models.DTOs.UserDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.AdminDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.ManagerDTO;

namespace HRMaster_API_Project.BLL.Services.AdminService
{
    public interface IAdminService
    {
        int GetUserID(ClaimsPrincipal principal);
        
        Task<ServiceResult> AddNewManagerAsync(AddNewUserDTO newUserDTO);

        Task<AdminSummaryDTO> GetAdminSummaryAsync(int adminId);

        Task<AdminDTO> GetAdminDetailAsync(int adminId);

        Task<ServiceResult> UpdateAdminDetailsAsync(int id, UpdateAdminDetailDTO updateDto);


    }
}
