using HRMaster_API_Project.Entities.Abstract;
using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.Entities.Concrete
{
    public class LeaveRequest:BaseEntity
    {
        public LeaveType LeaveType { get; set; }
        public DateOnly LeaveStartingDate { get; set; }
        public DateOnly LeaveEndDate { get; set; }
        public double LeaveDays { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        public DateTime? ResponseDate { get; set; }
        public DateTime RequestDate { get; set; }

        public int EmployeeID { get; set; }
        public User? Employee { get; set; }
    }
}
