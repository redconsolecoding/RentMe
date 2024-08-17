using MediatR;

namespace Application.Services.Administration.Service.Command.Add
{
    using Domain.Entities.Administration;

    public class CreateServiceRequest : IRequest<Service>
    {
        public Service Service { get; set; }
    }
}
