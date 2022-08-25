using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel;
using Web_API.Context;
using Web_API.Models;

namespace Web_API.Repositories
{
    public class SinhVienService : ISinhVienService
    {
        private readonly SinhVienContext _context;

        public SinhVienService(SinhVienContext context)
        {
            _context = context;
        }
        public bool Add(ViewSinhVienRequest sinhVien)
        {
            if (sinhVien == null) return false;

            _context.sinhViens.Add(new SinhVien()
            {
                MaSV = sinhVien.MaSV,
                Ho = sinhVien.Ho,
                TenDem = sinhVien.TenDem,
                Ten = sinhVien.Ten,
                NgaySinh = sinhVien.NgaySinh,
                Email = sinhVien.Email,
                PassWord = sinhVien.PassWord,
                IdLop = sinhVien.IdLop,
                IdNghanh = sinhVien.IdNghanh
            });
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            SinhVien sinhVien = _context.sinhViens.FirstOrDefault(c => c.Id == id);
            if (sinhVien == null) return false;
            _context.sinhViens.Remove(sinhVien);
            _context.SaveChanges();
            return true;
        }

        public List<SinhVien> GetAll()
        {
            return _context.sinhViens.ToList();

        }

        public SinhVien GetId(int id)
        {
            SinhVien alo = _context.sinhViens.FirstOrDefault(c => c.Id == id);
            return alo;
        }

        public bool Update(ViewSinhVienRequest sinhVien)
        {
            if (sinhVien == null) return false;
            _context.sinhViens.Update(new SinhVien()
            {
                Id = sinhVien.Id,
                MaSV = sinhVien.MaSV,
                Ho = sinhVien.Ho,
                TenDem = sinhVien.TenDem,
                Ten = sinhVien.Ten,
                NgaySinh = sinhVien.NgaySinh,
                Email = sinhVien.Email,
                PassWord = sinhVien.PassWord,
                IdLop = sinhVien.IdLop,
                IdNghanh = sinhVien.IdNghanh
            });
            _context.SaveChanges();
            return true;
        }
    }
}
