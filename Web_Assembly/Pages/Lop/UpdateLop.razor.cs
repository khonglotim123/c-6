using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;

namespace Web_Assembly.Pages.Lop
{
    public partial class UpdateLop
    {
        [Inject] private ILopService _nghanh { get; set; }
        [Inject] private ITruongService _truong { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        [Parameter]
        public int id { get; set; }
        private ViewModel.Lop.ViewLop sv;
        private List<ViewModel.Truong.ViewTruong> lsttr = new List<ViewModel.Truong.ViewTruong>();

        protected override async Task OnInitializedAsync()
        {
            sv = await _nghanh.GetId(id);
            lsttr = await _truong.GetlistSV();
        }
        private async Task SubmitSinhVien()
        {
            var xa = await _nghanh.Update(sv);
            _chuyen.NavigateTo("/viewlop", true);
        }
    }
}
