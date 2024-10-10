using Autorizacion.Aplicacion.DTOs;
using Autorizacion.Aplicacion.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Autorizacion.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UsuariosRolController(IUsuarioRolServicio servicio) : ControllerBase
    {
        private readonly IUsuarioRolServicio _servicio = servicio;

        [HttpPost]
        public async Task<IActionResult> Adicionar(UsuarioRolResponseDto itemDto)
        {
            await _servicio.AsignarRolAUsuarioAsync(itemDto);
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> EliminarRoldeusuario(UsuarioRolResponseDto itemDto)
        {
            await _servicio.EliminarRolDeUsuarioAsync(itemDto);
            return NoContent();
        }
    }
}
