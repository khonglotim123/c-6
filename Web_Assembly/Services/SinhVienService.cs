using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ViewModel;

namespace Web_Assembly.Services
{
    public class SinhVienService : ISinhVienAPIService
    {
        public HttpClient _httpClient;
        public SinhVienService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<ViewSinhVienRequest> Create(ViewSinhVienRequest sv)
        {
            var alo = await _httpClient.PostAsJsonAsync("/api/SinhVien", sv);
            return sv;

        }

        public async Task<bool> Delete(int id)
        {
            var sv = await _httpClient.DeleteAsync($"/api/SinhVien/{id}");
            return sv.IsSuccessStatusCode;
        }

        public async Task<ViewSinhVienRequest> GetId(int id)
        {
            var sv = await _httpClient.GetFromJsonAsync<ViewSinhVienRequest>($"/api/SinhVien/{id}");
            return sv;
        }

        public async Task<List<ViewSinhVien>> GetlistSV()
        {
            var sv = await _httpClient.GetFromJsonAsync<List<ViewSinhVien>>("/api/SinhVien");
            return sv;
        }     


        public async Task<bool> Update(ViewSinhVienRequest sv)
        {
            var sv1 = await _httpClient.PutAsJsonAsync("/api/SinhVien",sv);
            return sv1.IsSuccessStatusCode;
        }

        
    }
}
