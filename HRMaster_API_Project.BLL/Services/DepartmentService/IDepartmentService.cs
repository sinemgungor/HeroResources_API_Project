using HRMaster_API_Project.BLL.Services.Models.DTOs.DepartmentDTO;
using HRMaster_API_Project.BLL.Services.Models.EmployeeDTO;
using HRMaster_API_Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.DepartmentService
{
    public interface IDepartmentService
    {
        Task<IEnumerable<Department_DTO>> GetAllCompanyDepartmentAsync(int companyID);
        Task<Department_DTO?> GetDepartmentByIdAsync(int id);
        Task<int> AddDepartmentAsync(AddNewDepartmentDTO newDepartmentDTO,int companyID);
        Task UpdateDepartment(UpdateDepartmentDTO updateDepartmentDTO);
        
        Task<IEnumerable<EmployeeSummary_DTO>>GetDepartmentEmployeesAsync(int departmentID);
        
    }
}
