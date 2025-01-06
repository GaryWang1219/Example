using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using WebAPIDatalayer.Models;
using WebAPIDatalayer.Repoitorys;
using WebAPIServices;
using WebAPIServices.Interface;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IDbConnection>(db => new SqlConnection(config.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<IRepoitory<Customers>, CustomersRepoitory>();
builder.Services.AddScoped<ICustomersService, CustomersService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
