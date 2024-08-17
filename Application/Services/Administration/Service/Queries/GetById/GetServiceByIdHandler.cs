using MediatR;

namespace Application.Services.Administration.Service.Queries.GetById
{
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Exceptions;
    using Application.Repositories;
    using Domain.Entities.Administration;
    using Domain.Entities.Catalogs;
    using Microsoft.Extensions.Logging;

    public class GetServiceByIdHandler : IRequestHandler<GetServiceByIdQuery, Service>
    {
        public readonly IRepository<Service> _repository;
        private readonly ILogger<GetServiceByIdHandler> _logger;

        public GetServiceByIdHandler(
            IRepository<Service> repository,
            ILogger<GetServiceByIdHandler> logger
        )
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<Service> Handle(
            GetServiceByIdQuery request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                Service service = await _repository.GetById(request.Id);
                if (service == null)
                {
                    throw new RentMeException(
                        ((int)HttpStatusCode.NotFound),
                        "Unable to find Service with specified Id",
                        ""
                    );
                }
                else
                    return service;
            }
            catch (Exception ex)
            {
                if (ex is RentMeException)
                {
                    throw;
                }
                _logger.LogError("Unable to get Service @{ex}", ex);
                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to get Service",
                    ""
                );
            }
        }
    }
}
