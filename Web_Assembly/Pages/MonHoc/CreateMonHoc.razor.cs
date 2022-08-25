using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;

namespace Web_Assembly.Pages.MonHoc
{
    public partial class CreateMonHoc
    {
        [Inject] private IMonHocService sinhVienAPIService { get; set; }
        [Inject] private INghanhService _truong { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        private ViewModel.MonHoc.ViewMonHoc sv = new ViewModel.MonHoc.ViewMonHoc();
        private List<ViewModel.Nghanh.ViewNghanh> lsttr = new List<ViewModel.Nghanh.ViewNghanh>();
        protected override async Task OnInitializedAsync()
        {
            lsttr = await _truong.GetlistSV();
        }
        private async void SubmitSinhVien(EditContext context)
        {
            if (sv != null)
            {
                await sinhVienAPIService.Create(sv);
                _chuyen.NavigateTo("/viewmonhoc");
                await sinhVienAPIService.GetlistSV();
            }
        }
    }
}
