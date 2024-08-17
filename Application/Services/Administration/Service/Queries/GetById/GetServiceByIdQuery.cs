using MediatR;

namespace Application.Services.Administration.Service.Queries.GetById
{
    using Domain.Entities.Administration;

    public class GetServiceByIdQuery : IRequest<Service>
    {
        public int Id { get; set; }
    }
}
