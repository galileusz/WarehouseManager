using WarehouseManager.Domain.Entities;

namespace WarehouseManager.Domain.Repositories;

public interface IAppUserRepository : IRepositoryBase<AppUser>
{
    Task<AppUser?> GetUserByLoginAsync(string login);
}
