using System.Linq.Expressions;
using System.Reflection;
using Application.DTOs;

namespace Application.Filter;

public static class BaseFilter
{
    /// <summary>
    ///     Applies filters
    /// </summary>
    /// <param name="query"></param>
    /// <param name="filters"></param>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    public static IQueryable<T> ApplyFilter<T>(this IQueryable<T> query, ICollection<FilterCriteria> filters)
    {
        if (filters == null || filters.Count == 0)
            return query;

        foreach (var filter in filters)
        {
            var propertyName = filter.Property;
            var filterValue = filter.Value;
            var filterOperator = filter.Operator;

            var propertyInfo = typeof(T).GetProperty(propertyName,
                BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance);

            if (propertyInfo == null)
                throw new ArgumentException($"Property {propertyName} is not found in type {typeof(T).Name}");

            var value = Convert.ChangeType(filterValue, propertyInfo.PropertyType);

            var parameter = Expression.Parameter(typeof(T), "x");
            var property = Expression.Property(parameter, propertyInfo);
            var constant = Expression.Constant(value);

            var body = BuildFilterExpression(property, constant, filterOperator, parameter, filterValue);
            var lambda = Expression.Lambda<Func<T, bool>>(body, parameter);
            query = query.Where(lambda);
        }

        return query;
    }

    /// <summary>
    ///     Builds Filter experession comparators based on filter type
    /// </summary>
    /// <param name="property"></param>
    /// <param name="value"></param>
    /// <param name="operatorType"></param>
    /// <param name="parameter"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    private static Expression BuildFilterExpression(Expression property, Expression value, string operatorType,
        ParameterExpression parameter, object filterValue)
    {
        return operatorType.ToLower() switch
        {
            "eq" => Expression.Equal(property, value),
            "ne" => Expression.NotEqual(property, value),
            "lt" => Expression.LessThan(property, value),
            "gt" => Expression.GreaterThan(property, value),
            "contains" => BuildContainsExpression(property, filterValue, parameter),
            _ => throw new ArgumentException($"Operator {operatorType} not supported")
        };
    }

    /// <summary>
    ///     Builds contains expression for string values in this format 1,2,3
    /// </summary>
    /// <param name="property"></param>
    /// <param name="filterValue"></param>
    /// <param name="parameter"></param>
    /// <returns></returns>
    /// <exception cref="ArgumentException"></exception>
    private static Expression BuildContainsExpression(Expression property, object filterValue,
        ParameterExpression parameter)
    {
        if (filterValue is string stringValue)
        {
            var values = stringValue.Split(',').Select(v => Convert.ChangeType(v, property.Type))
                .ToList();
            var containsExpressions = values
                .Select(v => Expression.Call(property, "Contains", null, Expression.Constant(v))).Cast<Expression>()
                .Aggregate(Expression.OrElse);

            return containsExpressions;
        }

        throw new ArgumentException("The 'contains' operator can only be used with strings.");
    }
}