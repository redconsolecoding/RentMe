namespace Application.DTOs;

public class QueryParameters
{
    public int Skip { get; set; } = 0;
    public int Take { get; set; } = 10;
    public List<FilterCriteria> Filters { get; set; } = new();
}