using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.Entities.Enums
{
    public enum CompanyType
    {
        [Display(Name = "Limited Şirket")]
        LimitedCompany=1,

        [Display(Name = "Anonim Şirket")]
        JointStockCompany,

        [Display(Name = "Şahıs Şirketi")]
        SoleProprietorship,

        [Display(Name = "Diğer")]
        Other
    }
}
