using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Truong;
using Web_API.Context;
using Web_API.Models;

namespace Web_API.Repositories
{
    public class TruongRepository:ITruongRepository
    {
        private readonly SinhVienContext _context;

        public TruongRepository(SinhVienContext context)
        {
            _context = context;
        }

        public bool Add(ViewTruong sinhVien)
        {
            if (sinhVien == null) return false;
            _context.truongs.Add(new Truong() {                 
                Ma=sinhVien.Ma,
                TenTruong=sinhVien.TenTruong
            });
            _context.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            if (id == null) return false;
            Truong truong = _context.truongs.FirstOrDefault(c => c.Id == id);
            _context.Remove(truong);
            _context.SaveChanges();
            return true;
        }

        public List<Truong> GetAll()
        {
            return _context.truongs.ToList();
        }

        public Truong GetId(int id)
        {
            return _context.truongs.FirstOrDefault(c => c.Id == id);
        }

        public bool Update(ViewTruong sinhVien)
        {
            if (sinhVien == null) return false;
            _context.truongs.Update(new Truong()
            {
                Id = sinhVien.Id,
                Ma = sinhVien.Ma,
                TenTruong = sinhVien.TenTruong
            });
            _context.SaveChanges();
            return true;
        }
    }
}
