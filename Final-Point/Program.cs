using Microsoft.EntityFrameworkCore;
using OnlieShop.Contracts;
using OnlieShop.Infra.EF;
using OnlineShop.Contracts;
using OnlineShop.Core.ApplicationService;
using OnlineShop.Infra.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages();

builder.Services.AddDbContext<ShopContext>(options =>
    options.UseSqlServer("Server=.;Database=Online_Shop_Final1;Trusted_Connection=True;MultipleActiveResultSets=true"));

#region IOC
builder.Services.AddScoped< IProductRepository, ProductRepository>();
builder.Services.AddScoped< IProductService, ProductService>();
#endregion

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

app.MapRazorPages();


app.Run();
