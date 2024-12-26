
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MySignalRCoreApp.Hubs;  // ChatHub namespace

var builder = WebApplication.CreateBuilder(args);

// service µî·Ï
builder.Services.AddRazorPages();
builder.Services.AddSignalR();

var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();

// End Point
app.MapRazorPages();
app.MapHub<ChatHub>("/chatHub");

//app.MapGet("/", () => "Hello World!");

app.Run();
