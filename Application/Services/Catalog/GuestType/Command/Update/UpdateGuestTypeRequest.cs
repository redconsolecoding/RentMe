using MediatR;

namespace Application.Services.Catalog.GuestType.Command.Update
{
    using Domain.Common;
    using Domain.Entities.Catalogs;

    public class UpdateGuestTypeRequest : IRequest<Result>
    {
        public required GuestType GuestType { get; set; }
    }
}
