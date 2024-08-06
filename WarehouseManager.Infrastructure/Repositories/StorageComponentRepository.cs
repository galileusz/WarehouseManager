using Microsoft.EntityFrameworkCore;
using WarehouseManager.Domain.Entities;
using WarehouseManager.Domain.Repositories;
using WarehouseManager.Infrastructure.DAL;

namespace WarehouseManager.Infrastructure.Repositories;

public class StorageComponentRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    : RepositoryBase<StorageComponent>(dbContextFactory), IStorageComponentRepository
{
}
