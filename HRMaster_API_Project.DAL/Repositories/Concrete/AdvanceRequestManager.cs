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
    public class AdvanceRequestManager : Repository<AdvanceRequest>, IAdvanceRequestManager
    {
        private readonly AppDbContext _dbContext;
        public AdvanceRequestManager(AppDbContext context) : base(context)
        {
            _dbContext = context;
        }



        public async Task<List<AdvanceRequest>> GetAdvanceRequestsForEmployeeAsync(int employeeID)
        {
            var advances = await _dbContext.AdvanceRequests.Include(x => x.Employee).Where(x => x.Employee.Id==employeeID).ToListAsync();
            return advances;
        }

        public async Task<List<AdvanceRequest>> GetAdvanceRequestsForManagerAsync(int companyID)
        {
            var advances= await _dbContext.AdvanceRequests.Include(x=>x.Employee).Where(x=>x.Employee.EmployeeRelatedCompanyID==companyID).ToListAsync();
            return advances;
        }
        public async Task<bool> ApproveAdvanceRequestAsync(int id)
        {
            var request = await _dbContext.AdvanceRequests.FindAsync(id);

            request.ApprovalStatus = Entities.Enums.ApprovalStatus.Approved;
            request.ResponseDate = DateTime.Now;
            return await UpdateAsync(request);
        }
        public async Task<bool> RejectAdvanceRequestAsync(int id)
        {
            var request = await _dbContext.AdvanceRequests.FindAsync(id);

            request.ApprovalStatus = Entities.Enums.ApprovalStatus.Rejected;
            request.ResponseDate = DateTime.Now;
            return await UpdateAsync(request);
        }

        public async Task<bool> CancelAdvanceRequestAsync(int id)
        {
            var request = await _dbContext.AdvanceRequests.FindAsync(id);

            request.ApprovalStatus = Entities.Enums.ApprovalStatus.Cancelled;
            request.ResponseDate = DateTime.Now;
            return await UpdateAsync(request);
        }
    }
}
