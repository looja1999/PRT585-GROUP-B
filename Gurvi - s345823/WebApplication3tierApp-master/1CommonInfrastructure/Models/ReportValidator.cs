using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1CommonInfrastructure.Models
{
    public class ReportValidator : AbstractValidator<ReportModel>
    {
        public ReportValidator()
        {
            RuleFor(x => x.ReportName).NotEmpty().WithMessage("Report Name is required");
        }
    }
}
