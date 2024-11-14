using HRMaster_API_Project.BLL.Services.CompanyService;
using HRMaster_API_Project.BLL.Services.ExpenseRequestService;
using HRMaster_API_Project.BLL.Services.Models.DTOs.CompanyDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.ExpenseRequestDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_Master_API_Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpenseRequestController : ControllerBase
    {

        private readonly IExpenseRequestService _expenseRequestService;

        public ExpenseRequestController(IExpenseRequestService expenseRequestService)
        {
            _expenseRequestService = expenseRequestService;

        }

        //[HttpGet("get-all-expenseRequests")]
        //public async Task<IActionResult> GetAllExpenseRequest() 
        //{
        //    var expenses = await _expenseRequestService.GetAllExpenseRequestsAsync();
        //}

        [HttpPost("add-expenseRequest")]
        public async Task<IActionResult> AddExpenseRequestAsync(AddExpenseRequestDTO newExpenseDTO)
        {
            if (newExpenseDTO != null)
            {
                var result = await _expenseRequestService.AddExpenseRequestAsync(newExpenseDTO);
                return Ok(result);
            }
            else
                return BadRequest();
        }

        [HttpGet("get-expenseRequestsForManager/{companyID}")]
        public async Task<IActionResult> GetExpenseRequestsForManagerAsync(int companyID)
        {
            if (companyID != 0)
            {
                var result = await _expenseRequestService.GetAllExpenseRequestsForManagerAsync(companyID);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else return BadRequest();   
        }        
        
        [HttpGet("get-expenseRequestsForEmployee/{employeeID}")]
        public async Task<IActionResult> GetExpenseRequestsForEmployeeAsync(int employeeID)
        {
            if (employeeID != 0)
            {
                var result = await _expenseRequestService.GetAllExpenseRequestsForEmployeeAsync(employeeID);
                if (result.Success)
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else return BadRequest();   
        }

        [HttpPut("approve-expenseRequest/{id}")]
        public async Task<IActionResult> ApproveExpenseRequestAsync(int id)
        {
            if (id != 0)
            {
                var result = await _expenseRequestService.ApproveExpenseRequestAsync(id);
                if(result.Success) 
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else return BadRequest();
        
        }        
        
        [HttpPut("reject-expenseRequest/{id}")]
        public async Task<IActionResult> RejectExpenseRequestAsync(int id)
        {
            if (id != 0)
            {
                var result = await _expenseRequestService.RejectExpenseRequestAsync(id);
                if(result.Success) 
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else return BadRequest();
        
        }        
        
        [HttpPut("cancel-expenseRequest/{id}")]
        public async Task<IActionResult> CancelExpenseRequestAsync(int id)
        {
            if (id != 0)
            {
                var result = await _expenseRequestService.CancelExpenseRequestAsync(id);
                if(result.Success) 
                {
                    return Ok(result);
                }
                else
                    return BadRequest();
            }
            else return BadRequest();
        
        }
        [HttpGet("get-filePath/{id}")]
        public async Task<IActionResult> GetFilePathAsync(int id)
        {
            if (id != 0)
            {
                var result = await _expenseRequestService.GetFilePathAsync(id);
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
