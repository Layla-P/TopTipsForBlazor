Compare Index.html -> 
* Maui -> _framework/blazor.webview.js -> uses native runtime on the desktop -> more efficient, full power of .net on windows, android & iOS use mono.
* Web -> _framework/blazor.webassembly.js -> interpreted mode and lacks multithreading
Delete pages, shared and everything but index.html in the wwwroot
Rename Maui index.html to prevent naming conflict
Update mainpage.xaml with new index.html name
Reference the blazor stylesheets
Add reference to the client app
Update main.razor 
* <Router AppAssembly="@GetType().Assembly" AdditionalAssemblies="new[] {typeof(BlazorHybrid.App.Client.App).Assembly}">
* Mainlayout -> BlazorHybrid.App.Client.Shared.MainLayout

