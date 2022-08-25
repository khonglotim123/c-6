using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Lop;

namespace Web_Assembly.Services
{
    public interface ILopService
    {
        Task<List<ViewLop>> GetlistSV();
        Task<ViewLop> GetId(int id);
        Task<ViewLop> Create(ViewLop sv);
        Task<bool> Update(ViewLop sv);
        Task<bool> Delete(int id);
    }
}
