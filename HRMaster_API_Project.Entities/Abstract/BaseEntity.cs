using HRMaster_API_Project.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.Entities.Abstract
{
     public class BaseEntity
    {

        public int ID { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public Status Status { get; set; }
    }
}
