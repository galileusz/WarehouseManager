using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Entities;

namespace WarehouseManager.Infrastructure.DAL.Configurations;

internal class OperationItemEntityConfiguration : IEntityTypeConfiguration<OperationItem>
{
    public void Configure(EntityTypeBuilder<OperationItem> builder)
    {
        builder.HasKey(p => p.Id);
        builder.HasOne(p => p.StorageOperation)
            .WithMany(so => so.OperationItems)
            .HasForeignKey(p => p.StorageOperationId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
