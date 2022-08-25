using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;
using ViewModel.Nghanh;
using Microsoft.AspNetCore.Components.Forms;

namespace Web_Assembly.Pages.Nghanh
{
    public partial class CreateNghanh
    {
        [Inject] private INghanhService sinhVienAPIService { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        private ViewModel.Nghanh.ViewNghanh sv = new ViewModel.Nghanh.ViewNghanh();
        protected override async Task OnInitializedAsync()
        {

        }
        private async void SubmitSinhVien(EditContext context)
        {
            if (sv != null)
            {
                await sinhVienAPIService.Create(sv);
                _chuyen.NavigateTo("/viewnghanh");
                await sinhVienAPIService.GetlistSV();
            }
        }
    }
}
