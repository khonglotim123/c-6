using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel;
using Web_API.Models;


namespace Web_API.Repositories
{
    public interface ISinhVienService
    {
        bool Add(ViewSinhVienRequest sinhVien);
        bool Update(ViewSinhVienRequest sinhVien);
        bool Delete(int id);
        SinhVien GetId(int id);
        List<SinhVien> GetAll();
        
    }
}
