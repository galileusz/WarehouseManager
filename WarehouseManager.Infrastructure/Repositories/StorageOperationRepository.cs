using Microsoft.EntityFrameworkCore;
using WarehouseManager.Domain.Entities;
using WarehouseManager.Domain.Repositories;
using WarehouseManager.Infrastructure.DAL;

namespace WarehouseManager.Infrastructure.Repositories;

public class StorageOperationRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    : RepositoryBase<StorageOperation>(dbContextFactory), IStorageOperationRepository
{
}
