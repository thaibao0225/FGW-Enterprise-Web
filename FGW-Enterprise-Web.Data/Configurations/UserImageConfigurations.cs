using FGW_Enterprise_Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Configurations
{
    public class UserImageConfigurations : IEntityTypeConfiguration<UserImage>
    {
        public void Configure(EntityTypeBuilder<UserImage> builder)
        {
            builder.ToTable("UserImage");
            builder.HasKey(x => x.Id);//khoa chinh  
            builder.HasOne(t => t.UserI).WithMany(ur => ur.UserImageU)
                .HasForeignKey(pc => pc.UserId);
            builder.Property(x => x.UrlImg).HasMaxLength(200).IsRequired(true);
        }
    }
}
