using HRMaster_API_Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.DAL.Repositories.Abstract
{
    public interface IExpenseRequestManager:IRepository<ExpenseRequest>
    {
        Task<List<ExpenseRequest>> GetExpenseRequestsForManagerAsync(int companyID);
        Task<List<ExpenseRequest>> GetExpenseRequestsForEmployeeAsync(int companyID);

        Task<bool> ApproveExpenseRequestAsync(int id);
        Task<bool> RejectExpenseRequestAsync(int id);
        Task<bool> CancelExpenseRequestAsync(int id);
    }
}
