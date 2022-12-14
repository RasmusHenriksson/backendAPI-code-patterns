using backendAPI.Data;
using backendAPI.Handlers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System;
using backendAPI.Factories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DataContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Sql")));
builder.Services.AddSingleton<IProductFactory, ProductFactory>();
builder.Services.AddScoped<IProductHandler, ProductHandler>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();
app.UseCors(x => x.AllowAnyMethod().AllowAnyOrigin().AllowAnyHeader());
app.UseAuthorization();
app.MapControllers();

app.Run();
