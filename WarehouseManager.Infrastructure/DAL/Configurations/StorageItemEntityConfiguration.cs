using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Entities;

namespace WarehouseManager.Infrastructure.DAL.Configurations;

internal class StorageItemEntityConfiguration : IEntityTypeConfiguration<StorageItem>
{
    public void Configure(EntityTypeBuilder<StorageItem> builder)
    {
        builder.HasKey(x => x.Id);
        builder.HasOne(p => p.Warehouse)
            .WithMany()
            .HasForeignKey(p => p.WarehouseId)
            .OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.StorageComponent)
            .WithMany()
            .HasForeignKey(p => p.StorageComponentId)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
