using MediatR;

namespace Application.Services.Administration.Service.Command.Update
{
    using Domain.Common;
    using Domain.Entities.Administration;

    public class UpdateServiceRequest : IRequest<Result>
    {
        public required Service Service { get; set; }
    }
}
