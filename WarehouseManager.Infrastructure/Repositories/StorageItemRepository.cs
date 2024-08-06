using Microsoft.EntityFrameworkCore;
using WarehouseManager.Domain.Entities;
using WarehouseManager.Domain.Repositories;
using WarehouseManager.Infrastructure.DAL;

namespace WarehouseManager.Infrastructure.Repositories;

public class StorageItemRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    : RepositoryBase<StorageItem>(dbContextFactory), IStorageItemRepository
{
}
