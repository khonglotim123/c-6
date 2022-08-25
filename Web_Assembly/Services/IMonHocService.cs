using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.MonHoc;

namespace Web_Assembly.Services
{
    public interface IMonHocService
    {
        Task<List<ViewMonHoc>> GetlistSV();
        Task<ViewMonHoc> GetId(int id);
        Task<ViewMonHoc> Create(ViewMonHoc sv);
        Task<bool> Update(ViewMonHoc sv);
        Task<bool> Delete(int id);
    }
}
