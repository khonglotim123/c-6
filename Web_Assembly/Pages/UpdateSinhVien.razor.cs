using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;
using ViewModel;

namespace Web_Assembly.Pages
{
    public partial class UpdateSinhVien
    {
       
        [Inject] private ISinhVienAPIService sinhVienAPIService { get; set; }
        [Inject] private ILopService _lop { get; set; }
        [Inject] private INghanhService _nghanh { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        [Parameter]
        public int id { get; set; }
        private ViewModel.ViewSinhVienRequest sv;
        private List<ViewModel.Lop.ViewLop> lstlop = new List<ViewModel.Lop.ViewLop>();
        private List<ViewModel.Nghanh.ViewNghanh> lstnghanh = new List<ViewModel.Nghanh.ViewNghanh>();

        protected override async Task OnInitializedAsync()
        {
            sv = await sinhVienAPIService.GetId(id);
            lstlop = await _lop.GetlistSV();
            lstnghanh = await _nghanh.GetlistSV();
        }     
        private async Task SubmitSinhVien()
        {
            var xa = await sinhVienAPIService.Update(sv);
            _chuyen.NavigateTo("/viewsinhvien",true);
        }
    }
}
