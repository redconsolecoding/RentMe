using MediatR;

namespace Application.Services.Catalog.RoomType.Command.Delete
{
    using Domain.Common;
    using Domain.Entities.Catalogs;

    public class DeleteRoomTypeRequest : IRequest<Result>
    {
        public required RoomType RoomType { get; set; }
    }
}
