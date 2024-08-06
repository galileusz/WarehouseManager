using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Entities;

namespace WarehouseManager.Infrastructure.DAL.Configurations;

internal class StorageOperationEntityConfiguration : IEntityTypeConfiguration<StorageOperation>
{
    public void Configure(EntityTypeBuilder<StorageOperation> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.OperationType).HasConversion<int>();
        builder.Property(p => p.OperationState).HasConversion<int>();
        builder.Property(p => p.AcceptanceTime).IsRequired(false);
        builder.Property(p => p.AcceptingUserId).IsRequired(false);
    }
}
