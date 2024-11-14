using HRMaster_API_Project.BLL.Services.Models.DTOs.LoginDTO;
using HRMaster_API_Project.BLL.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HRMaster_API_Project.BLL.Services.Models.DTOs.UserDTO;
using HRMaster_API_Project.BLL.Services.AdminService;

using HRMaster_API_Project.BLL.Services.Models.DTOs.AdminDTO;

using Microsoft.AspNetCore.Authorization;

namespace HR_Master_API_Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpPost("add-new-manager")]
        public async Task<IActionResult> AddNewManager([FromBody] AddNewUserDTO newUserDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            else
                {
                 var result= await _adminService.AddNewManagerAsync(newUserDTO);
                return Ok(result);
                }

        }

        [HttpGet("get-admin-summary/{adminId}")]
        public async Task<IActionResult> GetAdminSummary(int adminId)
        {
            var result = await _adminService.GetAdminSummaryAsync(adminId);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpGet("get-admin-detail/{adminId}")]
        public async Task<IActionResult> GetAdminDetail(int adminId)
        {
            var result = await _adminService.GetAdminDetailAsync(adminId);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpPut("update-user/{id}")]
        public async Task<IActionResult> UpdateAdminInfo(int id, UpdateAdminDetailDTO updateAdminDetailDTO)
        {
            var result = await _adminService.UpdateAdminDetailsAsync(id, updateAdminDetailDTO);
            if (result.Success)
            {
                return Ok($"{result.Message}");
            }
            return BadRequest(result);
        }


    }
}
