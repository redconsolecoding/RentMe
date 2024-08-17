using MediatR;

namespace Application.Services.Catalog.RoomType.Command.Update
{
    using Domain.Entities.Catalogs;

    public class UpdateRoomTypeRequest : IRequest<Unit>
    {
        public required RoomType RoomType { get; set; }
    }
}
