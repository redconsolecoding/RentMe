using MediatR;

namespace Application.Services.Catalog.GuestType.Command.Delete
{
    using Domain.Entities.Catalogs;

    public class DeleteGuestTypeRequest : IRequest<Unit>
    {
        public GuestType GuestType { get; set; }
    }
}
