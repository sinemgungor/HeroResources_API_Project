﻿using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.DTOs.UserDTO
{
    public class AddNewUserDTO
    {
        public string Name { get; set; }
        public string? SecondName { get; set; }
        public string Surname { get; set; }
        public string? SecondSurname { get; set; }
        public string Job { get; set; }
        public string Title { get; set; }

        public string IdentityNumber { get; set; }
        public string Picture { get; set; }
        public DateOnly BirthDate { get; set; }

        public string BirthState { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }
        public DateOnly HireDate { get; set; }

        public double Salary { get; set; }
        public string PhoneNumber { get; set; }

        public Gender Gender { get; set; }

        public MarialStatus MarialStatus { get; set; }
        public BloodGroup BloodGroup { get; set; }
        public string? Department { get; set; }

        public int? CompanyID { get; set; }  

    }
}
