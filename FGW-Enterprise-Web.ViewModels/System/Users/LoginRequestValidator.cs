using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.System.Users
{
    public class LoginRequestValidator: AbstractValidator<LoginRequest>
    {
        public LoginRequestValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("User name is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Password is required")
                .MinimumLength(6).WithMessage("Password is at less 6 characters");

        }

    }
}
