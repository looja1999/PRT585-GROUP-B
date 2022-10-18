using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Major
    {
        public int MajorId { get; set; } // int
        public string MajorCode { get; set; } // nvarchar(400)
        public string MajorName { get; set; } // nvarchar(400)

    }
}
