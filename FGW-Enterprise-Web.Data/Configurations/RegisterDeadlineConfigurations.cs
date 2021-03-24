using FGW_Enterprise_Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Configurations
{
    class RegisterDeadlineConfigurations : IEntityTypeConfiguration<RegisterDeadline>
    {
        public void Configure(EntityTypeBuilder<RegisterDeadline> builder)
        {
            builder.ToTable("RegisterDeadline");
            builder.HasKey(t => new { t.rd_DeadineCate, t.rd_DeadlineId });
            builder.HasOne(t => t.DealineCate).WithMany(ur => ur.RegisterDeadline)
                .HasForeignKey(pc => pc.rd_DeadineCate);
            builder.HasOne(t => t.Dealine).WithMany(ur => ur.RegisterDeadline)
                .HasForeignKey(pc => pc.rd_DeadlineId);
        }
    }
}
