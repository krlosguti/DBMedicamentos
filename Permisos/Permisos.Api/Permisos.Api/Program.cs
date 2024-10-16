using Common.Database.Domain.Data;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Permisos.Aplicacion.Interfaces;
using Permisos.Aplicacion.Servicios;
using Permisos.Dominio.Repositorios;
using Permisos.Infraestructura.Repositorios;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AplicacionDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddFluentValidationAutoValidation();

builder.Services.AddScoped<IModuloRepositorio, ModuloRepositorio>();
builder.Services.AddScoped<IModuloServicio, ModuloServicio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
