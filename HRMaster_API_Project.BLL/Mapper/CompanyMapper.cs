using AutoMapper;
using HRMaster_API_Project.BLL.Services.Models.DTOs.CompanyDTO;
using HRMaster_API_Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Mapper
{
    public class CompanyMapper:Profile
    {
        public CompanyMapper()
        {
            CreateMap<Company, AddNewCompanyDTO>()
             .ForMember(dest => dest.CompanyAddress, opt => opt.MapFrom(src => src.CompanyAddress))// CompanyAddress dahil
             .ReverseMap();

            //CreateMap<Company,CompanyDetailDTO>().ReverseMap();
            CreateMap<Company, CompanyDetailDTO>()
            .ForMember(dest => dest.EmployeeCount, opt => opt.MapFrom(src => src.Employees.Count))
             .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status)).ReverseMap();
            CreateMap<Company,ShowCompanyDTO>().ReverseMap();
            CreateMap<Company, Company_DTO>()
          .ReverseMap();
        }
    }
}
