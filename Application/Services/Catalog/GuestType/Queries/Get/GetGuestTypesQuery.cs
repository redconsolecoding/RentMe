using MediatR;

namespace Application.Services.Catalog.GuestType.Queries.Get
{
    using Domain.Common;
    using Domain.Entities.Catalogs;

    public class GetGuestTypesQuery : IRequest<Result<IEnumerable<GuestType>>> { }
}
