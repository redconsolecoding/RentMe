using Application.Services.Catalog.GuestType.Command.Add;
using FluentValidation;

namespace Application.Validation.Catalog
{
    public class CreateGuestTypeRequestValidator : AbstractValidator<CreateGuestTypeRequest>
    {
        public CreateGuestTypeRequestValidator()
        {
            RuleFor(x => x.GuestType.Name).NotEmpty().WithMessage("Name is required.");
        }
    }
}
