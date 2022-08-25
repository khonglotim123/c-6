using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ViewModel.Truong;

namespace Web_Assembly.Services
{
    public class TruongService:ITruongService
    {
        public HttpClient _httpClient;
        public TruongService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ViewTruong> Create(ViewTruong sv)
        {
            var alo = await _httpClient.PostAsJsonAsync("/api/Truong", sv);
            return sv;
        }

        public async Task<bool> Delete(int id)
        {
            var sv = await _httpClient.DeleteAsync($"/api/Truong/{id}");
            return true;
        }

        public async Task<ViewTruong> GetId(int id)
        {
            var sv = await _httpClient.GetFromJsonAsync<ViewTruong>($"/api/Truong/{id}");
            return sv;
        }

        public async Task<List<ViewTruong>> GetlistSV()
        {
            var sv = await _httpClient.GetFromJsonAsync<List<ViewTruong>>("/api/Truong");
            return sv;
        }

        public async Task<bool> Update(ViewTruong sv)
        {
            var sv1 = await _httpClient.PutAsJsonAsync("/api/Truong", sv);
            return true;
        }
    }
}
