using MediatR;

namespace Application.Services.Catalog.RoomType.Command.Add
{
    using Domain.Common;
    using Domain.Entities.Catalogs;

    public class CreateRoomTypeRequest : IRequest<Result<RoomType>>
    {
        public required RoomType RoomType { get; set; }
    }
}
