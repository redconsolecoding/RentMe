using MediatR;

namespace Application.Services.Catalog.RoomType.Queries.GetById
{
    using Domain.Common;
    using Domain.Entities.Catalogs;

    public class GetRoomTypeByIdQuery : IRequest<Result<RoomType>>
    {
        public int Id { get; set; }
    }
}
