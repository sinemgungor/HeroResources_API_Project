using AutoMapper;
using HRMaster_API_Project.BLL.Services.Models;
using HRMaster_API_Project.BLL.Services.Models.DTOs.LeaveRequestDTO;
using HRMaster_API_Project.DAL.Repositories.Abstract;
using HRMaster_API_Project.DAL.Repositories.Concrete;
using HRMaster_API_Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.LeaveRequestService
{
    public class LeaveRequestServices : ILeaveRequestServices
    {
        private readonly ILeaveRequestManager _leaveRequestManager;
        private readonly IMapper _mapper;

        public LeaveRequestServices(ILeaveRequestManager leaveRequestManager, IMapper mapper)
        {
            _leaveRequestManager = leaveRequestManager;
            _mapper = mapper;
        }
        public async Task<ServiceResult> AddLeaveRequestAsync(AddLeaveRequestDTO newLeaveDTO)
        {
            var serviceResult = new ServiceResult();

            if (newLeaveDTO is not null)
            {
                var leaveRequest = _mapper.Map<LeaveRequest>(newLeaveDTO);
                leaveRequest.ApprovalStatus = Entities.Enums.ApprovalStatus.Pending;
                leaveRequest.RequestDate = DateTime.Now;

                var result = await _leaveRequestManager.AddAsync(leaveRequest);

                if (result != null)
                {
                    serviceResult.Success = true;
                    serviceResult.Data = result; // Oluşturulan LeaveRequest nesnesi
                }
                else
                {
                    serviceResult.Success = false;
                    serviceResult.Errors.Add("İzin talebi oluşturulurken bir sorun yaşandı!");
                }
            }
            else
            {
                serviceResult.Success = false;
                serviceResult.Errors.Add("İzin talebi oluşturulurken bir sorun yaşandı!");
            }

            return serviceResult;
        }



        public async Task<ServiceResult> GetAllLeaveRequestsForEmployeeAsync(int employeeID)
        {
            var serviceResult = new ServiceResult();
            if (employeeID != 0)
            {
                var leaves = await _leaveRequestManager.GetLeaveRequestsForEmployeeAsync(employeeID);
                if (leaves != null)
                {
                    var leaveRequestDTO = leaves.Select(e => new ShowLeaveRequestDTO
                    {
                        ID = e.ID,
                        Name = e.Employee.Name,
                        Surname = e.Employee.Surname,
                        LeaveStartingDate = e.LeaveStartingDate,
                        LeaveEndDate = e.LeaveEndDate,
                        ApprovalStatus = e.ApprovalStatus,
                        RequestDate = e.RequestDate,
                        LeaveType=e.LeaveType,
                        ResponseDate = e.ResponseDate,
                        LeaveDays = (e.LeaveEndDate.ToDateTime(TimeOnly.MinValue) - e.LeaveStartingDate.ToDateTime(TimeOnly.MinValue)).TotalDays + 1

                    }).OrderByDescending(dto => dto.ID).ToList();
                    serviceResult.Success = true;
                    serviceResult.Data = leaveRequestDTO;
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
    
    

    public async Task<ServiceResult> GetAllLeaveRequestsForManagerAsync(int companyID)
    {
        var serviceResult = new ServiceResult();
        if (companyID != 0)
        {
            var leaves = await _leaveRequestManager.GetLeaveRequestsForManagerAsync(companyID);
            if (leaves != null)
            {
                var leaveRequestDTO = leaves.Select(e => new ShowLeaveRequestDTO
                {
                    ID = e.ID,
                    Name = e.Employee.Name,
                    Surname = e.Employee.Surname,
                    LeaveStartingDate = e.LeaveStartingDate,
                    LeaveEndDate = e.LeaveEndDate,
                    ApprovalStatus = e.ApprovalStatus,
                    LeaveType=e.LeaveType,
                    RequestDate = e.RequestDate,
                    ResponseDate = e.ResponseDate,
                    LeaveDays = (e.LeaveEndDate.ToDateTime(TimeOnly.MinValue) - e.LeaveStartingDate.ToDateTime(TimeOnly.MinValue)).TotalDays + 1

                }).OrderByDescending(dto => dto.ID).ToList();
                serviceResult.Success = true;
                serviceResult.Data = leaveRequestDTO;
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

        public async Task<ServiceResult> ApproveLeaveRequestAsync(int id)
        {
            var serviceResult = new ServiceResult();
            if (id != 0)
            {
                var result = await _leaveRequestManager.ApproveLeaveRequestAsync(id);
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

        public async Task<ServiceResult> RejectLeaveRequestAsync(int id)
        {
            var serviceResult = new ServiceResult();
            if (id != 0)
            {
                var result = await _leaveRequestManager.RejectLeaveRequestAsync(id);
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

        public async Task<ServiceResult> CancelLeaveRequestAsync(int id)
        {
            var serviceResult = new ServiceResult();
            if (id != 0)
            {
                var result = await _leaveRequestManager.CancelLeaveRequestAsync(id);
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
