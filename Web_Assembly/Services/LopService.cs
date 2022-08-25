using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ViewModel.Lop;

namespace Web_Assembly.Services
{
    public class LopService:ILopService
    {
        public HttpClient _httpClient;
        public LopService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ViewLop> Create(ViewLop sv)
        {
            var alo = await _httpClient.PostAsJsonAsync("/api/Lop", sv);
            return sv;
        }

        public async Task<bool> Delete(int id)
        {
            var sv = await _httpClient.DeleteAsync($"/api/Lop/{id}");
            return true;
        }

        public async Task<ViewLop> GetId(int id)
        {
            var sv = await _httpClient.GetFromJsonAsync<ViewLop>($"/api/Lop/{id}");
            return sv;
        }

        public async Task<List<ViewLop>> GetlistSV()
        {
            var sv = await _httpClient.GetFromJsonAsync<List<ViewLop>>("/api/Lop");
            return sv;
        }

        public async Task<bool> Update(ViewLop sv)
        {
            var sv1 = await _httpClient.PutAsJsonAsync("/api/Lop", sv);
            return true;
        }
    }
}
