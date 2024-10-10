using Autorizacion.Aplicacion.DTOs;
using Autorizacion.Aplicacion.Exceptions;
using Autorizacion.Aplicacion.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Autorizacion.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuariosController(IUsuarioServicio servicio) : ControllerBase
    {
        private readonly IUsuarioServicio _servicio = servicio;

        [HttpGet]
        public async Task<IActionResult> ConsultarUsuarios()
        {
            return Ok(await _servicio.ConsultarUsuariosAsync());
        }

        [HttpGet("rol/{rolId}")]
        public async Task<IActionResult> ConsultarUsuariosPorRol(string rolId)
        {
            return Ok(await _servicio.ConsultarUsuariosPorRolAsync(rolId));
        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> ConsultarUsuarioPorId(string id)
        {
            return Ok(await _servicio.ConsultarUsuarioPorIdAsync(id));
        }

        [HttpGet("nombre/{nombre}")]
        public async Task<IActionResult> ConsultarUsuarioPorNombre(string nombre)
        {
            return Ok(await _servicio.ConsultarUsuarioPorNombreusuarioAsync(nombre));
        }

        [HttpGet("email/{email}")]
        public async Task<IActionResult> ConsultarUsuarioPorEmail(string email)
        {
            return Ok(await _servicio.ConsultarUsuarioPorEmailAsync(email));
        }

        [HttpGet("identificacion/{identificacion}")]
        public async Task<IActionResult> ConsultarUsuarioPorIdentificacion(string identificacion)
        {
            return Ok(await _servicio.ConsultarUsuarioPorIdentificacionAsync(identificacion));
        }

        [HttpPost]
        public async Task<IActionResult> Adicionar(UsuarioRequestDto itemDto)
        {
            var nuevoItem = await _servicio.AdicionarUsuarioAsync(itemDto);
            return CreatedAtAction(nameof(ConsultarUsuarioPorId), new { id = nuevoItem.Id }, nuevoItem);
        }

        [HttpPut]
        public async Task<IActionResult> ActualizarUsuario(UsuarioResponseDto itemDto)
        {
            await _servicio.ActualizarUsuarioAsync(itemDto);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> EliminarUsuario(string id)
        {
            var item = await _servicio.ConsultarUsuarioPorIdAsync(id);
            if (item == null)
                throw new NotFoundException($"No se encontró un usuario con el Id '{id}'.");

            await _servicio.EliminarUsuarioAsync(id);
            return NoContent();
        }
    }
}
