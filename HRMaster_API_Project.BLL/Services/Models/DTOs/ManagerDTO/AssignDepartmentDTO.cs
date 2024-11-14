using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.DTOs.ManagerDTO
{
    public class AssignDepartmentDTO
    {
        public int EmployeeID { get; set; }
        public int SelectedDepartmentID { get; set; }
    }
}
