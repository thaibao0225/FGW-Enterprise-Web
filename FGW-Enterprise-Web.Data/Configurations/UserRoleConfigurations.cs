using FGW_Enterprise_Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Configurations
{
    public class UserRoleConfigurations : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRole");
            builder.HasKey(t=> new {t.ur_UserId, t.ur_RoleId});
            builder.HasOne(t => t.User).WithMany(ur => ur.UserRole)
                .HasForeignKey(pc=>pc.ur_UserId);
            builder.HasOne(t => t.Role).WithMany(ur => ur.UserRole)
                .HasForeignKey(pc => pc.ur_RoleId);
          


        }
    }
}
