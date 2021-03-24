using FGW_Enterprise_Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Configurations
{
    class UserActionConfigurations : IEntityTypeConfiguration<UserAction>
    {
        public void Configure(EntityTypeBuilder<UserAction> builder)
        {
            builder.ToTable("UserAction");
            builder.HasKey(x => x.action_Id);
            builder.Property(x => x.action_Name).IsRequired(true);
        }
    }
}
