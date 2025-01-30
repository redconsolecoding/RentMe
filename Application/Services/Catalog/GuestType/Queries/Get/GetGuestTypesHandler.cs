using System.Net;
using Application.Exceptions;
using Application.Repositories;
using Domain.Common;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Services.Catalog.GuestType.Queries.Get;

public class GetGuestTypesHandler
    : IRequestHandler<GetGuestTypesQuery, Result<IEnumerable<Domain.Entities.Catalogs.GuestType>>>
{
    private readonly ILogger<GetGuestTypesHandler> _logger;
    public readonly IRepository<Domain.Entities.Catalogs.GuestType> _repository;

    public GetGuestTypesHandler(
        IRepository<Domain.Entities.Catalogs.GuestType> repository,
        ILogger<GetGuestTypesHandler> logger
    )
    {
        _repository = repository;
        _logger = logger;
    }

    public async Task<Result<IEnumerable<Domain.Entities.Catalogs.GuestType>>> Handle(
        GetGuestTypesQuery request,
        CancellationToken cancellationToken
    )
    {
        try
        {
            var guestTypes =
                await _repository.GetAllWithFiltersAsync(request.QueryParameters);

            return Result<IEnumerable<Domain.Entities.Catalogs.GuestType>>.Success(guestTypes);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Unable to get GuestTypes");
            throw new RentMeException(
                (int)HttpStatusCode.BadRequest,
                "Unable to create GuestType",
                ""
            );
        }
    }
}