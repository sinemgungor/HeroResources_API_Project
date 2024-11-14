using AutoMapper;
using HRMaster_API_Project.BLL.Services.Models.DTOs.LeaveRequestDTO;
using HRMaster_API_Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Mapper
{
    public class LeaveRequestMapper:Profile
    {
        public LeaveRequestMapper()
        {
            CreateMap<LeaveRequest, AddLeaveRequestDTO>().ReverseMap();
        }
    }
}
