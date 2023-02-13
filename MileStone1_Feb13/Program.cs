using Microsoft.EntityFrameworkCore;
using MileStone1_Feb13.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Here we are using the CollegeLibraryContext class because it will be connect the database of the collegelibrary context, UseSqlserver so that the further 
//Configuration can be chained. AddDbcontext -the service where multiple class can be chained.
//configuration is used for application to compose & adding new configuration sources & proviers
builder.Services.AddDbContext<CollegeLibraryContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConn")));

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
