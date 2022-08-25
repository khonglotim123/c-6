using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models;

namespace Web_API.Configurations
{
    public class SinhVienConfiguration : IEntityTypeConfiguration<SinhVien>
    {
        public void Configure(EntityTypeBuilder<SinhVien> builder)
        {
            builder.ToTable("SinhVien");
            builder.HasKey(c=>c.Id);
            builder.HasOne<Nghanh>(c => c.nghanh).WithMany(c => c.sinhViens).HasForeignKey(c => c.IdNghanh);
            builder.HasOne<Lop>(c => c.lop).WithMany(c => c.sinhViens).HasForeignKey(c => c.IdLop);
        }
    }
}
