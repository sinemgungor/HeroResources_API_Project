using HRMaster_API_Project.DAL.Context;
using HRMaster_API_Project.DAL.Repositories.Abstract;
using HRMaster_API_Project.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HRMaster_API_Project.DAL.Repositories.Concrete
{
    public class CompanyManager : Repository<Company>,ICompanyManager
    {
        private readonly UserManager<User> _userManager;
        public CompanyManager(AppDbContext context, UserManager<User> userManager) : base(context)
        {
            _dbContext = context;
            _userManager = userManager; 
        }

        private readonly AppDbContext _dbContext;

        public async Task<bool> CompanyExists(string name)
        {
            var result= await _dbContext.Companies.AnyAsync(c => c.CompanyName == name);
            return result;
        }

        public async Task<Company> GetByIdAsync(int id)
        {
            return await _dbContext.Companies
                .Include(c => c.Employees)
                .SingleOrDefaultAsync(c => c.ID == id);
        }

        public async Task<bool> AddCeoToCompany(int companyID, string userName)
        {
            var company = await GetByIdAsync(companyID);
            int addedUserID = await GetUserIdByUsernameAsync(userName);
            company.CEOId = addedUserID;
            return await UpdateAsync(company);
        }

        public async Task<int> GetUserIdByUsernameAsync(string username)
        {
            var user = await _userManager.FindByNameAsync(username);
            return user.Id;
        }
    }
}
