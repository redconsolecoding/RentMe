using Application.DTOs;
using Application.Filter;
using Application.Repositories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class Repository<T> : IRepository<T>
    where T : class
{
    protected readonly DatabaseContext _databaseContext;

    public Repository(DatabaseContext context)
    {
        _databaseContext = context;
    }

    public async Task<T> AddAsync(T entity)
    {
        await _databaseContext.Set<T>().AddAsync(entity);
        return entity;
    }

    public void DeleteAsync(T entity)
    {
        _databaseContext.Set<T>().Remove(entity);
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _databaseContext.Set<T>().ToListAsync();
    }

    public async Task<T?> GetById(int id)
    {
        return await _databaseContext.Set<T>().FindAsync(id);
    }

    public void UpdateAsync(T entity)
    {
        _databaseContext.Set<T>().Update(entity);
    }

    public async Task<RepositoryResponse<T>> GetAllWithFiltersAsync(QueryParameters queryParameters)
    {
        var query = _databaseContext.Set<T>().AsQueryable();
        var totalCount = await query.CountAsync();
        query = query.ApplyFilter(queryParameters.Filters).Skip(queryParameters.Skip).Take(queryParameters.Take);
        var data = await query.ToListAsync();
        return new RepositoryResponse<T>(data, totalCount);
    }
}