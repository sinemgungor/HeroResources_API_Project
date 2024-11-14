using HRMaster_API_Project.BLL.Services.Models.DTOs.ManagerDTO;
using HRMaster_API_Project.BLL.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMaster_API_Project.BLL.Services.Models.DTOs.EmployeeDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.AdminDTO;

namespace HRMaster_API_Project.BLL.Services.EmployeeService
{
    public interface IEmployeeServices
    {
        Task<ServiceResult> UpdateEmployeeAsync(int id, UpdateEmployeeDTO updateDto);
        Task<EmployeeSummaryDTO> GetEmployeeSummaryAsync(int employeeId);
        Task<EmployeeDTO> GetEmployeeDetailAsync(int employeeId);
        Task<bool> IsEmployeeExistAsync(string username);
    }
}
