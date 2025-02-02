using System.Net;
using Application.DTOs;
using Application.Exceptions;

namespace WebApi.Common;

public static class QueryParser
{
    public static QueryParameters Parse(string queryString)
    {
        var uriDecoded = WebUtility.UrlDecode(queryString).Remove(0, 1);
        var parameters = new QueryParameters();

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
                else if (queryPart.StartsWith("order="))
                {
                    var orderParts = queryPart.Split("=")[1].Split(' ');
                    if (orderParts.Length != 2) throw new Exception("Invalid order parameters");

                    parameters.OrderBy.OrderByProperty = orderParts[0];
                    if (orderParts[1] == "desc")
                        parameters.OrderBy.IsAscending = false;
                    else if (orderParts[1] == "asc")
                        parameters.OrderBy.IsAscending = true;
                    else
                        throw new Exception("Invalid order parameters");
                }
                else
                {
                    var filterParts = queryPart.Split(" ");
                    if (filterParts.Length != 3) throw new Exception("Invalid filter parameters");

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

            return parameters;
        }
        catch (Exception e)
        {
            throw new RentMeException((int)HttpStatusCode.BadRequest, "InvalidParameters", "InvalidParameters");
        }
    }
}