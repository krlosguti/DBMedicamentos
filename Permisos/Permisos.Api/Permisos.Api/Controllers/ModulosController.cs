using DBMedicamentos.Models.Permisos;
using Microsoft.AspNetCore.Mvc;
using Permisos.Aplicacion.DTOs;
using Permisos.Aplicacion.Excepciones;
using Permisos.Aplicacion.Interfaces;

namespace Permisos.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ModulosController(IModuloServicio servicio) : ControllerBase
    {
        private readonly IModuloServicio _servicio = servicio;

        [HttpGet]
        public async Task<IActionResult> ConsultarModulos()
        {
            return Ok(await _servicio.ConsultarModulosAsync());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ConsultarModuloPorId(string id)
        {
            var modulo = await _servicio.ConsultarModuloPorIdAsync(id);
            if (modulo == null)
                throw new NotFoundException($"No se encontró un módulo con el Id '{id}'.");

            return Ok(modulo);
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar(ModuloDto moduloDto)
        {
            var nuevoModulo = await _servicio.AdicionarModuloAsync(moduloDto);
            return CreatedAtAction(nameof(ConsultarModuloPorId), new { id = nuevoModulo.Id }, nuevoModulo);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarModulo(ModuloDto moduloDto)
        {
            await _servicio.ActualizarModuloAsync(moduloDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarModulo(string id)
        {
            var modulo = await _servicio.ConsultarModuloPorIdAsync(id);
            if (modulo == null)
                throw new NotFoundException($"No se encontró un módulo con el Id '{id}'.");

            await _servicio.EliminarModuloAsync(id);
            return NoContent();
        }
    }
}
