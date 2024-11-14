using HRMaster_API_Project.DAL.Context;
using HRMaster_API_Project.DAL.Repositories.Abstract;
using HRMaster_API_Project.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.DAL.Repositories.Concrete
{
    public class ExpenseRequestManager : Repository<ExpenseRequest>, IExpenseRequestManager
    {

        private readonly AppDbContext _dbContext;

        public ExpenseRequestManager(AppDbContext context) : base(context)
        {
            _dbContext = context;
        }

        public async Task<List<ExpenseRequest>> GetExpenseRequestsForManagerAsync(int companyID)
        {
            var expenses = await _dbContext.ExpenseRequests.Include(x => x.Employee).Where(x => x.Employee.EmployeeRelatedCompanyID == companyID).ToListAsync();
            return expenses;   
        }       
        public async Task<List<ExpenseRequest>> GetExpenseRequestsForEmployeeAsync(int employeeID)
        {
            var expenses = await _dbContext.ExpenseRequests.Include(x => x.Employee).Where(x => x.Employee.Id==employeeID).ToListAsync();
            return expenses;   
        }

        public async Task<bool> ApproveExpenseRequestAsync(int id)
        {
            var request= await _dbContext.ExpenseRequests.FindAsync(id);

            request.ApprovalStatus=Entities.Enums.ApprovalStatus.Approved;
            request.ResponseDate=DateTime.Now;  
            return await UpdateAsync(request);  
        }        
        public async Task<bool> RejectExpenseRequestAsync(int id)
        {
            var request= await _dbContext.ExpenseRequests.FindAsync(id);

            request.ApprovalStatus=Entities.Enums.ApprovalStatus.Rejected;
            request.ResponseDate=DateTime.Now;  
            return await UpdateAsync(request);  
        }

        public async Task<bool> CancelExpenseRequestAsync(int id)
        {
            var request = await _dbContext.ExpenseRequests.FindAsync(id);

            request.ApprovalStatus = Entities.Enums.ApprovalStatus.Cancelled;
            request.ResponseDate = DateTime.Now;
            return await UpdateAsync(request);
        }
    }
}
