using MediatR;

namespace Application.Services.Administration.Service.Command.Update
{
    using Domain.Entities.Administration;

    public class UpdateServiceRequest : IRequest<Unit>
    {
        public Service Service { get; set; }
    }
}
