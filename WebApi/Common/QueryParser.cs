using System.Net;
using Application.DTOs;
using Application.Exceptions;

namespace WebApi.Common;

public static class QueryParser
{
    public static QueryParameters Parse(string queryString)
    {
        var parameters = new QueryParameters();
        if (string.IsNullOrWhiteSpace(queryString))
            return parameters;
        
        var uriDecoded = WebUtility.UrlDecode(queryString).Remove(0, 1);

        var queryParts = uriDecoded.Split('&');
        try
        {
            foreach (var queryPart in queryParts)
                if (queryPart.StartsWith("skip="))
                {
                    parameters.Skip = int.Parse(queryPart.Split("=")[1]);
                }
                else if (queryPart.StartsWith("take="))
                {
                    parameters.Take = int.Parse(queryPart.Split("=")[1]);
                }
                else
                {
                    var filterParts = queryPart.Split(" ");
                    if (filterParts.Length == 3)
                    {
                        var property = filterParts[0];
                        var operatorType = filterParts[1];
                        var value = filterParts[2];
                        parameters.Filters.Add(new FilterCriteria
                        {
                            Property = property,
                            Operator = operatorType,
                            Value = value
                        });
                    }
                }

            return parameters;
        }
        catch (Exception e)
        {
            throw new RentMeException((int)HttpStatusCode.BadRequest, "parseError", "parseError");
        }
    }
}