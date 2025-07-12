using BlazorApp1;
using MudBlazor.Services;
using BlazorApp1.Libraries.Products;
using BlazorApp1.Libraries.ShoppingCart;
using BlazorApp1.Libraries.Storage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices();

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<IStorageServices, StorageServices>();
builder.Services.AddTransient<IProductServices ,  ProductServices>();
builder.Services.AddTransient<IShoppingCartService, ShoppingCartService>();


await builder.Build().RunAsync();
