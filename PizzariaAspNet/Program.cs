using Microsoft.EntityFrameworkCore;
using PizzariaAspNet.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

//builder.Services.AddDbContext<AppDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
void ConfigureServices(WebApplicationBuilder builder)
{
    builder.Services.AddDbContext<AppDbContext>();
}

    var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
