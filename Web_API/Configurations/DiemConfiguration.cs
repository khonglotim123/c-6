using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models;

namespace Web_API.Configurations
{
    public class DiemConfiguration : IEntityTypeConfiguration<Diem>
    {
        public void Configure(EntityTypeBuilder<Diem> builder)
        {
            builder.ToTable("Diem");
            builder.HasKey(c => c.Id);
            builder.HasOne<MonHoc>(c => c.monHoc).WithMany(c => c.diems).HasForeignKey(c => c.IdMonhoc);
        }
    }
}
