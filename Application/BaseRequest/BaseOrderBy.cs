using System.Linq.Expressions;
using System.Reflection;

namespace Application.Filter;

public static class BaseOrderBy
{
    /// <summary>
    ///     Apply base saroting logic
    /// </summary>
    /// <param name="query"></param>
    /// <param name="orderByDto"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="ApplicationException"></exception>
    public static IQueryable<T> ApplyOrderBy<T>(this IQueryable<T> query, DTOs.BaseOrderBy orderByDto)
    {
        if (string.IsNullOrEmpty(orderByDto.OrderByProperty))
            return query;

        var propertyInfo = typeof(T).GetProperty(orderByDto.OrderByProperty,
            BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);
        if (propertyInfo == null)
            throw new ApplicationException($"Unable to find property {orderByDto.OrderByProperty} in type {typeof(T)}");

        var parameter = Expression.Parameter(typeof(T), "x");
        var property = Expression.Property(parameter, propertyInfo);
        var lambda = Expression.Lambda(property, parameter);

        //building expression on top of current query
        var methodName = orderByDto.IsAscending ? "OrderBy" : "OrderByDescending";
        var resultExpression = Expression.Call(typeof(Queryable), methodName,
            new[] { typeof(T), propertyInfo.PropertyType }, query.Expression, Expression.Quote(lambda));

        return query.Provider.CreateQuery<T>(resultExpression);
    }
}