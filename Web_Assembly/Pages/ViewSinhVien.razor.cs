using Microsoft.AspNetCore.Components;
using Slack.Webhooks.Elements;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;
namespace Web_Assembly.Pages
{
    public partial class ViewSinhVien
    {
        [Inject] private ISinhVienAPIService sinhVienAPIService { get; set; }
        [Inject] private ILopService _lop { get; set; }
        [Inject] private INghanhService _nghanh { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        
        private  List<ViewModel.ViewSinhVien> lstsv;        
        private  List<ViewModel.Lop.ViewLop> lstlop;        
        private  List<ViewModel.Nghanh.ViewNghanh> lstnghanh;
        private string seach;
        protected override async Task OnInitializedAsync()
        {
            lstsv = await sinhVienAPIService.GetlistSV();
            lstlop = await _lop.GetlistSV();
            lstnghanh = await _nghanh.GetlistSV();
        }
        private void Themmoi()
        {
            _chuyen.NavigateTo("/createsinhvien");
        }
        private async void Timkiem(string alo)
        {
            if (alo==null)
            {
                lstsv = await sinhVienAPIService.GetlistSV();
            }
            else if (alo!=null)
            {
                lstsv = await sinhVienAPIService.GetlistSV();
                lstsv =  lstsv.Where(c => c.Ten.ToLower().StartsWith(alo)).ToList();
            }         
                       
        }
        private void Sua(int id)
        {
            _chuyen.NavigateTo($"/updatesinhvien/{id}");
        }
        private async void Xoa(int id)
        {
            await sinhVienAPIService.Delete(id);            
            //_chuyen.NavigateTo("/viewsinhvien");
            _chuyen.NavigateTo("viewsinhvien", true);
        }
    }
}
