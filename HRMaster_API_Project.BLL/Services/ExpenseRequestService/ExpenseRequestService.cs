using AutoMapper;
using HRMaster_API_Project.BLL.Services.Models;
using HRMaster_API_Project.BLL.Services.Models.DTOs.ExpenseRequestDTO;
using HRMaster_API_Project.DAL.Repositories.Abstract;
using HRMaster_API_Project.DAL.Repositories.Concrete;
using HRMaster_API_Project.Entities.Concrete;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.ExpenseRequestService
{
    public class ExpenseRequestService : IExpenseRequestService
    {
        IExpenseRequestManager _expenseRequestManager;
        IMapper _mapper;



        public ExpenseRequestService(IExpenseRequestManager expenseRequestManager, IMapper mapper)
        {
            _expenseRequestManager = expenseRequestManager;
            _mapper = mapper;
        }

        public async Task<ServiceResult> AddExpenseRequestAsync(AddExpenseRequestDTO newExpenseDTO)
        {
            var serviceResult = new ServiceResult();

            if (newExpenseDTO is not null)
            {
                var expense = _mapper.Map<ExpenseRequest>(newExpenseDTO);
                expense.ApprovalStatus = Entities.Enums.ApprovalStatus.Pending;
                expense.RequestDate = DateTime.Now;

                var result = await _expenseRequestManager.AddAsync(expense);

                if (result != null)
                {
                    serviceResult.Success = true;
                    serviceResult.Data = result; // Oluşturulan ExpenseRequest nesnesi
                }
                else
                {
                    serviceResult.Success = false;
                    serviceResult.Errors.Add("Talep oluşturulurken bir sorun yaşandı!");
                }
            }
            else
            {
                serviceResult.Success = false;
                serviceResult.Errors.Add("Talep oluşturulurken bir sorun yaşandı!");
            }

            return serviceResult;
        }


        public async Task<ServiceResult> GetAllExpenseRequestsForManagerAsync(int companyID)
        {
            var serviceResult = new ServiceResult();
            if (companyID != 0)
            {
                var expenses = await _expenseRequestManager.GetExpenseRequestsForManagerAsync(companyID);
                if(expenses != null) {
                    var expenseRequestDTOs = expenses.Select(e => new ShowExpenseRequestDTO
                    {
                        ID = e.ID,
                        Name = e.Employee.Name,
                        Surname = e.Employee.Surname,
                        RequestDate = e.RequestDate,
                        Amount = e.Amount,
                        Currency = e.Currency,
                        ApprovalStatus = e.ApprovalStatus, // Enum'dan string'e çevirme
                        ResponseDate = e.ResponseDate,
                        ExpenseType = e.ExpenseType
                    }).OrderByDescending(dto=>dto.ID).ToList();
                    serviceResult.Success = true;
                    serviceResult.Data= expenseRequestDTOs; 
                }
                else
                {
                    serviceResult.Success = false;
                    serviceResult.Errors.Add("Talepler listelenemedi!");
                }

            }
            else
            {
                serviceResult.Success = false;
                serviceResult.Errors.Add("Talepler listelenemedi!");
            }
            return serviceResult;   

        } 
        public async Task<ServiceResult> GetAllExpenseRequestsForEmployeeAsync(int employeeID)
        {
            var serviceResult = new ServiceResult();
            if (employeeID != 0)
            {
                var expenses = await _expenseRequestManager.GetExpenseRequestsForEmployeeAsync(employeeID);
                if(expenses != null) {
                    var expenseRequestDTOs = expenses.Select(e => new ShowExpenseRequestDTO
                    {
                        ID = e.ID,
                        Name = e.Employee.Name,
                        Surname = e.Employee.Surname,
                        RequestDate = e.RequestDate,
                        Amount = e.Amount,
                        Currency = e.Currency,
                        ApprovalStatus = e.ApprovalStatus, // Enum'dan string'e çevirme
                        ResponseDate = e.ResponseDate,
                        FilePath=e.FilePath,
                        ExpenseType= e.ExpenseType

                    }).OrderByDescending(dto => dto.ID).ToList();
                    serviceResult.Success = true;
                    serviceResult.Data= expenseRequestDTOs; 
                }
                else
                {
                    serviceResult.Success = false;
                    serviceResult.Errors.Add("Talepler listelenemedi!");
                }

            }
            else
            {
                serviceResult.Success = false;
                serviceResult.Errors.Add("Talepler listelenemedi!");
            }
            return serviceResult;   

        }

        public async Task<ServiceResult> ApproveExpenseRequestAsync(int id)
        {
            var serviceResult = new ServiceResult();
            if (id != 0) 
            {
                var result = await _expenseRequestManager.ApproveExpenseRequestAsync(id);
                if(result)
                {
                    serviceResult.Success = true;
                    serviceResult.Data = result;
                    return serviceResult;
                }
                else
                {
                    serviceResult.Success = false;
                    serviceResult.Errors.Add("Talep Onaylanamadı");
                    return serviceResult;
                }   
            }
            
                serviceResult.Success = false;
                serviceResult.Errors.Add("Talep Onaylanamadı");
            return serviceResult;
            


           
        }

        public async Task<ServiceResult> RejectExpenseRequestAsync(int id)
        {
            var serviceResult = new ServiceResult();
            if (id != 0)
            {
                var result = await _expenseRequestManager.RejectExpenseRequestAsync(id);
                if (result)
                {
                    serviceResult.Success = true;
                    serviceResult.Data = result;
                    return serviceResult;
                }
                else
                {
                    serviceResult.Success = false;
                    serviceResult.Errors.Add("Talep Reddedilemedi");
                    return serviceResult;
                }
            }
            
                serviceResult.Success = false;
                serviceResult.Errors.Add("Talep Reddedilemedi");
            return serviceResult;   
            
        }

        public async Task<ServiceResult> CancelExpenseRequestAsync(int id)
        {
            var serviceResult = new ServiceResult();
            if (id != 0)
            {
                var result = await _expenseRequestManager.CancelExpenseRequestAsync(id);
                if (result)
                {
                    serviceResult.Success = true;
                    serviceResult.Data = result;
                    return serviceResult;
                }
                else
                {
                    serviceResult.Success = false;
                    serviceResult.Errors.Add("Talep İptal Edilemedi");
                    return serviceResult;
                }
            }

            serviceResult.Success = false;
            serviceResult.Errors.Add("Talep İptal Edilemedi");
            return serviceResult;
        }

        public async Task<ServiceResult> GetFilePathAsync(int id)
        {
            var serviceResult = new ServiceResult();   
            if (id != 0)
            {
                var result = await _expenseRequestManager.GetByIdAsync(id);
                if (result != null)
                {
                    serviceResult.Success = true;
                    serviceResult.Data = result.FilePath    ;
                    return serviceResult;
                }
                else
                {
                    serviceResult.Success = false;
                    serviceResult.Errors.Add("Belge bulunamadı");
                    return serviceResult;
                }
            }
            serviceResult.Success = false;
            serviceResult.Errors.Add("Belge bulunamadı");
            return serviceResult;
        }
    }
}
