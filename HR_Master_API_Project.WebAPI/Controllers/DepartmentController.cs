using HRMaster_API_Project.BLL.Services.DepartmentService;
using HRMaster_API_Project.BLL.Services.Models.DTOs.DepartmentDTO;
using Microsoft.AspNetCore.Mvc;

namespace HR_Master_API_Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmantService;

        public DepartmentController(IDepartmentService departmantService)
        {
            _departmantService = departmantService; 
        }

        // GET: api/<DepartmentController>
        [HttpGet("Get-All-Departments/{companyID}")]
        public async Task<IActionResult> GetAllDepartments(int companyID)
        {
            var departments = await _departmantService.GetAllCompanyDepartmentAsync(companyID);
            return Ok(departments);
        }
        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }


        [HttpPost("Add-Department/{companyID}")]
        public async Task<IActionResult> AddDepartment(AddNewDepartmentDTO addNewDepartmentDTO, int companyID)
        {
            var result = await _departmantService.AddDepartmentAsync(addNewDepartmentDTO, companyID);

            if (result > 0)
            {
                return NoContent(); // Başarılı
            }
            else if (result == -1)
            {
                return BadRequest("Bu şirket için aynı isimde bir departman zaten mevcut."); // Aynı isimde departman var
            }
            else
            {
                return BadRequest("Departman eklenirken bir hata oluştu."); // Başka bir hata
            }
        }


        // PUT api/<DepartmentController>/5

        [HttpPost("Get-Department-Employees/{departmentID}")]
        public async Task<IActionResult> GetDepartmentEmployees(int departmentID)
        {
            var employees= await _departmantService.GetDepartmentEmployeesAsync(departmentID);
            return Ok(employees);   
        }

       

        // DELETE api/<DepartmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

    }
}
