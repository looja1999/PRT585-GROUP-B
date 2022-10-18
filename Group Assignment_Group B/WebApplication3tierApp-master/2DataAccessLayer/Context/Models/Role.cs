using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Role
    {
      public int RoleId { get; set; } // int
      public string RoleName { get; set; } // nvarchar(400)
      public string? RoleStatus { get; set; } // boolean

    }
}
