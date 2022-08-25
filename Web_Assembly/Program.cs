using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Web_Assembly.Services;

namespace Web_Assembly
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddTransient<ISinhVienAPIService, SinhVienService>();
            builder.Services.AddTransient<INghanhService, NghanhService>();
            builder.Services.AddTransient<ILopService, LopService>();
            builder.Services.AddTransient<ITruongService, TruongService>();
            builder.Services.AddTransient<IMonHocService, MonHocService>();
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001") });

            await builder.Build().RunAsync();
        }
    }
}
