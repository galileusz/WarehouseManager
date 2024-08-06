using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Entities;
using WarehouseManager.Domain.Repositories;
using WarehouseManager.Infrastructure.DAL;

namespace WarehouseManager.Infrastructure.Repositories;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{
    private readonly IDbContextFactory<ApplicationDbContext> _dbContextFactory;
    protected ApplicationDbContext _context => _dbContextFactory.CreateDbContext();

    public RepositoryBase(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    {
        _dbContextFactory = dbContextFactory;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        using var context = _context;
        return await context.Set<TEntity>().ToListAsync();
    }

    public async Task<TEntity?> GetByIdAsync(int id)
    {
        using var context = _context;
        return await context.Set<TEntity>().FindAsync(id);
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        using var context = _context;

        var dbAppUser = await context.Set<TEntity>().AddAsync(entity);

        await context.SaveChangesAsync();

        return dbAppUser.Entity;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        using var context = _context;
        var dbEntity = context.Set<TEntity>().Update(entity);
        await context.SaveChangesAsync();
        return dbEntity.Entity;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        using var context = _context;

        var entity = await context.Set<TEntity>().FindAsync(id);

        if (entity == null)
            return false;

        context.Set<TEntity>().Remove(entity);

        await context.SaveChangesAsync();
        return true;
    }
}
