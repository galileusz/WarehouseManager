using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Application.Interfaces.Helpers;
using WarehouseManager.Application.Models;
using WarehouseManager.Domain.Repositories;

namespace WarehouseManager.Application.Services;

public class AppUserService
{
    private readonly IAppUserRepository _appUserRepository;
    private readonly IPasswordHasher _passwordHasher;
    private readonly IMapper _mapper;

    public AppUserService(
        IAppUserRepository appUserRepository,
        IPasswordHasher passwordHasher,
        IMapper mapper)
    {
        _appUserRepository = appUserRepository;
        _passwordHasher = passwordHasher;
        _mapper = mapper;
    }

    public async Task<AppUser?> LoginAsync(string login, string password)
    {
        var user = await _appUserRepository.GetUserByLoginAsync(login);

        if (user is null)
            return null;
        
        var hash = _passwordHasher.GetHashString(password);

        if (user.Password == hash)
            return _mapper.Map<AppUser>(user);
        
        return null;
    }


}
