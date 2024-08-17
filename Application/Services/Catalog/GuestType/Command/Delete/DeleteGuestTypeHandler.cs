using Application.Interfaces;
using Application.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Services.Catalog.GuestType.Command.Delete
{
    using System.Net;
    using Application.Exceptions;
    using Domain.Entities.Catalogs;

    public class DeleteGuestTypeHandler : IRequestHandler<DeleteGuestTypeRequest, Unit>
    {
        private readonly IRepository<GuestType> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DeleteGuestTypeHandler> _logger;

        public DeleteGuestTypeHandler(
            IRepository<GuestType> repository,
            IUnitOfWork unitOfWork,
            ILogger<DeleteGuestTypeHandler> logger
        )
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Unit> Handle(
            DeleteGuestTypeRequest request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                _repository.DeleteAsync(request.GuestType);

                await _unitOfWork.Commit(cancellationToken);

                return Unit.Value;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured when trying to delete GuestType");

                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to delete GuestType",
                    ""
                );
            }
        }
    }
}
