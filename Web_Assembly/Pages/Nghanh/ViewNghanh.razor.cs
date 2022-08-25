using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;
using System.Threading.Tasks;

namespace Web_Assembly.Pages.Nghanh
{
    public partial class ViewNghanh
    {
        [Inject] private INghanhService _nghanh { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        private List<ViewModel.Nghanh.ViewNghanh> lstsv;
        private string seach;
        protected override async Task OnInitializedAsync()
        {
            lstsv = await _nghanh.GetlistSV();
        }
        private void Themmoi()
        {
            _chuyen.NavigateTo("/createnghanh");
        }
        private async void Timkiem(string alo)
        {
            if (alo == null)
            {
                lstsv = await _nghanh.GetlistSV();
            }
            else if (alo != null)
            {
                lstsv = await _nghanh.GetlistSV();
                lstsv = lstsv.Where(c => c.TenNghanh.ToLower().StartsWith(alo)).ToList();
               

            }

        }
        private void Sua(int id)
        {
            _chuyen.NavigateTo($"/updatenghanh/{id}");
        }
        private async void Xoa(int id)
        {
            await _nghanh.Delete(id);
            //lstsv = await _nghanh.GetlistSV();
            //_chuyen.NavigateTo("/viewnghanh");
            _chuyen.NavigateTo("viewnghanh",true);
        }
    }
}
