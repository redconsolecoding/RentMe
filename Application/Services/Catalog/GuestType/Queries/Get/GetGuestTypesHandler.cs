using System.Net;
using Application.DTOs;
using Application.Exceptions;
using Application.Repositories;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Services.Catalog.GuestType.Queries.Get;

public class GetGuestTypesHandler(
    IRepository<Domain.Entities.Catalogs.GuestType> repository,
    ILogger<GetGuestTypesHandler> logger)
    : IRequestHandler<GetGuestTypesQuery, PagedResponseModel<Domain.Entities.Catalogs.GuestType>>
{
    public async Task<PagedResponseModel<Domain.Entities.Catalogs.GuestType>> Handle(
        GetGuestTypesQuery request,
        CancellationToken cancellationToken
    )
    {
        try
        {
            var repositoryResponse =
                await repository.GetAllWithFiltersAsync(request.QueryParameters);

            var response = new PagedResponseModel<Domain.Entities.Catalogs.GuestType>(repositoryResponse.Data,
                request.QueryParameters.Skip / request.QueryParameters.Take + 1, request.QueryParameters.Take,
                repositoryResponse.TotalCount);

            return response;
        }
        catch (Exception ex)
        {
            logger.LogError(ex, "Unable to get GuestTypes");
            throw new RentMeException(
                (int)HttpStatusCode.BadRequest,
                "Unable to get GuestTypes",
                ""
            );
        }
    }
}