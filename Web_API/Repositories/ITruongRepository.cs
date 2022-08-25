using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Truong;
using Web_API.Models;

namespace Web_API.Repositories
{
    public interface ITruongRepository
    {
        bool Add(ViewTruong sinhVien);
        bool Update(ViewTruong sinhVien);
        bool Delete(int id);
        Truong GetId(int id);
        List<Truong> GetAll();
    }
}
