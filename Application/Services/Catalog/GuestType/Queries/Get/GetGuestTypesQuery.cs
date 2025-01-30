using Application.DTOs;
using Domain.Common;
using MediatR;

namespace Application.Services.Catalog.GuestType.Queries.Get;

public class GetGuestTypesQuery : IRequest<Result<IEnumerable<Domain.Entities.Catalogs.GuestType>>>
{
    public GetGuestTypesQuery(QueryParameters queryParameters)
    {
        QueryParameters = queryParameters;
    }

    public QueryParameters QueryParameters { get; set; }
}