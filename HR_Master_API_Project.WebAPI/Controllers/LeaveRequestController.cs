using HRMaster_API_Project.BLL.Services.LeaveRequestService;
using HRMaster_API_Project.BLL.Services.Models.DTOs.LeaveRequestDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_Master_API_Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestController : ControllerBase
    {
        private readonly ILeaveRequestServices _leaveRequestService;

        public LeaveRequestController(ILeaveRequestServices leaveRequestService)
        {
            _leaveRequestService = leaveRequestService;
        }

        [HttpGet("get-leaveRequestsForManager/{companyID}")]
        public async Task<IActionResult> GetLeaveRequestsForManagerAsync(int companyID)
        {
            if (companyID != 0)
            {
                var result = await _leaveRequestService.GetAllLeaveRequestsForManagerAsync(companyID);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else return BadRequest();
        }

        [HttpGet("get-leaveRequestsForEmployee/{employeeID}")]
        public async Task<IActionResult> GetLeaveRequestsForEmployeeAsync(int employeeID)
        {
            if (employeeID != 0)
            {
                var result = await _leaveRequestService.GetAllLeaveRequestsForEmployeeAsync(employeeID);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else return BadRequest();
        }

        [HttpPost("add-leaveRequest")]
        public async Task<IActionResult> AddLeaveRequest(AddLeaveRequestDTO newLeaveDTO)
        {
            if (newLeaveDTO != null)
            {
                var result = await _leaveRequestService.AddLeaveRequestAsync(newLeaveDTO);
                return Ok(result);
            }
            else
            {
                return BadRequest("Invalid leave request data.");
            }
        }

        [HttpPut("approve-leaveRequest/{id}")]
        public async Task<IActionResult> ApproveExpenseRequestAsync(int id)
        {
            if (id != 0)
            {
                var result = await _leaveRequestService.ApproveLeaveRequestAsync(id);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else return BadRequest();

        }

        [HttpPut("reject-leaveRequest/{id}")]
        public async Task<IActionResult> RejectExpenseRequestAsync(int id)
        {
            if (id != 0)
            {
                var result = await _leaveRequestService.RejectLeaveRequestAsync(id);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else return BadRequest();

        }

        [HttpPut("cancel-leaveRequest/{id}")]
        public async Task<IActionResult> CancelLeaveRequestAsync(int id)
        {
            if (id != 0)
            {
                var result = await _leaveRequestService.CancelLeaveRequestAsync(id);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else return BadRequest();

        }
    }
}
