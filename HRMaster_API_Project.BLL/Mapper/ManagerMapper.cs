using AutoMapper;
using HRMaster_API_Project.BLL.Services.Models.DTOs.DepartmentDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.ManagerDTO;
using HRMaster_API_Project.BLL.Services.Models.EmployeeDTO;
using HRMaster_API_Project.Entities.Concrete;
using HRMaster_MVC_Project.Areas.CEOPanel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Mapper
{
    public class ManagerMapper:Profile
    {
        public ManagerMapper()
        {
            CreateMap<User, ManagerDetailDTO>().ReverseMap();
            CreateMap<User, ManagerSumInfoDTO>().ReverseMap();
            CreateMap<User, ManagerListDTO>()
            .ForMember(dest => dest.CompanyName, opt => opt.MapFrom(src => src.CEORelatedCompany.CompanyName)).ReverseMap();
            CreateMap<User, EmployeeSummary_DTO>()
                .ForMember(dest => dest.Department, opt => opt.MapFrom(src => new Department_DTO
                {
                    ID = src.Department.ID,
                    DepartmentName = src.Department.DepartmentName
                }))
                .ReverseMap();
    
        }
    }
}
