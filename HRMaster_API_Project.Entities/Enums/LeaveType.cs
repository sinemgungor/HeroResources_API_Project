using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.Entities.Enums
{
    public enum LeaveType
    {
        [Display(Name = "Yıllık İzin")]
        AnnualLeave,

        [Display(Name = "Hastalık İzni")]
        SickLeave,

        [Display(Name = "Ücretsiz İzin")]
        UnpaidLeave,

        [Display(Name = "Doğum İzni")]
        MaternityLeave,

        [Display(Name = "Babalık İzni")]
        PaternityLeave,

        [Display(Name = "Evlilik İzni")]
        MarriageLeave,

        [Display(Name = "Vefat İzni")]
        BereavementLeave,

        [Display(Name = "Yol İzni")]
        TravelLeave
    }
}
