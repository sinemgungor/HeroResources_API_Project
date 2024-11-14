using AutoMapper;
using HRMaster_API_Project.BLL.Services.Models.DTOs.AdvanceRequestDTO;
using HRMaster_API_Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Mapper
{
    public class AdvanceRequestMapper:Profile
    {
        public AdvanceRequestMapper()
        {
            CreateMap<AdvanceRequest, AddAdvanceRequestDTO>().ReverseMap();
        }
    }
}
