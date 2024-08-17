using MediatR;

namespace Application.Services.Administration.Service.Queries.Get
{
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Exceptions;
    using Application.Repositories;
    using Application.Services.Catalog.RoomType.Queries.Get;
    using Domain.Entities.Administration;
    using Domain.Entities.Catalogs;
    using Microsoft.Extensions.Logging;

    public class GetServicesHandler : IRequestHandler<GetServicesQuery, IEnumerable<Service>>
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

        public async Task<IEnumerable<Service>> Handle(
            GetServicesQuery request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                return await _repository.GetAllAsync();
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
