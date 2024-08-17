using Application.Services.Catalog.GuestType.Command.Delete;
using FluentValidation;

namespace Application.Validation.Catalog.GuestType
{
    public class DeleteGuestTypeRequestValidator : AbstractValidator<DeleteGuestTypeRequest>
    {
        public DeleteGuestTypeRequestValidator()
        {
            RuleFor(p => p.GuestType).NotEmpty();
        }
    }
}
