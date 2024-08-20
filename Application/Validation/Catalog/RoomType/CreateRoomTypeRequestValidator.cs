using Application.Services.Catalog.GuestType.Command.Add;
using Application.Services.Catalog.RoomType.Command.Add;
using FluentValidation;

namespace Application.Validation.Catalog.RoomType
{
    public class CreateRoomTypeRequestValidator : AbstractValidator<CreateRoomTypeRequest>
    {
        public CreateRoomTypeRequestValidator()
        {
            RuleFor(e => e.RoomType.Name)
                .NotEmpty()
                .WithMessage("Name is required.")
                .MaximumLength(200)
                .WithMessage("Maximum length is 200 characters.");

            RuleFor(e => e.RoomType.Code)
                .MaximumLength(20)
                .WithMessage("Maximum length is 20 characters.");
        }
    }
}
