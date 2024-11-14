using HRMaster_API_Project.BLL.Services.Models.DTOs.LoginDTO;
using HRMaster_API_Project.BLL.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMaster_API_Project.BLL.Services.Models.DTOs;

namespace HRMaster_API_Project.BLL.Services.LoginService
{
    public interface ILoginServices
    {
        Task<LoginResult> LoginAsync(LoginUserDTO login);
        Task<ServiceResult> ConfirmEmailAsync(string userId, string token);
        Task<ServiceResult> GeneratePasswordResetTokenAsync(string email);
        Task<ServiceResult> ResetPasswordAsync(ResetPasswordDTO model);
        Task<ServiceResult> LogoutAsync();
    }
}
