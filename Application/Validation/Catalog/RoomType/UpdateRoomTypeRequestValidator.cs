using Application.Services.Catalog.RoomType.Command.Update;
using FluentValidation;

namespace Application.Validation.Catalog.RoomType
{
    public class UpdateRoomTypeRequestValidator : AbstractValidator<UpdateRoomTypeRequest>
    {
        public UpdateRoomTypeRequestValidator()
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
