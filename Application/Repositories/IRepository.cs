﻿using Application.DTOs;

namespace Application.Repositories;

public interface IRepository<T>
{
    public Task<IEnumerable<T>> GetAllAsync();
    public Task<IEnumerable<T>> GetAllWithFiltersAsync(QueryParameters queryParameters);

    public Task<T?> GetById(int id);

    public Task<T> AddAsync(T entity);

    public void UpdateAsync(T entity);

    public void DeleteAsync(T entity);
}