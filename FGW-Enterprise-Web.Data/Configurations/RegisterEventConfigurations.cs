using FGW_Enterprise_Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Configurations
{
    class RegisterEventConfigurations : IEntityTypeConfiguration<RegisterEvent>
    {
        public void Configure(EntityTypeBuilder<RegisterEvent> builder)
        {
            builder.ToTable("RegisterEvent");
            builder.HasKey(t => new { t.resEvent_CourseId, t.resEvent_UserId, t.resEvent_DeadlineCate, t.resEvent_EventId });
            builder.HasOne(t => t.DealineCate).WithMany(ur => ur.RegisterEvent)
                .HasForeignKey(pc => pc.resEvent_DeadlineCate);
            builder.HasOne(t => t.Course).WithMany(ur => ur.RegisterEvent)
                .HasForeignKey(pc => pc.resEvent_CourseId);
            builder.HasOne(t => t.Event).WithMany(ur => ur.RegisterEvent)
                .HasForeignKey(pc => pc.resEvent_EventId);
            builder.HasOne(t => t.User).WithMany(ur => ur.RegisterEvent)
                .HasForeignKey(pc => pc.resEvent_UserId);
        }
    }
}
