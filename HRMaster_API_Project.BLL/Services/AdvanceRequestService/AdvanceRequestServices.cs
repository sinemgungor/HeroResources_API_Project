using AutoMapper;
using HRMaster_API_Project.BLL.Services.Models;
using HRMaster_API_Project.BLL.Services.Models.DTOs.AdvanceRequestDTO;
using HRMaster_API_Project.DAL.Repositories.Abstract;
using HRMaster_API_Project.DAL.Repositories.Concrete;
using HRMaster_API_Project.Entities.Concrete;
using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.AdvanceRequestService
{
    public class AdvanceRequestServices : IAdvanceRequestServices
    {
        private readonly IAdvanceRequestManager _advanceRequestManager;
        private readonly IMapper _mapper;

        public AdvanceRequestServices(IAdvanceRequestManager advanceRequestManager, IMapper mapper)
        {
            _advanceRequestManager = advanceRequestManager;
            _mapper = mapper;
        }
        public async Task<ServiceResult> AddAdvanceRequestAsync(AddAdvanceRequestDTO newAdvanceDTO)
        {
            var serviceResult = new ServiceResult();

            if (newAdvanceDTO is not null)
            {
                var advanceRequest = _mapper.Map<AdvanceRequest>(newAdvanceDTO);
                advanceRequest.ApprovalStatus = ApprovalStatus.Pending;
                advanceRequest.RequestDate = DateTime.Now;

                var result = await _advanceRequestManager.AddAsync(advanceRequest);

                if (result != null)
                {
                    serviceResult.Success = true;
                    serviceResult.Data = result; // Oluşturulan AdvanceRequest nesnesi
                }
                else
                {
                    serviceResult.Success = false;
                    serviceResult.Errors.Add("Avans talebi oluşturulurken bir sorun yaşandı!");
                }
            }
            else
            {
                serviceResult.Success = false;
                serviceResult.Errors.Add("Geçersiz avans talebi verisi!");
            }

            return serviceResult;
        }



        public async Task<ServiceResult> GetAllAdvanceRequestsForManagerAsync(int companyID)
        {
            var serviceResult = new ServiceResult();
            if (companyID != 0)
            {
                var advances = await _advanceRequestManager.GetAdvanceRequestsForManagerAsync(companyID);
                if (advances != null)
                {
                    var advanceRequestDTO = advances.Select(e => new ShowAdvanceRequestDTO
                    {
                        ID = e.ID,
                        Name = e.Employee.Name,
                        Surname = e.Employee.Surname,
                        RequestDate = e.RequestDate,
                        ApprovalStatus = e.ApprovalStatus,
                        AdvanceType=e.AdvanceType,
                        ResponseDate = e.ResponseDate,
                        Amount = e.Amount,
                        Currency = e.Currency,
                        Description = e.Description
                    }).OrderByDescending(dto => dto.ID).ToList();
                    serviceResult.Success = true;
                    serviceResult.Data = advanceRequestDTO;
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
                var advances = await _advanceRequestManager.GetAdvanceRequestsForEmployeeAsync(employeeID);
                if (advances != null)
                {
                    var advanceRequestDTO = advances.Select(e => new ShowAdvanceRequestDTO
                    {
                        ID = e.ID,
                        Name = e.Employee.Name,
                        Surname = e.Employee.Surname,
                        RequestDate = e.RequestDate,
                        ApprovalStatus = e.ApprovalStatus,
                        ResponseDate = e.ResponseDate,
                        AdvanceType = e.AdvanceType,
                        Amount = e.Amount,
                        Currency = e.Currency,
                        Description = e.Description
                    }).OrderByDescending(dto => dto.ID).ToList();
                    serviceResult.Success = true;
                    serviceResult.Data = advanceRequestDTO;
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
        public async Task<ServiceResult> ApproveAdvanceRequestAsync(int id)
        {
            var serviceResult = new ServiceResult();
            if (id != 0)
            {
                var result = await _advanceRequestManager.ApproveAdvanceRequestAsync(id);
                if (result)
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

        public async Task<ServiceResult> RejectAdvanceRequestAsync(int id)
        {
            var serviceResult = new ServiceResult();
            if (id != 0)
            {
                var result = await _advanceRequestManager.RejectAdvanceRequestAsync(id);
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

        public async Task<ServiceResult> CancelAdvanceRequestAsync(int id)
        {
            var serviceResult = new ServiceResult();
            if (id != 0)
            {
                var result = await _advanceRequestManager.CancelAdvanceRequestAsync(id);
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
    }
}
