using MediatR;

namespace Application.Services.Catalog.RoomType.Queries.Get
{
    using Domain.Common;
    using Domain.Entities.Catalogs;

    public class GetRoomTypesQuery : IRequest<Result<IEnumerable<RoomType>>> { }
}
