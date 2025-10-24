using Microsoft.EntityFrameworkCore;
using LePhamTheVu_231220962_de01.Models;
using System;
using LePhamTheVu_231220962_de01.Models.ComputerDBModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<lptvComputerDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("LePhamTheVuComputerConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=LPTVHome}/{action=lptvIndex}/{id?}");

app.Run();
