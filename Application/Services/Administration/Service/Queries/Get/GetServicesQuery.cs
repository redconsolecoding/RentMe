using MediatR;

namespace Application.Services.Administration.Service.Queries.Get
{
    using Domain.Common;
    using Domain.Entities.Administration;

    public class GetServicesQuery : IRequest<Result<IEnumerable<Service>>> { }
}
