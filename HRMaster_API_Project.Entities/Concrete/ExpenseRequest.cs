using HRMaster_API_Project.Entities.Abstract;
using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.Entities.Concrete
{
    public class ExpenseRequest:BaseEntity
    {

        public ExpenseType ExpenseType { get; set; }
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime? ResponseDate { get; set; }
        public string FilePath { get; set; }

        public int EmployeeID { get; set; }
        public User? Employee { get; set; }
    }
}
