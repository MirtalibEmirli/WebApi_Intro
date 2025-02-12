using Microsoft.EntityFrameworkCore;
using Web_Intro.Context;
using Web_Intro.Repositories.Abstracts;
using Web_Intro.Repositories.Concretes;
using Web_Intro.Services.Abstracts;
using Web_Intro.Services.Concretes;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
var conn = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<EcommerceDbContext>(opt=>opt.UseSqlServer(conn));

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IcustomerService, CustomerService>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<IShipperRepository, ShipperRepository>();
builder.Services.AddScoped<IShipperService, ShipperService>();
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
