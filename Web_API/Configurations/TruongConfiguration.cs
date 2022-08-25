using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models;

namespace Web_API.Configurations
{
    public class TruongConfiguration : IEntityTypeConfiguration<Truong>
    {
        public void Configure(EntityTypeBuilder<Truong> builder)
        {
            builder.ToTable("Truong");
            builder.HasKey(c => c.Id);
        }
    }
}
