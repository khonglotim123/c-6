using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.MonHoc;
using Web_API.Models;

namespace Web_API.Repositories
{
    public interface IMonHocRepository
    {
        bool Add(ViewMonHoc sinhVien);
        bool Update(ViewMonHoc sinhVien);
        bool Delete(int id);
        MonHoc GetId(int id);
        List<MonHoc> GetAll();
    }
}
