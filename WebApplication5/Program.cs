using Microsoft.EntityFrameworkCore;
using WebApplication5.Models;

var builder = WebApplication.CreateBuilder(args);

string connection = "Server = (localdb)\\MSSQLLocalDB;Database = userstoredb1;Trusted_Connection=true";
builder.Services.AddDbContext<UsersContext>(options => options.UseSqlServer(connection));

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.MapDefaultControllerRoute();

app.Run();