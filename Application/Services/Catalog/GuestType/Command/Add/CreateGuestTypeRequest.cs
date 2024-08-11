using MediatR;

namespace Application.Services.Catalog.GuestType.Command.Add
{
    using Domain.Entities.Catalogs;

    public class CreateGuestTypeRequest : IRequest<GuestType>
    {
        public required GuestType GuestType { get; set; }
    }
}
