using HRMaster_API_Project.BLL.Services;
using HRMaster_API_Project.BLL.Services.CompanyService;
using HRMaster_API_Project.BLL.Services.Models.DTOs.CompanyDTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_Master_API_Project.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;

        }

        // GET: api/<CompanyController>
        [HttpGet("get-all-companies")]
        public async Task<IActionResult> Get()
        {
            var companies = await _companyService.GetAllCompaniesAsync();
            return Ok(companies);
        }


        [HttpPost("add-company")]
        public async Task<IActionResult> AddCompany(AddNewCompanyDTO newCompanyDTO)
        {
            if (newCompanyDTO != null)
            {
                var result = await _companyService.AddCompanyAsync(newCompanyDTO);
                return Ok(result);
            }
            else
                return BadRequest();
        }

        [HttpGet("get-company/{id}")]
        public async Task<IActionResult> GetCompanyById(int id)
        {
            if (ModelState.IsValid) 
            { 
                var company= await _companyService.GetCompanyByIdAsync(id);
                return Ok(company);
            }
            else 
                return BadRequest(); 
        }
        
        

        [HttpPut("update-company/{id}")]
        public async Task<IActionResult> UpdateCompany(UpdateCompanyDTO updCompanyDTO,int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _companyService.UpdateCompanyAsync(updCompanyDTO, id);
                if (result)
                {
                    return NoContent(); 
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {

                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

    }
}
