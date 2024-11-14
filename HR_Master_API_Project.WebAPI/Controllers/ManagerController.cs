using HRMaster_API_Project.BLL.Services.ManagerService;
using HRMaster_API_Project.BLL.Services.Models.DTOs;
using HRMaster_API_Project.BLL.Services.Models.DTOs.ManagerDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.UserDTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


[ApiController]
[Route("api/[controller]")]
public class ManagerController : ControllerBase
{
    private readonly IManagerServices _managerServices;

    public ManagerController(IManagerServices managerServices)
    {
        _managerServices = managerServices;
    }

    [HttpPost("add-employee")]
    public async Task<IActionResult> AddNewEmployee([FromBody] AddNewUserDTO newUserDTO)
    {
        var result = await _managerServices.AddNewEmployeeAsync(newUserDTO);
        if (result.Success)
        {
            return Ok(result.Message);
        }

        return BadRequest(result.Message);
    }

    //[HttpGet("get-manager-info/{id}")]
    //public async Task<IActionResult> GetManagerInfo([FromBody] int id)
    //{
    //    var result = await _managerServices.GetManagerInfoAsync(id);
    //    if (result != null)
    //    {
    //        return Ok(result);
    //    }
    //}

    [HttpPost("assign-department-manager/{employeeId}")]
    public async Task<IActionResult> AssignDepartmentManager(int employeeId)
    {
        var result = await _managerServices.AssignDepartmentManagerRoleAsync(employeeId);
        if (result.Success)
        {
            return Ok(result.Message);
        }

        return BadRequest(result.Message);
    }

    [HttpGet("get-manager-detail/{managerID}")]
    public async Task<IActionResult> GetManagerDetailAsync(int managerID)
    {
        var manager = await _managerServices.GetManagerDetailAsync(managerID);
        return Ok(manager);
    }
    

    [HttpGet("GetLoggedInManager")]
    public async Task<IActionResult> GetLoggedInManager()
    {
        var result = await _managerServices.GetLoggedInManagerAsync();
        if (!result.Success)
        {
            return BadRequest(new { result.Message, result.Errors });
        }

        // result.Data ManagerDTO türünde olmalı
        var managerDto = (Manager_DTO)result.Data;

        return Ok(managerDto);

    }
    [HttpGet("GetManagerIndexVM/{managerId}")]
    public async Task<IActionResult> GetManagerIndexDTO(int managerId)
    {
        var result = await _managerServices.GetManagerIndexVMAsync(managerId);
        if(result != null)
        {
            return Ok(result);
        }
        return BadRequest();
    }

    [HttpPut("update-manager/{id}")]
    public async Task<IActionResult> UpdateManagerInfo(int id, UpdateManagerDetailsDTO updMngDTO)
    {
        var result = await _managerServices.UpdateManagerDetailsAsync(id, updMngDTO);
        if (result.Success)
        {
            return Ok($"{result.Message}");

        }
        return BadRequest(result);

    }

    [HttpGet("get-all-ceos")]
    public async Task<IActionResult> GetAllCEOs()
    {
        try
        {
            var ceos = await _managerServices.GetAllCEOsAsync();
            return Ok(ceos);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpPost("assign-department")]
    public async Task<IActionResult> AssignDepartmentToEmployee(AssignDepartmentDTO assignDepartmentDTO)
    {
        var result = await _managerServices.AssignDepartmentToEmployeeAsync(assignDepartmentDTO.EmployeeID,assignDepartmentDTO.SelectedDepartmentID);
        if (result.Success)
        {
            return Ok(result.Message);
        }

        return BadRequest(result.Message);
    }
}



//[HttpPost("update-details")]
//public async Task<IActionResult> UpdateManagerDetails([FromBody] UpdateManagerDetailsDTO updateDto)
//{
//    var result = await _managerServices.UpdateManagerDetailsAsync(updateDto);
//    if (!result.Success)
//    {
//        return BadRequest(new { result.Message, result.Errors });
//    }

//    return Ok(result.Message);
//}



