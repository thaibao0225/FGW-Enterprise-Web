using FGW_Enterprise_Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Configurations
{
    class UserFileConfigurations : IEntityTypeConfiguration<UserFile>
    {
        public void Configure(EntityTypeBuilder<UserFile> builder)
        {
            builder.ToTable("UserFile");
            builder.HasKey(x => x.file_Id);//khoa chinh        }
            builder.HasOne(t => t.DeadlineF).WithMany(ur => ur.UserFileD)
                .HasForeignKey(pc => pc.file_DeadlineId);
        }
    }
}
