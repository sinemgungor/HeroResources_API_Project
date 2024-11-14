using HRMaster_API_Project.BLL.Services.Models.DTOs.LoginDTO;
using HRMaster_API_Project.BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HRMaster_API_Project.BLL.Services.AdminService;
using HRMaster_API_Project.BLL.Services.LoginService;
using HRMaster_API_Project.BLL.Services.ManagerService;
using HRMaster_API_Project.BLL.Services.Models.DTOs;
using Microsoft.AspNetCore.Authorization;

namespace HR_Master_API_Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginServices _userService;

        public LoginController(ILoginServices userService)
        {
            _userService = userService;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDTO login)
        {
            var loginResult = await _userService.LoginAsync(login);

            if (loginResult.User == null)
            {
                return Unauthorized(new { message = "Invalid email or password" });
            }

            // Kullanıcı bilgilerini ve rollerini döndürüyoruz
            return Ok(new { user = loginResult.User, roles = loginResult.Roles });
        }

        [HttpGet("confirm-email")]
        public async Task<IActionResult> ConfirmEmail([FromQuery] string userId, [FromQuery] string token)
        {
            var result = await _userService.ConfirmEmailAsync(userId, token);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [AllowAnonymous]
        [HttpPost("forgot-password")]
        public async Task<IActionResult> ForgotPassword([FromBody] ForgotPasswordDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _userService.GeneratePasswordResetTokenAsync(model.Email);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }

        [AllowAnonymous]
        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDTO model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _userService.ResetPasswordAsync(model);
            if (!result.Success)
            {
                return BadRequest(result.Message);
            }

            return Ok(result.Message);
        }

        [HttpPost("logout")]
        public async Task<IActionResult> Logout()
        {
            var result = await _userService.LogoutAsync();
            if (result.Success)
            {
                return Ok(result.Message);
            }
            return BadRequest(result.Message);
        }
    }
}
