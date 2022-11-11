using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1CommonInfrastructure.Models;
using FluentValidation;

namespace _1CommonInfrastructure.Models
{
    public class UnitValidator : AbstractValidator<UnitModel>
    {
        public UnitValidator()
        {
            RuleFor(x => x.UnitName).NotEmpty().WithMessage("Unit Name is required");            
        }
    }
}
