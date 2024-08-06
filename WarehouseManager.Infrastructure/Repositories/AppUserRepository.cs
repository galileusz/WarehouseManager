using Microsoft.EntityFrameworkCore;
using WarehouseManager.Domain.Entities;
using WarehouseManager.Domain.Repositories;
using WarehouseManager.Infrastructure.DAL;

namespace WarehouseManager.Infrastructure.Repositories;

public class AppUserRepository(IDbContextFactory<ApplicationDbContext> dbContextFactory)
    : RepositoryBase<AppUser>(dbContextFactory), IAppUserRepository
{
    public async Task<AppUser?> GetUserByLoginAsync(string login)
    {
        using var context = _context;

        return await context.AppUsers.FirstOrDefaultAsync(e => e.Login == login);
    }
}
