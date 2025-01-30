namespace Application.Filter;

public static class BaseFilter
{
    public static IQueryable<T> ApplyFilter<T>(this IQueryable<T> query, IQueryable<T> filter)
    {
        return query;
    }
}