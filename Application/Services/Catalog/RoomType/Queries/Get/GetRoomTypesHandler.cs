using MediatR;

namespace Application.Services.Catalog.RoomType.Queries.Get
{
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Exceptions;
    using Application.Repositories;
    using Domain.Entities.Catalogs;
    using Microsoft.Extensions.Logging;

    public class GetRoomTypesHandler : IRequestHandler<GetRoomTypesQuery, IEnumerable<RoomType>>
    {
        public readonly IRepository<RoomType> _repository;
        private readonly ILogger<GetRoomTypesHandler> _logger;

        public GetRoomTypesHandler(
            IRepository<RoomType> repository,
            ILogger<GetRoomTypesHandler> logger
        )
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<IEnumerable<RoomType>> Handle(
            GetRoomTypesQuery request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                return await _repository.GetAllAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unable to get RoomTypes");
                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to get RoomTypes",
                    ""
                );
            }
        }
    }
}
