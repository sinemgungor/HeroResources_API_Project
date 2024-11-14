using AutoMapper;
using HRMaster_API_Project.BLL.Services.Models.DTOs.DepartmentDTO;
using HRMaster_API_Project.BLL.Services.Models.EmployeeDTO;
using HRMaster_API_Project.DAL.Repositories.Abstract;
using HRMaster_API_Project.DAL.Repositories.Concrete;
using HRMaster_API_Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.DepartmentService
{
    public class DepartmantService : IDepartmentService
    {
        private readonly IDepartmentManager _departmentManager;
        private readonly IMapper _mapper;

        public DepartmantService(IDepartmentManager departmentManager, IMapper mapper)
        {
            _departmentManager = departmentManager;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Department_DTO>> GetAllCompanyDepartmentAsync(int companyID)
        {
            List<Department_DTO> department_DTOs = new List<Department_DTO>();
            var departments = await _departmentManager.GetAllCompanyDepartment(companyID);
            _mapper.Map(departments, department_DTOs);
            return department_DTOs;
        }

        public async Task<Department_DTO?> GetDepartmentByIdAsync(int id)
        {
            var department = await _departmentManager.GetByIdAsync(id);
            Department_DTO dep_DTO= new Department_DTO();   
            dep_DTO.ID= department.ID;
            dep_DTO.DepartmentName= department.DepartmentName;  
            if (department == null)
            {
                return null;
            }
            return dep_DTO;
        }
        //public async Task<int> AddDepartmentAsync(AddNewDepartmentDTO newDepartmentDTO, int companyID)
        //{
        //    //if (_departmentManager.DepartmentExists(newDepartmentDTO.DepartmentName))
        //    //{
        //    //    throw new Exception("A department with the same name already exists");
        //    //}

        //    Department department = new Department();
        //    department.CompanyID = companyID;
        //    department.DepartmentName = newDepartmentDTO.DepartmentName;

        //    var result = await _departmentManager.AddAsync(department);
        //    if (result != null)
        //    {
        //        return result.ID;
        //    }
        //    else { return 0; }

        //}

        public async Task<int> AddDepartmentAsync(AddNewDepartmentDTO newDepartmentDTO, int companyID)
        {
            // Aynı şirket için aynı isimde bir departman olup olmadığını kontrol et
            bool exists = await _departmentManager.DepartmentExists(newDepartmentDTO.DepartmentName, companyID);

            if (exists)
            {
                // Eğer aynı isimde bir departman varsa, eklemeyi durdurun ve -1 döndürün
                return -1;
            }

            // Eğer yoksa yeni departmanı ekle
            Department department = new Department
            {
                CompanyID = companyID,
                DepartmentName = newDepartmentDTO.DepartmentName
            };

            var result = await _departmentManager.AddAsync(department);

            return result?.ID ?? 0; // Departman başarıyla eklendiyse ID'sini döndür, aksi halde 0
        }

        public async Task UpdateDepartment(UpdateDepartmentDTO updateDepartmentDTO)
        {
            //Department department = await _departmentManager.GetDepartmentByNameAsync(updateDepartmentDTO.DepartmentName);
        }

        public async Task<IEnumerable<EmployeeSummary_DTO>> GetDepartmentEmployeesAsync(int departmentID)
        {
            List<EmployeeSummary_DTO> showEmployee_DTOs = new List<EmployeeSummary_DTO>();
            var employees = await _departmentManager.GetDepartmentEmployeesAsync(departmentID);
            _mapper.Map(employees, showEmployee_DTOs);
            return showEmployee_DTOs;
        }
    }
}
