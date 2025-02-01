using Application.DTOs;
using MediatR;

namespace Application.Services.Catalog.GuestType.Queries.Get;

public class GetGuestTypesQuery : IRequest<PagedResponseModel<Domain.Entities.Catalogs.GuestType>>
{
    public GetGuestTypesQuery(QueryParameters queryParameters)
    {
        QueryParameters = queryParameters;
    }

    public QueryParameters QueryParameters { get; set; }
}