using Application.Services.Catalog.RoomType.Command.Delete;
using FluentValidation;

namespace Application.Validation.Catalog.RoomType
{
    public class DeleteRoomTypeRequestValidator : AbstractValidator<DeleteRoomTypeRequest>
    {
        public DeleteRoomTypeRequestValidator()
        {
            RuleFor(p => p.RoomType).NotEmpty();
        }
    }
}
