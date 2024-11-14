using HRMaster_API_Project.BLL.Services.Models.DTOs.ExpenseRequestDTO;
using HRMaster_API_Project.BLL.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMaster_API_Project.BLL.Services.Models.DTOs.LeaveRequestDTO;

namespace HRMaster_API_Project.BLL.Services.LeaveRequestService
{
    public interface ILeaveRequestServices
    {
        Task<ServiceResult> GetAllLeaveRequestsForManagerAsync(int companyID);
        Task<ServiceResult> GetAllLeaveRequestsForEmployeeAsync(int employeeID);
        Task<ServiceResult> AddLeaveRequestAsync(AddLeaveRequestDTO newLeaveDTO);


        Task<ServiceResult> ApproveLeaveRequestAsync(int id);
        Task<ServiceResult> RejectLeaveRequestAsync(int id);
        Task<ServiceResult> CancelLeaveRequestAsync(int id);
    }
}
