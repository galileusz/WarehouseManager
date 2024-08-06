using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Entities;
using WarehouseManager.Infrastructure.DAL.Configurations;

namespace WarehouseManager.Infrastructure.DAL;

public class ApplicationDbContext : DbContext
{
    public DbSet<StorageComponent> StorageComponents { get; set; }
    public DbSet<StorageOperation> StorageOperations { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }
    public DbSet<StorageItem> StorageItems { get; set; }
    public DbSet<AppUser> AppUsers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}
