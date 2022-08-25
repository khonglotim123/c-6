using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models;

namespace Web_API.Configurations
{
    public class NghanhConfiguration : IEntityTypeConfiguration<Nghanh>
    {
        public void Configure(EntityTypeBuilder<Nghanh> builder)
        {
            builder.ToTable("Nghanh");
            builder.HasKey(c => c.Id);
        }
    }
}
