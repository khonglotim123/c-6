using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel;
using ViewModel.Nghanh;
using Web_API.Models;

namespace Web_API.Repositories
{
    public interface INghanhRepository
    {
        bool Add(ViewNghanh sinhVien);
        bool Update(ViewNghanh sinhVien);
        bool Delete(int id);
        Nghanh GetId(int id);
        List<Nghanh> GetAll();
    }
}
