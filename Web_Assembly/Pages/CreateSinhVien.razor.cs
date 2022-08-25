using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;

namespace Web_Assembly.Pages
{
    public partial class CreateSinhVien
    {
        [Inject] private ISinhVienAPIService sinhVienAPIService { get; set; }
        [Inject] private ILopService _lop { get; set; }
        [Inject] private INghanhService _nghanh { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        private ViewModel.ViewSinhVienRequest sv = new ViewModel.ViewSinhVienRequest();
        private List<ViewModel.Lop.ViewLop> lstlop = new List<ViewModel.Lop.ViewLop>();
        private List<ViewModel.Nghanh.ViewNghanh> lstnghanh = new List<ViewModel.Nghanh.ViewNghanh>();
        protected override async Task OnInitializedAsync()
        {
            lstlop = await _lop.GetlistSV();
            lstnghanh = await _nghanh.GetlistSV();
        }
        private async void SubmitSinhVien(EditContext context)
        {
            if (sv!=null)
            {
                await sinhVienAPIService.Create(sv);
                _chuyen.NavigateTo("/viewsinhvien");
                await sinhVienAPIService.GetlistSV();
            }                     
        }
    }
}
