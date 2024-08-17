using MediatR;

namespace Application.Services.Catalog.RoomType.Command.Delete
{
    using Domain.Entities.Catalogs;

    public class DeleteRoomTypeRequest : IRequest<Unit>
    {
        public RoomType RoomType { get; set; }
    }
}
