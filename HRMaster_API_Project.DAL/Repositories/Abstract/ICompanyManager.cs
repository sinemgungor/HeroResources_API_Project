using HRMaster_API_Project.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.DAL.Repositories.Abstract
{
    public interface ICompanyManager:IRepository<Company>
    {
        Task<bool> CompanyExists(string name);
        Task<Company> GetByIdAsync(int id);

        Task<bool> AddCeoToCompany(int companyID, string userName);
    }
}
