using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.DTOs.CompanyDTO
{
    public class UpdateCompanyDTO
    { 
        public string CompanyAddress { get; set; }

        public string CompanyPhoneNumber { get; set; }

        public string? CompanyWebsite { get; set; }

        public string? LogoPath { get; set; }
    }
}
