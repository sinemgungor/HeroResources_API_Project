using HRMaster_API_Project.BLL.Services.Models.DTOs.ManagerDTO;
using HRMaster_API_Project.BLL.Services.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMaster_API_Project.BLL.Services.Models.DTOs.EmployeeDTO;
using HRMaster_API_Project.Entities.Concrete;
using HRMaster_API_Project.BLL.Services.Models.DTOs.AdminDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.DepartmentDTO;
using HRMaster_API_Project.BLL.Services.Models.DTOs.CompanyDTO;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace HRMaster_API_Project.BLL.Services.EmployeeService
{
    public class EmployeeServices: IEmployeeServices
    {
        private readonly UserManager<User> _userManager;
        private readonly IMapper _mapper;

        public EmployeeServices(UserManager<User> userManager, IMapper mapper)
        {
            _userManager = userManager;
            _mapper = mapper;
        }

        public async Task<ServiceResult> UpdateEmployeeAsync(int id, UpdateEmployeeDTO updateDto)
        {
            var userId = id.ToString();

            var employee = await _userManager.FindByIdAsync(userId);
            if (employee == null)
            {
                return new ServiceResult { Success = false, Message = "Personel bulunamadı." };
            }

            if (updateDto.PicturePath != null)
            {
                employee.PicturePath = updateDto.PicturePath;
            }
            if (updateDto.Address != null)
            {
                employee.Address = updateDto.Address;
            }
            if (updateDto.Phone != null)
            {
                employee.PhoneNumber = updateDto.Phone;
            }

            var result = await _userManager.UpdateAsync(employee);
            if (!result.Succeeded)
            {
                return new ServiceResult { Success = false, Message = "Güncelleme başarısız oldu.", Errors = result.Errors.Select(e => e.Description).ToList() };
            }

            return new ServiceResult { Success = true, Message = "Details updated successfully." };
        }

        public async Task<EmployeeSummaryDTO> GetEmployeeSummaryAsync(int employeeId)
        {
            var user = await _userManager.Users
             .Include(u => u.EmployeeRelatedCompany)
             .Include(u => u.Department)
             .FirstOrDefaultAsync(u => u.Id == employeeId);

            if (user == null)
            {
                return null;
            }

            var departmentDTO = user.Department != null
         ? new Department_DTO
         {
             ID = user.Department.ID,
             DepartmentName = user.Department.DepartmentName
         }
         : null;

            var employeeSummary = new EmployeeSummaryDTO
            {
                Id = user.Id,
                PicturePath = user.PicturePath,
                Name = user.Name,
                Surname = user.Surname,
                Job = user.Job,
                Email = user.Email,
                Address = user.Address,
                PhoneNumber = user.PhoneNumber,
                Department=departmentDTO
            };

            return employeeSummary;
        }

        public async Task<EmployeeDTO> GetEmployeeDetailAsync(int employeeId)
        {
            var user = await _userManager.Users
            .Include(u => u.EmployeeRelatedCompany)
            .Include(u => u.Department)
            .FirstOrDefaultAsync(u => u.Id == employeeId);

            if (user == null)
            {
                return null; 
            }

            var employeeDetail = _mapper.Map<EmployeeDTO>(user);
            return employeeDetail;
        }

        public async Task<bool> IsEmployeeExistAsync(string username)
        {
            var user = await _userManager.FindByEmailAsync(username);
            if (user == null) 
            {
                return false;
            }
            else
                return true;
        }
    }
}
