using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.DTOs.CompanyDTO
{
    public class AddNewCompanyDTO
    {
        public string CompanyName { get; set; }

        public string CompanyTitle { get; set; }

        public string? LogoPath { get; set; }

        public string MersisNumber { get; set; }

        public string TaxOfficeName { get; set; }

        public string TaxIdentificaitonNumber { get; set; }

        public string CompanyAddress { get; set; }

        public string CompanyPhoneNumber { get; set; }

        public string CompanyEmail { get; set; }


        public string? CompanyWebsite { get; set; }

        public CompanyType CompanyType { get; set; }

        public CompanyField CompanyField { get; set; }

        public DateOnly EstablishedDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

        public DateOnly ContractStartingDate { get; set; }
        public DateOnly ContractEndDate { get; set; }

        public string CompanyInformation { get; set; }
    }
}
