using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;

namespace Web_Assembly.Pages.Truong
{
    public partial class ViewTruong
    {
        [Inject] private ITruongService _nghanh { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        private List<ViewModel.Truong.ViewTruong> lstsv;
        private string seach;
        protected override async Task OnInitializedAsync()
        {
            lstsv = await _nghanh.GetlistSV();
        }
        private void Themmoi()
        {
            _chuyen.NavigateTo("/createtruong");
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
                lstsv = lstsv.Where(c => c.TenTruong.ToLower().StartsWith(alo)).ToList();
            }
        }
        private void Sua(int id)
        {
            _chuyen.NavigateTo($"/updatetruong/{id}");
        }
        private async void Xoa(int id)
        {
            await _nghanh.Delete(id);
            //lstsv = await _nghanh.GetlistSV();
            //_chuyen.NavigateTo("/viewnghanh");
            _chuyen.NavigateTo("viewtruong", true);
        }
    }
}
