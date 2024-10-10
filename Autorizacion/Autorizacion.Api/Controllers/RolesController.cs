using Autorizacion.Aplicacion.DTOs;
using Autorizacion.Aplicacion.Exceptions;
using Autorizacion.Aplicacion.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Autorizacion.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RolesController(IRolServicio servicio) : ControllerBase
    {
        private readonly IRolServicio _servicio = servicio;

        [HttpGet]
        public async Task<IActionResult> ConsultarRoles()
        {
            return Ok(await _servicio.ConsultarRolesAsync());
        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> ConsultarRolPorId(string id)
        {
            return Ok(await _servicio.ConsultarRolPorIdAsync(id));
        }

        [HttpGet("nombre/{nombre}")]
        public async Task<IActionResult> ConsultarRolPorNombre(string nombre)
        {
            return Ok(await _servicio.ConsultarRolPorNombreAsync(nombre));
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar(RolRequestDto itemDto)
        {
            var nuevoItem = await _servicio.AdicionarRolAsync(itemDto);
            return CreatedAtAction(nameof(ConsultarRolPorId), new { id = nuevoItem.Id }, nuevoItem);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarRol(RolResponseDto itemDto)
        {
            await _servicio.ActualizarRolAsync(itemDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarRol(string id)
        {
            var item = await _servicio.ConsultarRolPorIdAsync(id);
            if (item == null)
                throw new NotFoundException($"No se encontró un rol con el Id '{id}'.");

            await _servicio.EliminarRolAsync(id);
            return NoContent();
        }
    }
}
