using MediatR;

namespace Application.Services.Catalog.GuestType.Queries.GetById
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

    public class GetRoomTypeByIdHandler : IRequestHandler<GetGuestTypeByIdQuery, Result<GuestType>>
    {
        public readonly IRepository<GuestType> _repository;
        private readonly ILogger<GetRoomTypeByIdHandler> _logger;

        public GetRoomTypeByIdHandler(
            IRepository<GuestType> repository,
            ILogger<GetRoomTypeByIdHandler> logger
        )
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<Result<GuestType>> Handle(
            GetGuestTypeByIdQuery request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                var guestType = await _repository.GetById(request.Id);
                if (guestType == null)
                {
                    return Result<GuestType>.Failure(
                        new Error(
                            ((int)HttpStatusCode.NotFound),
                            "Unable to find GuestType with specified Id",
                            ""
                        )
                    );
                }
                else
                    return Result<GuestType>.Success(guestType);
            }
            catch (Exception ex)
            {
                if (ex is RentMeException)
                {
                    throw;
                }
                _logger.LogError("Unable to get GuestType @{ex}", ex);
                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to create GuestType",
                    ""
                );
            }
        }
    }
}
