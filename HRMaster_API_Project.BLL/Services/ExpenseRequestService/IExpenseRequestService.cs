using HRMaster_API_Project.BLL.Services.Models;
using HRMaster_API_Project.BLL.Services.Models.DTOs.ExpenseRequestDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.ExpenseRequestService
{
    public interface IExpenseRequestService
    {

        Task<ServiceResult> GetAllExpenseRequestsForManagerAsync(int companyID);
        Task<ServiceResult> GetAllExpenseRequestsForEmployeeAsync(int employeeID);

        Task<ServiceResult> AddExpenseRequestAsync(AddExpenseRequestDTO newExpenseDTO);

        Task<ServiceResult> ApproveExpenseRequestAsync(int id);
        Task<ServiceResult> RejectExpenseRequestAsync(int id);
        Task<ServiceResult> CancelExpenseRequestAsync(int id);
        Task<ServiceResult> GetFilePathAsync(int id);
    }
}
