using Application.Services.Catalog.GuestType.Command.Delete;
using FluentValidation;

namespace Application.Validation.Catalog.GuestType
{
    public class DeleteGuestTypeRequestValidator : AbstractValidator<DeleteGuestTypeRequest>
    {
        public DeleteGuestTypeRequestValidator()
        {
            RuleFor(e => e.GuestType.Name)
                .NotEmpty()
                .WithMessage("Name is required.")
                .MaximumLength(200)
                .WithMessage("Maximum length is 200 characters.");

            RuleFor(e => e.GuestType.Code)
                .MaximumLength(20)
                .WithMessage("Maximum length is 20 characters.");
        }
    }
}
