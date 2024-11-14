using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.DTOs.CompanyDTO
{
    public class ShowCompanyDTO
    {
        public int ID { get; set; }

        public string? CompanyName { get; set; }

        public string? LogoPath { get; set; }
        public string? CompanyEmail { get; set; }
        public string? CompanyPhoneNumber { get; set; }

    }
}
