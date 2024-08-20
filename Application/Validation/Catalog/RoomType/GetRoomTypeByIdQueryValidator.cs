using Application.Services.Catalog.RoomType.Queries.GetById;
using FluentValidation;

namespace Application.Validation.Catalog.RoomType
{
    public class GetRoomTypeByIdQueryValidator : AbstractValidator<GetRoomTypeByIdQuery>
    {
        public GetRoomTypeByIdQueryValidator()
        {
            RuleFor(e => e.Id).NotEmpty();
        }
    }
}
