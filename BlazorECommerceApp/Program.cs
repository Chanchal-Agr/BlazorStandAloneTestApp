using BlazorECommerceApp;
using BlazorECommerceApp.Interfaces;
using BlazorECommerceApp.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7035/api/")
});
builder.Services.AddScoped<IUserService, UserService>();

await builder.Build().RunAsync();
