using Microsoft.EntityFrameworkCore;
using OnlieShop.Infra.EF;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ShopContext>(options =>
    options.UseSqlServer("Server=.;Database=Online_Shop_Final1;Trusted_Connection=True;MultipleActiveResultSets=true"));



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
