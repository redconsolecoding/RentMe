using MediatR;

namespace Application.Services.Administration.Service.Command.Add
{
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Exceptions;
    using Application.Interfaces;
    using Application.Repositories;
    using Domain.Entities.Administration;
    using Microsoft.Extensions.Logging;

    public class CreateServiceHandler : IRequestHandler<CreateServiceRequest, Service>
    {
        public readonly IRepository<Service> _repository;
        private readonly ILogger<CreateServiceHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public CreateServiceHandler(
            IRepository<Service> repository,
            ILogger<CreateServiceHandler> logger,
            IUnitOfWork unitOfWork
        )
        {
            _repository = repository;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<Service> Handle(
            CreateServiceRequest request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                var service = await _repository.AddAsync(request.Service);
                await _unitOfWork.Commit(cancellationToken);

                return service;
            }
            catch (Exception ex)
            {
                _logger.LogError("Unable to create Service @{ex}", ex);
                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to create Service",
                    ""
                );
            }
        }
    }
}
