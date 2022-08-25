using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;

namespace Web_Assembly.Pages.Truong
{
    public partial class CreateTruong
    {
        [Inject] private ITruongService sinhVienAPIService { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        private ViewModel.Truong.ViewTruong sv = new ViewModel.Truong.ViewTruong();        
        private async void SubmitSinhVien(EditContext context)
        {
            if (sv != null)
            {
                await sinhVienAPIService.Create(sv);
                _chuyen.NavigateTo("/viewtruong");
                await sinhVienAPIService.GetlistSV();
            }
        }
    }
}
