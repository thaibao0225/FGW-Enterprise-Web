using FGW_Enterprise_Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Configurations
{
    class PermisionConfigurations : IEntityTypeConfiguration<Permision>
    {
        public void Configure(EntityTypeBuilder<Permision> builder)
        {
            builder.ToTable("Permision");
            builder.HasKey(t => new { t.per_ActionId, t.per_FunctionId, t.per_RoleId });
            builder.HasOne(t => t.UserAction).WithMany(ur => ur.Permision)
                .HasForeignKey(pc => pc.per_ActionId);
            builder.HasOne(t => t.Role).WithMany(ur => ur.Permision)
                .HasForeignKey(pc => pc.per_RoleId);
            builder.HasOne(t => t.Function).WithMany(ur => ur.Permision)
                .HasForeignKey(pc => pc.per_FunctionId);
        }
    }
}
