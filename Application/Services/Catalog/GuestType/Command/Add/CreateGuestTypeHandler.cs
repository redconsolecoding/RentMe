using MediatR;

namespace Application.Services.Catalog.GuestType.Command.Add
{
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Exceptions;
    using Application.Interfaces;
    using Application.Repositories;
    using Domain.Common;
    using Domain.Entities.Catalogs;
    using Microsoft.Extensions.Logging;

    public class GuestTypeHandler : IRequestHandler<CreateGuestTypeRequest, Result<GuestType>>
    {
        public readonly IRepository<GuestType> _repository;
        private readonly ILogger<GuestTypeHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public GuestTypeHandler(
            IRepository<GuestType> repository,
            ILogger<GuestTypeHandler> logger,
            IUnitOfWork unitOfWork
        )
        {
            _repository = repository;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<GuestType>> Handle(
            CreateGuestTypeRequest request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                var guestType = await _repository.AddAsync(request.GuestType);
                await _unitOfWork.Commit(cancellationToken);

                return Result<GuestType>.Success(guestType);
            }
            catch (Exception ex)
            {
                _logger.LogError("Unable to create GuestType @{ex}", ex);
                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to create GuestType",
                    ""
                );
            }
        }
    }
}
