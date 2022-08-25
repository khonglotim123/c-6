using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Nghanh;
using Web_API.Context;
using Web_API.Models;

namespace Web_API.Repositories
{
    public class NghanhRepository : INghanhRepository
    {
        private readonly SinhVienContext _context;

        public NghanhRepository(SinhVienContext context)
        {
            _context = context;
        }
        public bool Add(ViewNghanh sinhVien)
        {
            if (sinhVien == null) return false;
            _context.nghanhs.Add(new Nghanh()
            {
                Ma = sinhVien.Ma,
                TenNghanh = sinhVien.TenNghanh
            });
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            Nghanh alo = _context.nghanhs.FirstOrDefault(c => c.Id == id);
            _context.nghanhs.Remove(alo);
            _context.SaveChanges();
            return true;
        }

        public List<Nghanh> GetAll()
        {
            return _context.nghanhs.ToList();
        }

        public Nghanh GetId(int id)
        {
            return _context.nghanhs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(ViewNghanh sinhVien)
        {
            if (sinhVien == null) return false;
            _context.nghanhs.Update(new Nghanh()
            {
                Id=sinhVien.Id,
                Ma = sinhVien.Ma,
                TenNghanh = sinhVien.TenNghanh
            });
            _context.SaveChanges();
            return true;
        }
    }
}
