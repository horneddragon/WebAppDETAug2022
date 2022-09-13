using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCDemo.Data;
using Microsoft.Data.Sqlite;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVCDemoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVCDemoContext") ?? throw new InvalidOperationException("Connection string 'MVCDemoContext' not found.")));

builder.Services.AddSqlServer<PizzaContext>("Data Source=MVCDemo.db");

// Add services to the container.
builder.Services.AddControllersWithViews();
//builder.Services.AddSqlite<PizzaContext>("Data Source=MVCDemo.db");

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
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
