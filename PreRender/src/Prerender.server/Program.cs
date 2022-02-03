using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Prerender.shared;
using Prerender.server;
// https://andrewlock.net/enabling-prerendering-for-blazor-webassembly-apps/
// https://jonhilton.net/blazor-wasm-prerendering-missing-http-client/
//https://docs.microsoft.com/en-us/aspnet/core/mvc/views/tag-helpers/built-in/persist-component-state?view=aspnetcore-6.0
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddRazorPages();
builder.Services.AddSingleton<IWeatherforecastService, WeatherForecastService>();

var app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseStatusCodePages();
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapRazorPages(); 
    endpoints.MapFallbackToPage("/_Host"); 
});

app.Run();
