using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;

namespace Web_Assembly.Pages.MonHoc
{
    public partial class ViewMonHoc
    {
        [Inject] private IMonHocService _monhoc { get; set; }
        [Inject] private INghanhService _nghanh { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        private List<ViewModel.MonHoc.ViewMonHoc> lstsv;
        private string seach;
        private List<ViewModel.Nghanh.ViewNghanh> lsttr = new List<ViewModel.Nghanh.ViewNghanh>();
        protected override async Task OnInitializedAsync()
        {
            lstsv = await _monhoc.GetlistSV();
            lsttr = await _nghanh.GetlistSV();
        }
        private void Themmoi()
        {
            _chuyen.NavigateTo("/createmonhoc");
        }
        private async void Timkiem(string alo)
        {
            if (alo == null)
            {
                lstsv = await _monhoc.GetlistSV();
            }
            else if (alo != null)
            {
                lstsv = await _monhoc.GetlistSV();
                lstsv = lstsv.Where(c => c.TenMon.ToLower().StartsWith(alo)).ToList();


            }

        }
        private void Sua(int id)
        {
            _chuyen.NavigateTo($"/updatemonhoc/{id}");
        }
        private async void Xoa(int id)
        {
            await _nghanh.Delete(id);
            //lstsv = await _nghanh.GetlistSV();
            //_chuyen.NavigateTo("/viewnghanh");
            _chuyen.NavigateTo("viewmonhoc", true);
        }
    }
}
