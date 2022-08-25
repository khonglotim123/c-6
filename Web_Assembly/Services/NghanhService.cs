using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ViewModel.Nghanh;

namespace Web_Assembly.Services
{
    public class NghanhService : INghanhService
    {
        public HttpClient _httpClient;
        public NghanhService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<ViewNghanh> Create(ViewNghanh sv)
        {
            var alo = await _httpClient.PostAsJsonAsync("/api/Nghanh", sv);
            return sv;
        }

        public async Task<bool> Delete(int id)
        {
            var sv = await _httpClient.DeleteAsync($"/api/Nghanh/{id}");
            return true;
        }

        public async Task<ViewNghanh> GetId(int id)
        {
            var sv = await _httpClient.GetFromJsonAsync<ViewNghanh>($"/api/Nghanh/{id}");
            return sv;
        }

        public async Task<List<ViewNghanh>> GetlistSV()
        {
            var sv = await _httpClient.GetFromJsonAsync<List<ViewNghanh>>("/api/Nghanh");
            return sv;
        }

        public async Task<bool> Update(ViewNghanh sv)
        {
            var sv1 = await _httpClient.PutAsJsonAsync("/api/Nghanh", sv);
            return true;
        }
    }
}
