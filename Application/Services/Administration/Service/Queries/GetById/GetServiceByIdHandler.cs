using MediatR;

namespace Application.Services.Administration.Service.Queries.GetById
{
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Exceptions;
    using Application.Repositories;
    using Domain.Common;
    using Domain.Entities.Administration;
    using Domain.Entities.Catalogs;
    using Microsoft.Extensions.Logging;

    public class GetServiceByIdHandler : IRequestHandler<GetServiceByIdQuery, Result<Service>>
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

        public async Task<Result<Service>> Handle(
            GetServiceByIdQuery request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                var service = await _repository.GetById(request.Id);
                if (service == null)
                {
                    return Result<Service>.Failure(
                        new Error(
                            ((int)HttpStatusCode.NotFound),
                            "Unable to find Service with specified Id",
                            ""
                        )
                    );
                }
                else
                    return Result<Service>.Success(service);
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
