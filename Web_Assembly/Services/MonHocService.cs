using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ViewModel.MonHoc;

namespace Web_Assembly.Services
{
    public class MonHocService:IMonHocService
    {
        public HttpClient _httpClient;
        public MonHocService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ViewMonHoc> Create(ViewMonHoc sv)
        {
            var alo = await _httpClient.PostAsJsonAsync("/api/MonHoc", sv);
            return sv;
        }

        public async Task<bool> Delete(int id)
        {
            var sv = await _httpClient.DeleteAsync($"/api/MonHoc/{id}");
            return true;
        }

        public async Task<ViewMonHoc> GetId(int id)
        {
            var sv = await _httpClient.GetFromJsonAsync<ViewMonHoc>($"/api/MonHoc/{id}");
            return sv;
        }

        public async Task<List<ViewMonHoc>> GetlistSV()
        {
            var sv = await _httpClient.GetFromJsonAsync<List<ViewMonHoc>>("/api/MonHoc");
            return sv;
        }

        public async Task<bool> Update(ViewMonHoc sv)
        {
            var sv1 = await _httpClient.PutAsJsonAsync("/api/MonHoc", sv);
            return true;
        }
    }
}
