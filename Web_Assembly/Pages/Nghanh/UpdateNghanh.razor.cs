using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;

namespace Web_Assembly.Pages.Nghanh
{
    public partial class UpdateNghanh
    {
        [Inject] private INghanhService _nghanh { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        [Parameter]
        public int id { get; set; }
        private ViewModel.Nghanh.ViewNghanh sv;

        protected override async Task OnInitializedAsync()
        {
            sv = await _nghanh.GetId(id);
        }
        private async Task SubmitSinhVien()
        {
            var xa = await _nghanh.Update(sv);
            _chuyen.NavigateTo("/viewnghanh",true);
        }
    }
}
