using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.System.Users
{
    public class RegisterRoleRequestValidator : AbstractValidator<RegisterRoleRequest>
    {
        public RegisterRoleRequestValidator()
        {
            RuleFor(x => x.RoleName).NotEmpty().WithMessage("Role Name is required")
                .MaximumLength(200).WithMessage("FirstName can't not over 200 character");
            RuleFor(x => x.RoleDescrpition).NotEmpty().WithMessage("Role Descrpition is required")
                    .MaximumLength(200).WithMessage("Last Name can't not over 200 character");
        }
    }
}
