using System.Net;
using Application.Exceptions;
using Application.Interfaces;
using Application.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Services.Catalog.RoomType.Command.Update
{
    using Domain.Entities.Catalogs;

    public class UpdateRoomTypeHandler : IRequestHandler<UpdateRoomTypeRequest, Unit>
    {
        private readonly IRepository<RoomType> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<UpdateRoomTypeHandler> _logger;

        public UpdateRoomTypeHandler(
            IRepository<RoomType> repository,
            IUnitOfWork unitOfWork,
            ILogger<UpdateRoomTypeHandler> logger
        )
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        public async Task<Unit> Handle(
            UpdateRoomTypeRequest request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                _repository.UpdateAsync(request.RoomType);

                await _unitOfWork.Commit(cancellationToken);

                return Unit.Value;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occured when trying to update RoomType");

                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to update RoomType",
                    ""
                );
            }
        }
    }
}
