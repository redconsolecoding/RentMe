using MediatR;

namespace Application.Services.Catalog.GuestType.Command.Add
{
    using Domain.Common;
    using Domain.Entities.Catalogs;

    public class CreateGuestTypeRequest : IRequest<Result<GuestType>>
    {
        public required GuestType GuestType { get; set; }
    }
}
