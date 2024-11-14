using HRMaster_API_Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.DAL.Repositories.Abstract
{
    public interface IDepartmentManager:IRepository<Department> 
    {
        Task<IEnumerable<Department>>GetDepartmentByNameAsync(string name,int companyID);
        Task<bool> DepartmentExists(string name, int companyID);
        Task<IEnumerable<Department>> GetAllCompanyDepartment(int companyID);

        Task<IEnumerable<User>> GetDepartmentEmployeesAsync(int departmentID);  
    }
}
