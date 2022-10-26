using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace _1CommonInfrastructure.Models
{    
    public class RoleValidator : AbstractValidator<RoleModel>
    {
        public RoleValidator()
        {
            RuleFor(x => x.RoleName).NotEmpty().WithMessage("Role Name is required");
           // RuleFor(x => x.RoleStatus).NotEmpty().WithMessage("Role Status is required");
        }
    }
}
