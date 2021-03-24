using FGW_Enterprise_Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Configurations
{
    public class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.user_Id);//khoa chinh
            builder.Property(x => x.user_Password).IsRequired(true);
            builder.Property(x => x.user_Name).IsRequired(true);
            builder.Property(x => x.user_FullName).IsRequired(true);
            builder.Property(x => x.user_PhoneNumber).IsRequired(true);
            builder.Property(x => x.user_DOB).IsRequired(true);
            builder.Property(x => x.user_Email).IsRequired(true);
            builder.Property(x => x.user_LastLoginDate).IsRequired(true);

        }
    }
}
