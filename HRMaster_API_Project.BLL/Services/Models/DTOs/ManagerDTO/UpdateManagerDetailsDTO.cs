using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models.DTOs.ManagerDTO
{
    public class UpdateManagerDetailsDTO
    {
        public string? PicturePath { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
    }
}
