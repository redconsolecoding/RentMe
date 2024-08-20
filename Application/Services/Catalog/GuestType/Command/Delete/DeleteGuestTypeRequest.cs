using MediatR;

namespace Application.Services.Catalog.GuestType.Command.Delete
{
    using Domain.Common;
    using Domain.Entities.Catalogs;

    public class DeleteGuestTypeRequest : IRequest<Result>
    {
        public required GuestType GuestType { get; set; }
    }
}
