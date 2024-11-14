using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.Entities.Enums
{
    public enum ApprovalStatus
    {
        [Display(Name = "Onay Bekleyen")]
        Pending,

        [Display(Name = "Onaylandı")]
        Approved,

        [Display(Name = "Reddedildi")]
        Rejected,

        [Display(Name = "İptal Edildi")]
        Cancelled
    }
}
