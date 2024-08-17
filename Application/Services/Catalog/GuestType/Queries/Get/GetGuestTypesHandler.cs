using MediatR;

namespace Application.Services.Catalog.GuestType.Queries.Get
{
    using System.Net;
    using System.Threading;
    using System.Threading.Tasks;
    using Application.Exceptions;
    using Application.Repositories;
    using Domain.Entities.Catalogs;
    using Microsoft.Extensions.Logging;

    public class GetGuestTypesHandler : IRequestHandler<GetGuestTypesQuery, IEnumerable<GuestType>>
    {
        public readonly IRepository<GuestType> _repository;
        private readonly ILogger<GetGuestTypesHandler> _logger;

        public GetGuestTypesHandler(
            IRepository<GuestType> repository,
            ILogger<GetGuestTypesHandler> logger
        )
        {
            _repository = repository;
            _logger = logger;
        }

        public async Task<IEnumerable<GuestType>> Handle(
            GetGuestTypesQuery request,
            CancellationToken cancellationToken
        )
        {
            try
            {
                return await _repository.GetAllAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Unable to get GuestTypes");
                throw new RentMeException(
                    ((int)HttpStatusCode.BadRequest),
                    "Unable to create GuestType",
                    ""
                );
            }
        }
    }
}
