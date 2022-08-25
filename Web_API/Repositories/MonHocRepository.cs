using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.MonHoc;
using Web_API.Context;
using Web_API.Models;

namespace Web_API.Repositories
{
    public class MonHocRepository:IMonHocRepository
    {
        private readonly SinhVienContext _context;

        public MonHocRepository(SinhVienContext context)
        {
            _context = context;
        }

        public bool Add(ViewMonHoc sinhVien)
        {
            if (sinhVien == null) return false;
            _context.monHocs.Add(new MonHoc() { 
                Ma=sinhVien.Ma,
                TenMon=sinhVien.TenMon,
                IdNghanh=sinhVien.IdNghanh
            }); 
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            MonHoc monHoc = _context.monHocs.FirstOrDefault(c => c.Id == id);
            _context.Remove(monHoc);
            _context.SaveChanges();
            return true;
        }

        public List<MonHoc> GetAll()
        {
            return _context.monHocs.ToList();
        }

        public MonHoc GetId(int id)
        {
            return _context.monHocs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(ViewMonHoc sinhVien)
        {
            if (sinhVien == null) return false;
            _context.monHocs.Update(new MonHoc() { 
                Id=sinhVien.Id,
                Ma=sinhVien.Ma,
                TenMon=sinhVien.TenMon,
                IdNghanh=sinhVien.IdNghanh
            });
            _context.SaveChanges();
            return true;
        }
    }
}
