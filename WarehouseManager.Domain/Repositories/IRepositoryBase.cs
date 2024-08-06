﻿using WarehouseManager.Domain.Entities;

namespace WarehouseManager.Domain.Repositories;

public interface IRepositoryBase<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task<T> AddAsync(T entity);
    Task<T> UpdateAsync(T entity);
    Task<bool> DeleteAsync(int id);
}
