using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.ViewModels.System.Users
{
    public class RegisterRequestValidator: AbstractValidator<RegisterRequest>
    {
        public RegisterRequestValidator()
        {
            RuleFor(x => x.user_FirstName).NotEmpty().WithMessage("FirstName is required")
                .MaximumLength(200).WithMessage("FirstName can't not over 200 character");
            RuleFor(x => x.user_LastName).NotEmpty().WithMessage("Last Name is required")
                .MaximumLength(200).WithMessage("Last Name can't not over 200 character");
            RuleFor(x => x.user_DOB).GreaterThan(DateTime.Now.AddYears(-100)).WithMessage("Birthday can not greater than 100 years");
            RuleFor(x=> x.Email).NotEmpty().WithMessage("Email is required")
                .Matches(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")
                .WithMessage("Email format not match");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("UserName is required");
            RuleFor(x => x.Password).NotEmpty().WithMessage("PassWord is required")
                .MaximumLength(6).WithMessage("Password is at least 6 characters");

            RuleFor(x => x).Custom((request, context) =>
            {
                if (request.Password != request.ConfirmPassword)
                {
                    context.AddFailure("The list must contain 10 items or fewer");
                }
            });

        }
    }
}
