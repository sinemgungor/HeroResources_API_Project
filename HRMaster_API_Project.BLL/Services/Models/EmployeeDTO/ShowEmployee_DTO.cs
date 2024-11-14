using HRMaster_API_Project.BLL.Services.Models.DTOs.DepartmentDTO;
using HRMaster_API_Project.Entities.Concrete;
using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.EmployeeDTO
{
    public class EmployeeSummary_DTO
    {
        public int ID { get; set; }

        public string? Name { get; set; }

        public string? Surname { get; set; }

        public string? PicturePath { get; set; }

        public string? Title { get; set; }
        public Department_DTO? Department { get; set; }

    }
}
