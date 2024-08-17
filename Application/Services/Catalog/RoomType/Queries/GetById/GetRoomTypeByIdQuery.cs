using MediatR;

namespace Application.Services.Catalog.RoomType.Queries.GetById
{
    using Domain.Entities.Catalogs;

    public class GetRoomTypeByIdQuery : IRequest<RoomType>
    {
        public int Id { get; set; }
    }
}
