using FGW_Enterprise_Web.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FGW_Enterprise_Web.Data.Configurations
{
    class DeadlineCateConfigurations : IEntityTypeConfiguration<DeadlineCate>
    {
        public void Configure(EntityTypeBuilder<DeadlineCate> builder)
        {
            builder.ToTable("DeadlineCate");
            builder.HasKey(x => x.dlCate_Id);
        }
    }
}
