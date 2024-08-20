using MediatR;

namespace Application.Services.Administration.Service.Queries.Get
{
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Exceptions;
    using Application.Repositories;
    using Application.Services.Catalog.RoomType.Queries.Get;
    using Domain.Common;
    using Domain.Entities.Administration;
    using Domain.Entities.Catalogs;
    using Microsoft.Extensions.Logging;

    public class GetServicesHandler
        : IRequestHandler<GetServicesQuery, Result<IEnumerable<Service>>>
    {
        public readonly IRepository<Service> _repository;
        private readonly ILogger<GetServicesHandler> _logger;

        public GetServicesHandler(
            IRepository<Service> repository,
            ILogger<GetServicesHandler> logger
        )
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<Result<IEnumerable<Service>>> Handle(
            GetServicesQuery request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                var services = await _repository.GetAllAsync();
                return Result<IEnumerable<Service>>.Success(services);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unable to get Services");
                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to ger Services",
                    ""
                );
            }
        }
    }
}
