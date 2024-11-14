using AutoMapper;
using HRMaster_API_Project.BLL.Services.Models.DTOs.DepartmentDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.EmployeeDTO;
using HRMaster_API_Project.BLL.Services.Models.EmployeeDTO;
using HRMaster_API_Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Mapper
{
    public class EmployeeMapper:Profile
    {
        public EmployeeMapper() 
        {
            CreateMap<User, EmployeeDTO>()
            .ForMember(dest => dest.Company, opt => opt.MapFrom(src => src.EmployeeRelatedCompany))
            .ForMember(dest => dest.Department, opt => opt.MapFrom(src => src.Department))
            .ReverseMap();
            CreateMap<User, EmployeeSummaryDTO>()
              .ForMember(dest => dest.Department, opt => opt.MapFrom(src => new Department_DTO
              {
                  ID = src.Department.ID,
                  DepartmentName = src.Department.DepartmentName
              }))
              .ReverseMap();


        }
    }
}
