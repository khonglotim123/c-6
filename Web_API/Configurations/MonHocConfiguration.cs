using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models;

namespace Web_API.Configurations
{
    public class MonHocConfiguration : IEntityTypeConfiguration<MonHoc>
    {       

        public void Configure(EntityTypeBuilder<MonHoc> builder)
        {
            builder.ToTable("MonHoc");
            builder.HasKey(c => c.Id);
            builder.HasOne<Nghanh>(c => c.nghanh).WithMany(c => c.monHocs).HasForeignKey(c => c.IdNghanh);
        }
    }
}
