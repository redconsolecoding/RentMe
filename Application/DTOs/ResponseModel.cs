namespace Application.DTOs;

public class PagedResponseModel<T>
{
    public PagedResponseModel(List<T> data, int pageNumber, int pageSize, int totalCount)
    {
        Data = data;
        PageNumber = pageNumber;
        PageSize = pageSize;
        TotalCount = totalCount;
    }

    public List<T> Data { get; set; }
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalCount { get; set; }
    public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
}

public class RepositoryResponse<T>
{
    public RepositoryResponse(List<T> data, int totalCount)
    {
        Data = data;
        TotalCount = totalCount;
    }

    public List<T> Data { get; set; }
    public int TotalCount { get; set; }
}