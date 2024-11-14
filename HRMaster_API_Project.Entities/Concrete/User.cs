using HRMaster_API_Project.Entities.Abstract;
using HRMaster_API_Project.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.Entities.Concrete
{
    public class User:IdentityUser<int>
    {

        public string? Name { get; set; }

        public string? SecondName { get; set; }

        public string? Surname { get; set; }

        public string? SecondSurname { get; set; }

        public string? PicturePath { get; set; }

        public DateOnly? BirthDate { get; set; }

        public string? BirthState { get; set; }

        public string? IdentityNumber { get; set; }

        public DateOnly? HireDate { get; set; }

        public DateOnly? TerminationDate { get; set; }

        public string? Job { get; set; }

        public string? Address { get; set; }

        public double? Salary { get; set; }

        public string? Title { get; set; }

        public BloodGroup? BloodGroup { get; set; }

        public Gender? Gender { get; set; }

        public MarialStatus? MarialStatus { get; set; }

        public Status Status { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? UpdatedDate { get; set; }


        public int? DepartmentID { get; set; }
        public Department? Department { get; set; }


        // CEO için navigasyon özelliği
        public int? CEORelatedCompanyID { get; set; }
        public Company? CEORelatedCompany { get; set; }

        // Employee için navigasyon özelliği
        public int? EmployeeRelatedCompanyID { get; set; }
        public Company? EmployeeRelatedCompany { get; set; }

        public ICollection<AdvanceRequest>? AdvanceRequests { get; set; }
        public ICollection<LeaveRequest>? LeaveRequests { get; set; }
        public ICollection<ExpenseRequest>? ExpenseRequests { get; set; }

    }
}
