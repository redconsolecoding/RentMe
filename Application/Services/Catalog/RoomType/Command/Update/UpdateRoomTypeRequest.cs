using MediatR;

namespace Application.Services.Catalog.RoomType.Command.Update
{
    using Domain.Common;
    using Domain.Entities.Catalogs;

    public class UpdateRoomTypeRequest : IRequest<Result>
    {
        public required RoomType RoomType { get; set; }
    }
}
