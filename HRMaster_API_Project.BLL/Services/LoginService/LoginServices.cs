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
    public class LoginServices :ILoginServices
    {
        private readonly UserHelper _userHelper;

        public LoginServices(UserHelper userHelper)
        {
            _userHelper = userHelper;
        }

        public async Task<LoginResult> LoginAsync(LoginUserDTO login)
        {
            return await _userHelper.LoginAsync(login);
        }
        public async Task<ServiceResult> ConfirmEmailAsync(string userId, string token)
        {
            return await _userHelper.ConfirmEmailAsync(userId, token);
        }
        public async Task<ServiceResult> GeneratePasswordResetTokenAsync(string email)
        {
            return await _userHelper.GeneratePasswordResetTokenAsync(email);
        }

        public async Task<ServiceResult> ResetPasswordAsync(ResetPasswordDTO model)
        {
            return await _userHelper.ResetPasswordAsync(model);
        }
        public async Task<ServiceResult> LogoutAsync()
        {
            return await _userHelper.LogoutAsync();
        }
    }
}
