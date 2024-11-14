using AutoMapper;
using HRMaster_API_Project.BLL.Services.Models.DTOs.ExpenseRequestDTO;
using HRMaster_API_Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Mapper
{
    public class ExpenseRequestMapper:Profile
    {
        public ExpenseRequestMapper() 
        {
            CreateMap<ExpenseRequest, AddExpenseRequestDTO>().ReverseMap();

        }

    }
}
