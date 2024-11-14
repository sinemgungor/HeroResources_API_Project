using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.Entities.Enums
{
    public enum MarialStatus
    {
        [Display(Name = "Bekar")]
        Single=1,
        [Display(Name = "Evli")]
        Married
    }
}
