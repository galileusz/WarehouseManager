using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Domain.Entities;

namespace WarehouseManager.Infrastructure.DAL.Configurations;

internal class AppUserEntityConfiguration : IEntityTypeConfiguration<AppUser>
{
    public void Configure(EntityTypeBuilder<AppUser> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.FirstName).HasMaxLength(30);
        builder.Property(p => p.LastName).HasMaxLength(30);
        builder.Property(p => p.Login).HasMaxLength(30);
    }
}
