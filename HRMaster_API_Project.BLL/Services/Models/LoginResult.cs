using HRMaster_API_Project.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMaster_API_Project.BLL.Services.Models
{
    public class LoginResult
    {
        public User? User { get; set; }
        public IList<string>? Roles { get; set; }
    }
}
