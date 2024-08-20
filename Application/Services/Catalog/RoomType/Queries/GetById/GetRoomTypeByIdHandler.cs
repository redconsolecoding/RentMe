using MediatR;

namespace Application.Services.Catalog.RoomType.Queries.GetById
{
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Exceptions;
    using Application.Repositories;
    using Domain.Common;
    using Domain.Entities.Catalogs;
    using Microsoft.Extensions.Logging;

    public class GetRoomTypeByIdHandler : IRequestHandler<GetRoomTypeByIdQuery, Result<RoomType>>
    {
        public readonly IRepository<RoomType> _repository;
        private readonly ILogger<GetRoomTypeByIdHandler> _logger;

        public GetRoomTypeByIdHandler(
            IRepository<RoomType> repository,
            ILogger<GetRoomTypeByIdHandler> logger
        )
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<Result<RoomType>> Handle(
            GetRoomTypeByIdQuery request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                var roomType = await _repository.GetById(request.Id);
                if (roomType == null)
                {
                    return Result<RoomType>.Failure(
                        new Error(
                            ((int)HttpStatusCode.NotFound),
                            "Unable to find Service with specified Id",
                            ""
                        )
                    );
                }
                else
                    return Result<RoomType>.Success(roomType);
            }
            catch (Exception ex)
            {
                if (ex is RentMeException)
                {
                    throw;
                }
                _logger.LogError("Unable to get RoomType @{ex}", ex);
                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to get RoomType",
                    ""
                );
            }
        }
    }
}
