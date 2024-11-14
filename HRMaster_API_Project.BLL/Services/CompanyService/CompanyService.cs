using AutoMapper;
using HRMaster_API_Project.BLL.Services.CompanyService;
using HRMaster_API_Project.BLL.Services.Models.DTOs.CompanyDTO;
using HRMaster_API_Project.DAL.Repositories.Abstract;
using HRMaster_API_Project.DAL.Repositories.Concrete;
using HRMaster_API_Project.Entities.Concrete;
using HRMaster_API_Project.Entities.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CompanyService : ICompanyService
{
    private readonly ICompanyManager _companyManager;
    private readonly IMapper _mapper;
    private readonly UserManager<User> _userManager;

    public CompanyService(ICompanyManager companyManager, IMapper mapper, UserManager<User> userManager)
    {
        _companyManager = companyManager;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<IEnumerable<ShowCompanyDTO>> GetAllCompaniesAsync()
    {
        List<ShowCompanyDTO> showCompanyDTOs = new List<ShowCompanyDTO>();
        var companies = await _companyManager.GetAllAsync();

        _mapper.Map(companies, showCompanyDTOs);
        return showCompanyDTOs;
    }

    public async Task<CompanyDetailDTO> GetCompanyByIdAsync(int id)
    {

        var company = await _companyManager.GetByIdAsync(id);

        if (company == null)
        {
            return null;
        }
        else
        {

            var employeeCount = await _userManager.Users
                                 .Where(u => u.CEORelatedCompanyID == id && u.EmployeeRelatedCompanyID==id)
                                 .CountAsync();
            var companyDetailDTO = _mapper.Map<CompanyDetailDTO>(company);

            return companyDetailDTO;
        }
    }

    public async Task<int> AddCompanyAsync(AddNewCompanyDTO newCompanyDTO)
    {

        if (!await _companyManager.CompanyExists(newCompanyDTO.CompanyName))
        {

            var company = _mapper.Map<Company>(newCompanyDTO);
            var addedCompany = await _companyManager.AddAsync(company);
            return addedCompany.ID;

        }
        else return 0;
    }

    public async Task<bool> UpdateCompanyAsync(UpdateCompanyDTO updCompanyDTO, int companyId)
    {

        Company company = await _companyManager.GetByIdAsync(companyId);
        company.LogoPath = updCompanyDTO.LogoPath;
        company.CompanyPhoneNumber = updCompanyDTO.CompanyPhoneNumber;
        company.CompanyWebsite = updCompanyDTO.CompanyWebsite;
        company.CompanyAddress = updCompanyDTO.CompanyAddress;
        var result = await _companyManager.UpdateAsync(company);
        return result;

    }

    public Task DeleteCompanyAsync(int id)
    {
        throw new NotImplementedException();
    }


    public Task AddCEOToCompanyAsync(int companyId, int ceoId)
    {
        throw new NotImplementedException();
    }


    public async Task<bool> CheckCeoExists(int companyID)
    {
        var companyManager = await _companyManager.GetByIdAsync(companyID);
        return companyManager.CEOId != null;
    }


}

