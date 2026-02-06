using eCommerce.Core.DTO;
using FluentValidation;

namespace eCommerce.Core.Validators;

public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator()
    {
        RuleFor(temp => temp.Email).NotEmpty().WithMessage("Email can't be empty")
            .EmailAddress().WithMessage("Email should be in valid email address format");

        RuleFor(temp => temp.Password).NotEmpty().WithMessage("Password not be empty")
            .MinimumLength(5).MaximumLength(8).WithMessage("Password should be 5-8 letters");

        RuleFor(temp => temp.PersonName).NotEmpty().WithMessage("Person name can't be empty")
            .Length(1, 50).WithMessage("Name should be between 1 and 50 characters long");

        RuleFor(temp => temp.Gender).IsInEnum().WithMessage("Gender required");
    }
}
