using HRMaster_API_Project.BLL.Services.EmployeeService;
using HRMaster_API_Project.BLL.Services.Models.DTOs.EmployeeDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_Master_API_Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServices _employeeServices;

        public EmployeeController(IEmployeeServices employeeServices)
        {
            _employeeServices = employeeServices;
        }

        [HttpGet("employee-exist/{username}")]
        public async Task<IActionResult> GetEmployeeByUserName(string username)
        {
            var result = await _employeeServices.IsEmployeeExistAsync(username);
            if (result)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }

        [HttpPut("update-employee/{id}")]
        public async Task<IActionResult> UpdateEmployeeInfo(int id, UpdateEmployeeDTO updEmpDTO)
        {
            var result = await _employeeServices.UpdateEmployeeAsync(id, updEmpDTO);
            if (result.Success)
            {
                return Ok($"{result.Message}");
            }
            return BadRequest(result);

        }

        [HttpGet("get-employee-summary/{employeeId}")]
        public async Task<IActionResult> GetEmployeeSummary(int employeeId)
        {
            var result = await _employeeServices.GetEmployeeSummaryAsync(employeeId);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

        [HttpGet("get-employee-detail/{employeeId}")]
        public async Task<IActionResult> GetEmployeeDetail(int employeeId)
        {
            var result = await _employeeServices.GetEmployeeDetailAsync(employeeId);
            if (result != null)
            {
                return Ok(result);
            }
            return NotFound();
        }

    }
}
