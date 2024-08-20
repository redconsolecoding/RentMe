using MediatR;

namespace Application.Services.Administration.Service.Command.Add
{
    using Domain.Common;
    using Domain.Entities.Administration;

    public class CreateServiceRequest : IRequest<Result<Service>>
    {
        public required Service Service { get; set; }
    }
}
