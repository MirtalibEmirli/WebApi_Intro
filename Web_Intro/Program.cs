using Microsoft.EntityFrameworkCore;
using Web_Intro.Context;
using Web_Intro.Repositories;
using Web_Intro.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();
var conn = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<EcommerceDbContext>(opt=>opt.UseSqlServer(conn));

builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddScoped<IcustomerService, CustomerService>();
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
