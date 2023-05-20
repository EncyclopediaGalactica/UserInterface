using Fluxor;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.Fast.Components.FluentUI;
using UserInterface.Components;
using UserInterface.Data;
using UserInterface.Services;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.AddFluentUIComponents(o => o.HostingModel = BlazorHostingModel.Server);
builder.Services.AddFluxor(o =>
{
    o.ScanAssemblies(typeof(Program).Assembly);
    o.UseReduxDevTools();
});
builder.Services.AddScoped<EGModuleSelector>();
builder.Services.AddScoped<EGNavigation>();
builder.Services.AddScoped<ICoreService, CoreService>();
WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
// IServiceProvider serviceProvider = builder.Services.BuildServiceProvider();
// serviceProvider.GetRequiredService<EGModuleSelector>();
// serviceProvider.GetRequiredService<EGNavigation>();

app.Run();