﻿using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.DTOs.ExpenseRequestDTO
{
    public class AddExpenseRequestDTO
    {
        public ExpenseType ExpenseType { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public string FilePath { get; set; }

        public int EmployeeID { get; set; }
    }
}
