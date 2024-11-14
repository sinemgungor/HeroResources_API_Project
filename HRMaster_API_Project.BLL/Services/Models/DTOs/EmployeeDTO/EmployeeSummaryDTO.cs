using HRMaster_API_Project.BLL.Services.Models.DTOs.DepartmentDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.DTOs.EmployeeDTO
{
    public class EmployeeSummaryDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Job { get; set; }
        public string PicturePath { get; set; }
        public Department_DTO? Department { get; set; }
    }
}
