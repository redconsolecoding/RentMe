using MediatR;

namespace Application.Services.Catalog.RoomType.Command.Add
{
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Exceptions;
    using Application.Interfaces;
    using Application.Repositories;
    using Domain.Entities.Catalogs;
    using Microsoft.Extensions.Logging;

    public class CreateRoomTypeTypeHandler : IRequestHandler<CreateRoomTypeRequest, RoomType>
    {
        public readonly IRepository<RoomType> _repository;
        private readonly ILogger<CreateRoomTypeTypeHandler> _logger;
        private readonly IUnitOfWork _unitOfWork;

        public CreateRoomTypeTypeHandler(
            IRepository<RoomType> repository,
            ILogger<CreateRoomTypeTypeHandler> logger,
            IUnitOfWork unitOfWork
        )
        {
            _repository = repository;
            _logger = logger;
            _unitOfWork = unitOfWork;
        }

        public async Task<RoomType> Handle(
            CreateRoomTypeRequest request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                var roomType = await _repository.AddAsync(request.RoomType);
                await _unitOfWork.Commit(cancellationToken);

                return roomType;
            }
            catch (Exception ex)
            {
                _logger.LogError("Unable to create RoomType @{ex}", ex);
                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to create RoomType",
                    ""
                );
            }
        }
    }
}
