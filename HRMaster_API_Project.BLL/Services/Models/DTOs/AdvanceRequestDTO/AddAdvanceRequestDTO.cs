using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.DTOs.AdvanceRequestDTO
{
    public class AddAdvanceRequestDTO
    {
        public decimal Amount { get; set; }
        public Currency Currency { get; set; }
        public string Description { get; set; }
        public AdvanceType AdvanceType { get; set; }

        public int EmployeeID { get; set; }
    }
}
