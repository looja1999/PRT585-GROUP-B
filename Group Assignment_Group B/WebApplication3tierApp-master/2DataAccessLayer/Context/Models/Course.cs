using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2DataAccessLayer.Context.Models
{
    public class Course
    {
        public int CourseId { get; set; } // int
        public string CourseCode { get; set; } // nvarchar(400)
        public string CourseName { get; set; } // nvarchar(400)
       
    }
}
