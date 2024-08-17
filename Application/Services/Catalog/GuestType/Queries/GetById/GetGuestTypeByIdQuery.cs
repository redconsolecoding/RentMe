using MediatR;

namespace Application.Services.Catalog.GuestType.Queries.GetById
{
    using Domain.Entities.Catalogs;

    public class GetGuestTypeByIdQuery : IRequest<GuestType>
    {
        public int Id { get; set; }
    }
}
