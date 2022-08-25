using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Lop;
using Web_API.Context;
using Web_API.Models;

namespace Web_API.Repositories
{
    public class LopRepository:ILopRepository
    {
        private readonly SinhVienContext _context;

        public LopRepository(SinhVienContext context)
        {
            _context = context;
        }

        public bool Add(ViewLop sinhVien)
        {
            if (sinhVien == null) return false;
            _context.lops.Add(new Lop()
            {                
                Ma=sinhVien.Ma,
                TenLop=sinhVien.TenLop,
                IdTruong=sinhVien.IdTruong,
            });
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            Lop lop = _context.lops.ToList().FirstOrDefault(c => c.Id == id);
            _context.lops.Remove(lop);
            _context.SaveChanges();
            return true;
        }

        public List<Lop> GetAll()
        {
            return _context.lops.ToList();
        }

        public Lop GetId(int id)
        {
            
            return _context.lops.FirstOrDefault(c=>c.Id==id);
        }

        public bool Update(ViewLop sinhVien)
        {
            if (sinhVien == null) return false;
            _context.lops.Update(new Lop() {
                Id=sinhVien.Id,
                Ma=sinhVien.Ma,
                TenLop=sinhVien.TenLop,
                IdTruong=sinhVien.IdTruong
            });
            _context.SaveChanges();
            return true;
        }
    }
}
