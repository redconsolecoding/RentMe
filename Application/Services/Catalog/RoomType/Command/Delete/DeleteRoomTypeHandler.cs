using Application.Interfaces;
using Application.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Services.Catalog.RoomType.Command.Delete
{
    using System.Net;
    using Application.Exceptions;
    using Domain.Entities.Catalogs;

    public class DeleteRoomTypeHandler : IRequestHandler<DeleteRoomTypeRequest, Unit>
    {
        private readonly IRepository<RoomType> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DeleteRoomTypeHandler> _logger;

        public DeleteRoomTypeHandler(
            IRepository<RoomType> repository,
            IUnitOfWork unitOfWork,
            ILogger<DeleteRoomTypeHandler> logger
        )
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Unit> Handle(
            DeleteRoomTypeRequest request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                _repository.DeleteAsync(request.RoomType);

                await _unitOfWork.Commit(cancellationToken);

                return Unit.Value;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured when trying to delete RoomType");

                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to delete RoomType",
                    ""
                );
            }
        }
    }
}
