using Application.Interfaces;
using Application.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Services.Administration.Service.Command.Update
{
    using System.Net;
    using Application.Exceptions;
    using Domain.Entities.Administration;

    public class UpdateServiceHandler : IRequestHandler<UpdateServiceRequest, Unit>
    {
        private readonly IRepository<Service> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateServiceHandler> _logger;

        public UpdateServiceHandler(
            IRepository<Service> repository,
            IUnitOfWork unitOfWork,
            ILogger<UpdateServiceHandler> logger
        )
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Unit> Handle(
            UpdateServiceRequest request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                _repository.UpdateAsync(request.Service);

                await _unitOfWork.Commit(cancellationToken);

                return Unit.Value;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured when trying to update Service");

                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to update Service",
                    ""
                );
            }
        }
    }
}
