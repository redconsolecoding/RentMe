using MediatR;

namespace Application.Services.Administration.Service.Queries.Get
{
    using Domain.Entities.Administration;

    public class GetServicesQuery : IRequest<IEnumerable<Service>> { }
}
