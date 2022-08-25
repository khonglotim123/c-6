using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;

namespace Web_Assembly.Pages.Lop
{
    public partial class CreateLop
    {
        [Inject] private ILopService sinhVienAPIService { get; set; }
        [Inject] private ITruongService _truong { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        private ViewModel.Lop.ViewLop sv = new ViewModel.Lop.ViewLop();
        private List<ViewModel.Truong.ViewTruong> lsttr = new List<ViewModel.Truong.ViewTruong>();
        protected override async Task OnInitializedAsync()
        {
            lsttr = await _truong.GetlistSV();
        }
        private async void SubmitSinhVien(EditContext context)
        {
            if (sv != null)
            {
                await sinhVienAPIService.Create(sv);
                _chuyen.NavigateTo("/viewlop");
                await sinhVienAPIService.GetlistSV();
            }
        }
    }
}
