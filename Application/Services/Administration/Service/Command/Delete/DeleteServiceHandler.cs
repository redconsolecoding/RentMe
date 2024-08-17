using Application.Interfaces;
using Application.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Services.Administration.Service.Command.Delete
{
    using System.Net;
    using Application.Exceptions;
    using Domain.Entities.Administration;

    public class DeleteServiceHandler : IRequestHandler<DeleteServiceRequest, Unit>
    {
        private readonly IRepository<Service> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DeleteServiceHandler> _logger;

        public DeleteServiceHandler(
            IRepository<Service> repository,
            IUnitOfWork unitOfWork,
            ILogger<DeleteServiceHandler> logger
        )
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Unit> Handle(
            DeleteServiceRequest request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                _repository.DeleteAsync(request.Service);

                await _unitOfWork.Commit(cancellationToken);

                return Unit.Value;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured when trying to delete Service");

                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to delete Service",
                    ""
                );
            }
        }
    }
}
