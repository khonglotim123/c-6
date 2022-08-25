using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;

namespace Web_Assembly.Pages.Lop
{
    public partial class ViewLop
    {
        [Inject] private ILopService _nghanh { get; set; }
        [Inject] private ITruongService _truong { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        private List<ViewModel.Lop.ViewLop> lstsv;
        private string seach;
        private List<ViewModel.Truong.ViewTruong> lsttr = new List<ViewModel.Truong.ViewTruong>();
        protected override async Task OnInitializedAsync()
        {
            lstsv = await _nghanh.GetlistSV();
            lsttr = await _truong.GetlistSV();
        }
        private void Themmoi()
        {
            _chuyen.NavigateTo("/createlop");
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
                lstsv = lstsv.Where(c => c.TenLop.ToLower().StartsWith(alo)).ToList();


            }

        }
        private void Sua(int id)
        {
            _chuyen.NavigateTo($"/updatelop/{id}");
        }
        private async void Xoa(int id)
        {
            await _nghanh.Delete(id);
            //lstsv = await _nghanh.GetlistSV();
            //_chuyen.NavigateTo("/viewnghanh");
            _chuyen.NavigateTo("viewlop", true);
        }
    }
}
