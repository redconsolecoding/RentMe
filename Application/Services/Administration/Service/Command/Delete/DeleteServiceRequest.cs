using MediatR;

namespace Application.Services.Administration.Service.Command.Delete
{
    using Domain.Entities.Administration;

    public class DeleteServiceRequest : IRequest<Unit>
    {
        public Service Service { get; set; }
    }
}
