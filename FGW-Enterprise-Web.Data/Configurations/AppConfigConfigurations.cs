using FGW_Enterprise_Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Configurations
{
    public class AppConfigConfigurations : IEntityTypeConfiguration<AppConfig>
    {
        public void Configure(EntityTypeBuilder<AppConfig> builder)
        {
            builder.HasKey(x=> x.Key);
            builder.Property(x => x.Value).IsRequired(true);
        }
    }
}
