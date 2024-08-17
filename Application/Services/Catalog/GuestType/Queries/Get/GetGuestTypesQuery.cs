using MediatR;

namespace Application.Services.Catalog.GuestType.Queries.Get
{
    using Domain.Entities.Catalogs;

    public class GetGuestTypesQuery : IRequest<IEnumerable<GuestType>> { }
}
