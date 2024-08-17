using MediatR;

namespace Application.Services.Catalog.GuestType.Command.Update
{
    using Domain.Entities.Catalogs;

    public class UpdateGuestTypeRequest : IRequest<Unit>
    {
        public GuestType GuestType { get; set; }
    }
}
