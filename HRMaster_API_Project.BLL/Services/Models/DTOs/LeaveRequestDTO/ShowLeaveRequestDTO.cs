using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.DTOs.LeaveRequestDTO
{
    public class ShowLeaveRequestDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly LeaveStartingDate { get; set; }
        public DateOnly LeaveEndDate { get; set; }
        public double LeaveDays { get; set; }
        public LeaveType LeaveType { get; set; }
        public ApprovalStatus ApprovalStatus { get; set; }
        public DateTime? ResponseDate { get; set; }
        public DateTime RequestDate { get; set; }
    }
}
