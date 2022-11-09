using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class RoleModel
    {
        public int RoleId { get; set; } // int
        public string RoleName { get; set; } // nvarchar(400)
        public string RoleStatus { get; set; } // boolean

    }

}
