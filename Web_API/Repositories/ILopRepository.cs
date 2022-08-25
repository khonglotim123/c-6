using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Lop;
using Web_API.Models;

namespace Web_API.Repositories
{
    public interface ILopRepository
    {
        bool Add(ViewLop sinhVien);
        bool Update(ViewLop sinhVien);
        bool Delete(int id);
        Lop GetId(int id);
        List<Lop> GetAll();
    }
}
