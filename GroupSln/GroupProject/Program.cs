var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

// app.MapGet("/", () => "This is the project in Asp.Net og DP er ikki ein pleb!");

app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();