using HRMaster_API_Project.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.Entities.Concrete
{
    public class Department:BaseEntity
    {
        public string DepartmentName { get; set; }

        public int CompanyID { get; set; }
        public Company? Company { get; set; }


        public ICollection<User>? Employees { get; set; }
    }
}
