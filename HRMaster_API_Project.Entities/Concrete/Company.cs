using HRMaster_API_Project.Entities.Abstract;
using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.Entities.Concrete
{
    public class Company:BaseEntity
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

        public DateOnly EstablishedDate { get; set; }

        public DateOnly ContractStartingDate { get; set; }

        public DateOnly ContractEndDate { get; set; }

        public string CompanyInformation { get; set; }

        public int? CEOId { get; set; }
        public User? CEO { get; set; }

        public ICollection<User>? Employees { get; set; }
        public ICollection<Department>? Departments { get; set; }
    }
}
