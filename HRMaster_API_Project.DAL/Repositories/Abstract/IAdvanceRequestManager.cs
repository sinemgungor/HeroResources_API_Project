using HRMaster_API_Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.DAL.Repositories.Abstract
{
    public interface IAdvanceRequestManager:IRepository<AdvanceRequest>
    {
        Task<List<AdvanceRequest>> GetAdvanceRequestsForManagerAsync(int companyID);
        Task<List<AdvanceRequest>> GetAdvanceRequestsForEmployeeAsync(int employeeID);


        Task<bool> ApproveAdvanceRequestAsync(int id);
        Task<bool> RejectAdvanceRequestAsync(int id);
        Task<bool> CancelAdvanceRequestAsync(int id);
    }
}
