﻿using FGW_Enterprise_Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Configurations
{
    class RegisterCommentConfigurations : IEntityTypeConfiguration<RegisterComment>
    {
        public void Configure(EntityTypeBuilder<RegisterComment> builder)
        {
            builder.ToTable("RegisterComment");
            builder.HasKey(t => new { t.rescmt_CmtId, t.rescmt_FileId });
            builder.HasOne(t => t.UserFile).WithMany(ur => ur.RegisterComment)
                .HasForeignKey(pc => pc.rescmt_FileId);
            builder.HasOne(t => t.Comment).WithMany(ur => ur.RegisterComment)
                .HasForeignKey(pc => pc.rescmt_CmtId);
        }
    }
}
