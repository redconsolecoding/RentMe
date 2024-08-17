using MediatR;

namespace Application.Services.Catalog.RoomType.Command.Add
{
    using Domain.Entities.Catalogs;

    public class CreateRoomTypeRequest : IRequest<RoomType>
    {
        public RoomType RoomType { get; set; }
    }
}
