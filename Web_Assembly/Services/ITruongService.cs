using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModel.Truong;

namespace Web_Assembly.Services
{
    public interface ITruongService
    {
        Task<List<ViewTruong>> GetlistSV();
        Task<ViewTruong> GetId(int id);
        Task<ViewTruong> Create(ViewTruong sv);
        Task<bool> Update(ViewTruong sv);
        Task<bool> Delete(int id);
    }
}
