using Application.Services.Catalog.GuestType.Command.Update;
using FluentValidation;

namespace Application.Validation.Catalog.GuestType
{
    public class UpdateGuestTypeRequestValidator : AbstractValidator<UpdateGuestTypeRequest>
    {
        public UpdateGuestTypeRequestValidator()
        {
            RuleFor(p => p.GuestType).NotEmpty();
        }
    }
}
