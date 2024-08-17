using Application.Services.Catalog.RoomType.Command.Update;
using FluentValidation;

namespace Application.Validation.Catalog.RoomType
{
    public class UpdateRoomTypeRequestValidator : AbstractValidator<UpdateRoomTypeRequest>
    {
        public UpdateRoomTypeRequestValidator()
        {
            RuleFor(p => p.RoomType).NotEmpty();
        }
    }
}
