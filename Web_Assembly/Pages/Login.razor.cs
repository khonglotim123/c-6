using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_Assembly.Services;

namespace Web_Assembly.Pages
{
    public partial class Login 
    {
        [Inject] private ISinhVienAPIService _sv { get; set; }
        [Inject] private NavigationManager _chuyen { get; set; }
        [Inject] private ILocalStorageService _localStorage { get; set; }
        private List<ViewModel.ViewSinhVien> lstsv = new List<ViewModel.ViewSinhVien>();
        private ViewModel.ViewSinhVien sv = new ViewModel.ViewSinhVien();
        public static ViewModel.ViewSinhVien sv1 = new ViewModel.ViewSinhVien();
        private string loi;
        
        protected override async Task OnInitializedAsync()
        {
            lstsv = await _sv.GetlistSV();
        }
        public static void GoiKhapNoi()
        {
            sv1 = null;
        }
        private  void DangNhap()
        {
            foreach (var x in lstsv)
            {
                if (sv.Email==x.Email && sv.PassWord==x.PassWord)
                {
                    //await _localStorage.SetItemAsync<ViewModel.ViewSinhVien>("login", x);
                    sv1 = x;
                    //Shared.NavMenu.Goi(x);
                    //Shared.MainLayout.Goidn(x);
                    _chuyen.NavigateTo("index");                   
                }
                else
                {
                    loi = "Tài khoản mật khẩu không chính xác";
                }
            }
        }
    }
}
