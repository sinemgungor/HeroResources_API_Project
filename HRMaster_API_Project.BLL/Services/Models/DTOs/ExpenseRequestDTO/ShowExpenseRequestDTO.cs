using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.DTOs.ExpenseRequestDTO
{
    public class ShowExpenseRequestDTO
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime RequestDate { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        public DateTime? ResponseDate { get; set; }
        public ExpenseType ExpenseType { get; set; }

        public string FilePath { get; set; }

    }
}
