using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Nghanh;

namespace Web_Assembly.Services
{
    public interface INghanhService
    {
        Task<List<ViewNghanh>> GetlistSV();
        Task<ViewNghanh> GetId(int id);
        Task<ViewNghanh> Create(ViewNghanh sv);
        Task<bool> Update(ViewNghanh sv);
        Task<bool> Delete(int id);
    }
}
