using Application.Services.Catalog.GuestType.Command.Add;
using Application.Services.Catalog.RoomType.Command.Add;
using FluentValidation;

namespace Application.Validation.Catalog.RoomType
{
    public class CreateRoomTypeRequestValidator : AbstractValidator<CreateRoomTypeRequest>
    {
        public CreateRoomTypeRequestValidator()
        {
            RuleFor(x => x.RoomType.Name).NotEmpty().WithMessage("Name is required.");
        }
    }
}
