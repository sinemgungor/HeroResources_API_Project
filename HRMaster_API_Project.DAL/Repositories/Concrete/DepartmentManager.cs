using HRMaster_API_Project.DAL.Context;
using HRMaster_API_Project.DAL.Repositories.Abstract;
using HRMaster_API_Project.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.DAL.Repositories.Concrete
{
    public class DepartmentManager : Repository<Department>,IDepartmentManager
    {
        private readonly AppDbContext _dbContext;
        private readonly UserManager<User> _userManager;
        public DepartmentManager(AppDbContext context, UserManager<User> userManager) : base(context)
        {
            _dbContext = context;
            _userManager = userManager;
        }
    

      

        public async Task<IEnumerable<Department>> GetDepartmentByNameAsync(string name, int companyID)
        {
            var departments = await _dbContext.Departments.Where(d => d.ID == companyID && d.DepartmentName==name).ToListAsync();
            return departments;    
        }

        public async Task<bool> DepartmentExists(string name, int companyID)
        {
            var result = await _dbContext.Departments.Where(x=>x.CompanyID==companyID).AnyAsync(x => x.DepartmentName == name);
            return result;
        }

        public async Task<IEnumerable<Department>> GetAllCompanyDepartment(int companyID)
        {
           var result = await _dbContext.Departments.Where(x => x.CompanyID == companyID).ToListAsync();
            return result;
        }

        public async Task<IEnumerable<User>> GetDepartmentEmployeesAsync(int departmentID)
        {
            var departmentEmployees = await _dbContext.Users
                .Where(user => user.DepartmentID == departmentID)
                .ToListAsync();

            var employeeRoleUsers = new List<User>();

            foreach (var user in departmentEmployees)
            {
                var roles = await _userManager.GetRolesAsync(user);
                if (roles.Contains("Employee"))
                {
                    employeeRoleUsers.Add(user);
                }
            }

            return employeeRoleUsers;
        }
    }
}
