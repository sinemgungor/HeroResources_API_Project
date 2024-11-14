using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.DTOs.LeaveRequestDTO
{
    public class AddLeaveRequestDTO
    {
        public LeaveType LeaveType { get; set; }
        public DateOnly LeaveStartingDate { get; set; }
        public DateOnly LeaveEndDate { get; set; }
        public double LeaveDays { get; set; }

        public int EmployeeID { get; set; }
    }
}
