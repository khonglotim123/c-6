using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;

namespace Web_Assembly.Pages.Truong
{
    public partial class UpdateTruong
    {
        [Inject] private ITruongService _nghanh { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        [Parameter]
        public int id { get; set; }
        private ViewModel.Truong.ViewTruong sv;

        protected override async Task OnInitializedAsync()
        {
            sv = await _nghanh.GetId(id);
        }
        private async Task SubmitSinhVien()
        {
            var xa = await _nghanh.Update(sv);
            _chuyen.NavigateTo("/viewtruong",true);
        }
    }
}
