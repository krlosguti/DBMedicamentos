using DBMedicamentos.Configuraciones;
using FluentValidation.AspNetCore;
using Permisos.Aplicacion.Interfaces;
using Permisos.Aplicacion.Servicios;
using Permisos.Dominio.Repositorios;
using Permisos.Infraestructura.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
AplicacionDbContextFactory.ConfigureAplicacionDbContext(builder.Services, builder.Configuration);

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
