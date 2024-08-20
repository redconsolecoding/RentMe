using MediatR;

namespace Application.Services.Administration.Service.Command.Delete
{
    using Domain.Common;
    using Domain.Entities.Administration;

    public class DeleteServiceRequest : IRequest<Result>
    {
        public required Service Service { get; set; }
    }
}
