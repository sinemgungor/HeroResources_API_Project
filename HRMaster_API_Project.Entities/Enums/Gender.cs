﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.Entities.Enums
{
    public enum Gender
    {
        [Display(Name = "Kadın")]
        Female =1,
        [Display(Name = "Erkek")]
        Male =2,
        [Display(Name = "Diğer")]
        Other
    }
}
