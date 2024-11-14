using HRMaster_API_Project.BLL.Services.AdvanceRequestService;
using HRMaster_API_Project.BLL.Services.Models.DTOs.AdvanceRequestDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.LeaveRequestDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_Master_API_Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvanceRequestController : ControllerBase
    {
        private readonly IAdvanceRequestServices _advanceRequestService;

        public AdvanceRequestController(IAdvanceRequestServices advanceRequestService)
        {
            _advanceRequestService = advanceRequestService;
        }

        [HttpGet("get-advanceRequestsForManager/{companyID}")]
        public async Task<IActionResult> GetAdvanceRequestsForManagerAsync(int companyID)
        {
            if (companyID != 0)
            {
                var result = await _advanceRequestService.GetAllAdvanceRequestsForManagerAsync(companyID);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else return BadRequest();
        }

        [HttpGet("get-advanceRequestsForEmployee/{employeeID}")]
        public async Task<IActionResult> GetAdvanceRequestsForEmployeeAsync(int employeeID)
        {
            if (employeeID != 0)
            {
                var result = await _advanceRequestService.GetAllExpenseRequestsForEmployeeAsync(employeeID);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else return BadRequest();
        }


        [HttpPost("add-advanceRequest")]
        public async Task<IActionResult> AddAdvanceRequest(AddAdvanceRequestDTO newAdvanceDTO)
        {
            if (newAdvanceDTO != null)
            {
                var result = await _advanceRequestService.AddAdvanceRequestAsync(newAdvanceDTO);
                return Ok(result);
            }
            else
            {
                return BadRequest("Invalid leave request data.");
            }
        }

        [HttpPut("approve-advanceRequest/{id}")]
        public async Task<IActionResult> ApproveExpenseRequestAsync(int id)
        {
            if (id != 0)
            {
                var result = await _advanceRequestService.ApproveAdvanceRequestAsync(id);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else return BadRequest();

        }

        [HttpPut("reject-advanceRequest/{id}")]
        public async Task<IActionResult> RejectExpenseRequestAsync(int id)
        {
            if (id != 0)
            {
                var result = await _advanceRequestService.RejectAdvanceRequestAsync(id);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else return BadRequest();

        }

        [HttpPut("cancel-advanceRequest/{id}")]
        public async Task<IActionResult> CancelExpenseRequestAsync(int id)
        {
            if (id != 0)
            {
                var result = await _advanceRequestService.CancelAdvanceRequestAsync(id);
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
