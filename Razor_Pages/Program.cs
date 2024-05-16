using Microsoft.EntityFrameworkCore;
using Razor_Pages.Models;

var builder = WebApplication.CreateBuilder(args);
string? connection = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationContext>(options=>options.UseSqlServer(connection));

builder.Services.AddRazorPages();
var app = builder.Build();

app.MapRazorPages();

app.Run();
