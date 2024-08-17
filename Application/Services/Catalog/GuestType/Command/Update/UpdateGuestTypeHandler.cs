using MediatR;

namespace Application.Services.Catalog.GuestType.Command.Update
{
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Exceptions;
    using Application.Interfaces;
    using Application.Repositories;
    using Domain.Entities.Catalogs;
    using Microsoft.Extensions.Logging;

    public class UpdateGuestTypeHandler : IRequestHandler<UpdateGuestTypeRequest, Unit>
    {
        private readonly IRepository<GuestType> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateGuestTypeHandler> _logger;

        public UpdateGuestTypeHandler(
            IRepository<GuestType> repository,
            IUnitOfWork unitOfWork,
            ILogger<UpdateGuestTypeHandler> logger
        )
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Unit> Handle(
            UpdateGuestTypeRequest request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                _repository.UpdateAsync(request.GuestType);

                await _unitOfWork.Commit(cancellationToken);

                return Unit.Value;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured when trying to update Guest Type");

                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to update GuestType",
                    ""
                );
            }
        }
    }
}
