using Microsoft.EntityFrameworkCore;
using WarehouseManager.Domain.Entities;
using WarehouseManager.Domain.Repositories;
using WarehouseManager.Infrastructure.DAL;

namespace WarehouseManager.Infrastructure.Repositories;

public class WarehouseRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    : RepositoryBase<Warehouse>(dbContextFactory), IWarehouseRepository
{
}
