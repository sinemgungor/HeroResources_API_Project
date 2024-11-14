using HRMaster_API_Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.DAL.Repositories.Abstract
{
    public interface ILeaveRequestManager:IRepository<LeaveRequest>
    {
        Task<List<LeaveRequest>> GetLeaveRequestsForManagerAsync(int companyID);
        Task<List<LeaveRequest>> GetLeaveRequestsForEmployeeAsync(int employeeID);

        Task<bool> ApproveLeaveRequestAsync(int id);
        Task<bool> RejectLeaveRequestAsync(int id);
        Task<bool> CancelLeaveRequestAsync(int id);
    }
}
