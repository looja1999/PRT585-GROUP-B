using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class CourseModel
    {
        public int CourseId { get; set; } // int
        public string CourseCode { get; set; } // nvarchar(400)
        public string CourseName { get; set; } // nvarchar(400)

    }

}
