using HRMaster_API_Project.BLL.Services.Models.DTOs.LeaveRequestDTO;
using HRMaster_API_Project.BLL.Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMaster_API_Project.BLL.Services.Models.DTOs.AdvanceRequestDTO;

namespace HRMaster_API_Project.BLL.Services.AdvanceRequestService
{
    public interface IAdvanceRequestServices
    {
        Task<ServiceResult> GetAllAdvanceRequestsForManagerAsync(int companyID);
        Task<ServiceResult> GetAllExpenseRequestsForEmployeeAsync(int employeeID);
        Task<ServiceResult> AddAdvanceRequestAsync(AddAdvanceRequestDTO newAdvanceDTO);

        Task<ServiceResult> ApproveAdvanceRequestAsync(int id);
        Task<ServiceResult> RejectAdvanceRequestAsync(int id);
        Task<ServiceResult> CancelAdvanceRequestAsync(int id);
    }
}
