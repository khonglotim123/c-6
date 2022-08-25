using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Configurations;
using Web_API.Models;

namespace Web_API.Context
{
    public class SinhVienContext:DbContext
    {
        public SinhVienContext(DbContextOptions<SinhVienContext> options) : base(options)
        {

        }


        public DbSet<Diem> diems { get; set; }
        public DbSet<Lop> lops { get; set; }
        public DbSet<MonHoc> monHocs { get; set; }
        public DbSet<Nghanh> nghanhs { get; set; }
        public DbSet<SinhVien> sinhViens { get; set; }
        public DbSet<Truong> truongs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new DiemConfiguration());     
            modelBuilder.ApplyConfiguration(new LopConfiguration());     
            modelBuilder.ApplyConfiguration(new MonHocConfiguration());     
            modelBuilder.ApplyConfiguration(new SinhVienConfiguration());     
            modelBuilder.ApplyConfiguration(new NghanhConfiguration());
            modelBuilder.ApplyConfiguration(new TruongConfiguration());
        }
    }
}
