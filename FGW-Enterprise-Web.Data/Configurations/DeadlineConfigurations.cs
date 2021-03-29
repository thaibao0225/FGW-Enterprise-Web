using FGW_Enterprise_Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Configurations
{
    class DeadlineConfigurations : IEntityTypeConfiguration<Deadline>
    {
        public void Configure(EntityTypeBuilder<Deadline> builder)
        {
            builder.ToTable("Deadline");
            builder.HasKey(t => new { t.dl_Id });

        }
    }
}
