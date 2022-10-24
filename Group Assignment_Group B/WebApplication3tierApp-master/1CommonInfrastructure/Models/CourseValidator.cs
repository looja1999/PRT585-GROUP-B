using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace _1CommonInfrastructure.Models
{    
    public class CourseValidator : AbstractValidator<CourseModel>
    {
        public CourseValidator()
        {
            RuleFor(x => x.CourseName).NotEmpty().WithMessage("Course Name is required");
            RuleFor(x => x.CourseCode).NotEmpty().WithMessage("Course Code is required");
        }
    }
}
