using HRMaster_API_Project.BLL.Services.Models.EmployeeDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.DTOs.ManagerDTO
{
    public class ManagerIndexDTO
    {
        public ManagerSumInfoDTO ManagerSumInfo { get; set; }
        public List<EmployeeSummary_DTO> ShowEmployees { get; set; }   

    }
}
