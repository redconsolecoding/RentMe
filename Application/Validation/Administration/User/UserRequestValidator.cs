using Application.DTOs;
using FluentValidation;

namespace Application.Validation.Administration.User
{
    public class UserRequestValidator : AbstractValidator<UserRequestDto>
    {
        public UserRequestValidator()
        {
            RuleFor(x => x.Email)
                .EmailAddress()
                .WithMessage("You must provide valid email adress.");
            RuleFor(x => x.Password).MinimumLength(6).NotEmpty();
        }
    }
}
