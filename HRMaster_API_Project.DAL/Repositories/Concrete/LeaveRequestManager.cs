using HRMaster_API_Project.DAL.Context;
using HRMaster_API_Project.DAL.Repositories.Abstract;
using HRMaster_API_Project.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.DAL.Repositories.Concrete
{
    public class LeaveRequestManager : Repository<LeaveRequest>, ILeaveRequestManager
    {
        private readonly AppDbContext _dbContext;
        public LeaveRequestManager(AppDbContext context) : base(context)
        {
            _dbContext = context;
        }



        public async Task<List<LeaveRequest>> GetLeaveRequestsForEmployeeAsync(int employeeID)
        {
            var leaves=await _dbContext.LeaveRequests.Include(x=>x.Employee).Where(x=>x.Employee.Id== employeeID).ToListAsync();
            return leaves;
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsForManagerAsync(int companyID)
        {
            var leaves= await _dbContext.LeaveRequests.Include(x=>x.Employee).Where(x=>x.Employee.EmployeeRelatedCompanyID==companyID).ToListAsync();
            return leaves;
        }
        public async Task<bool> ApproveLeaveRequestAsync(int id)
        {
            var request = await _dbContext.LeaveRequests.FindAsync(id);

            request.ApprovalStatus = Entities.Enums.ApprovalStatus.Approved;
            request.ResponseDate = DateTime.Now;
            return await UpdateAsync(request);
        }

        public async Task<bool> CancelLeaveRequestAsync(int id)
        {
            var request = await _dbContext.LeaveRequests.FindAsync(id);

            request.ApprovalStatus = Entities.Enums.ApprovalStatus.Cancelled;
            request.ResponseDate = DateTime.Now;
            return await UpdateAsync(request);
        }
        public async Task<bool> RejectLeaveRequestAsync(int id)
        {
            var request = await _dbContext.LeaveRequests.FindAsync(id);

            request.ApprovalStatus = Entities.Enums.ApprovalStatus.Rejected;
            request.ResponseDate = DateTime.Now;
            return await UpdateAsync(request);
        }
    }
}
