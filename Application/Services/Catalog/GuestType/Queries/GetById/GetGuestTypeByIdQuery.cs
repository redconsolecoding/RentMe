using MediatR;

namespace Application.Services.Catalog.GuestType.Queries.GetById
{
    using Domain.Common;
    using Domain.Entities.Catalogs;

    public class GetGuestTypeByIdQuery : IRequest<Result<GuestType>>
    {
        public int Id { get; set; }
    }
}
