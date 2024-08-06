using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Entities;

namespace WarehouseManager.Infrastructure.DAL.Configurations;

internal class StorageComponentEntityConfiguration : IEntityTypeConfiguration<StorageComponent>
{
    public void Configure(EntityTypeBuilder<StorageComponent> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Name).HasMaxLength(30);
        builder.Property(p => p.Description).HasMaxLength(250);
    }
}
