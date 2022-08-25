using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models;

namespace Web_API.Configurations
{
    public class LopConfiguration : IEntityTypeConfiguration<Lop>
    {
        public void Configure(EntityTypeBuilder<Lop> builder)
        {
            builder.ToTable("Lop");
            builder.HasKey(c => c.Id);
            builder.HasOne<Truong>(c => c.truong).WithMany(c => c.lops).HasForeignKey(c => c.IdTruong);
        }
    }
}
