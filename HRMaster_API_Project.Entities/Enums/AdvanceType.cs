using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.Entities.Enums
{
   
        public enum AdvanceType
    {
        [Display(Name = "Maaş Avansı")]
        SalaryAdvance,

        [Display(Name = "Seyahat Avansı")]
        TravelAdvance,

        [Display(Name = "Eğitim Avansı")]
        EducationAdvance,

        [Display(Name = "Proje Avansı")]
        ProjectAdvance,

        [Display(Name = "Acil Durum Avansı")]
        EmergencyAdvance
    }
}

