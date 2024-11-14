using HRMaster_API_Project.BLL.Services.Models.DTOs.CompanyDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.CompanyService
{
    public interface ICompanyService
    {
        Task<IEnumerable<ShowCompanyDTO>> GetAllCompaniesAsync();
        Task<int> AddCompanyAsync(AddNewCompanyDTO companyDTO);
        Task DeleteCompanyAsync(int id);
        Task<bool> UpdateCompanyAsync(UpdateCompanyDTO updCompanyDTO,int companyId);
        Task<CompanyDetailDTO> GetCompanyByIdAsync(int id); 
        Task AddCEOToCompanyAsync(int companyId,int ceoId);

        Task<bool> CheckCeoExists(int companyID);
    }
}
