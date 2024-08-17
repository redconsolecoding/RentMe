using MediatR;

namespace Application.Services.Catalog.RoomType.Queries.Get
{
    using Domain.Entities.Catalogs;

    public class GetRoomTypesQuery : IRequest<IEnumerable<RoomType>> { }
}
