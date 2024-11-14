using AutoMapper;
using HRMaster_API_Project.BLL.Services.Models.DTOs.CompanyDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.DepartmentDTO;
using HRMaster_API_Project.BLL.Services.Models.EmployeeDTO;
using HRMaster_API_Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Mapper
{
    public class DepartmentMapper :Profile
    {
        public DepartmentMapper()
        {
            CreateMap<Department, AddNewDepartmentDTO>().ReverseMap();
            CreateMap<Department, Department_DTO>().ReverseMap();
            CreateMap<User,EmployeeSummary_DTO>().ReverseMap();    
        }

    }
}
