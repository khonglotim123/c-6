using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel;

namespace Web_Assembly.Services
{
    public interface ISinhVienAPIService
    {
        Task<List<ViewSinhVien>> GetlistSV();
        Task<ViewSinhVienRequest> GetId(int id);
        Task<ViewSinhVienRequest> Create(ViewSinhVienRequest sv);
        Task<bool> Update(ViewSinhVienRequest sv);
        Task<bool> Delete(int id);

    }
}
