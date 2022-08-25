using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;

namespace Web_Assembly.Pages.MonHoc
{
    public partial class UpdateMonHoc
    {
        [Inject] private IMonHocService _nghanh { get; set; }
        [Inject] private INghanhService _truong { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        [Parameter]
        public int id { get; set; }
        private ViewModel.MonHoc.ViewMonHoc sv;
        private List<ViewModel.Nghanh.ViewNghanh> lsttr = new List<ViewModel.Nghanh.ViewNghanh>();

        protected override async Task OnInitializedAsync()
        {
            sv = await _nghanh.GetId(id);
            lsttr = await _truong.GetlistSV();
        }
        private async Task SubmitSinhVien()
        {
            var xa = await _nghanh.Update(sv);
            _chuyen.NavigateTo("/viewmonhoc", true);
        }
    }
}
