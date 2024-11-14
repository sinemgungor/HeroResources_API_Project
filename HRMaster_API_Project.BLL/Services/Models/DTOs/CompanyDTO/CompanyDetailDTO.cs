using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.DTOs.CompanyDTO
{
    public class CompanyDetailDTO
    {
        public string CompanyName { get; set; }

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

        public DateOnly EstablishedDate { get; set; }

        public string CompanyInformation { get; set; }

        public int EmployeeCount { get; set; }
        public Status Status { get; set; }
        public int? CEOId { get; set; }

    }
}
