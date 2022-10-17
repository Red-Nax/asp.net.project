using Microsoft.EntityFrameworkCore;
using ASP_NetProject.Models;
using GroupProject.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<ToDoDbContext>(opts => {
    opts.UseSqlServer(
        builder.Configuration["ConnectionStrings:GroupProjectConnection"]);
});

builder.Services.AddScoped<IToDoRepository, EFToDoRepository>();

var app = builder.Build();

// app.MapGet("/", () => "This is the project in Asp.Net og DP er ikki ein pleb!");

app.UseStaticFiles();
app.MapDefaultControllerRoute();


SeedData.EnsurePopulated(app);

app.Run();