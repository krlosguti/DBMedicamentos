using Autorizacion.Aplicacion.DTOs;
using Autorizacion.Aplicacion.Interfaces;
using Autorizacion.Dominio.Repositorios;
using Common.Database.Domain.Models;
using Mapster;

namespace Autorizacion.Aplicacion.Servicios
{
    public class RolServicio(IRolRepositorio rolRepositorio) : IRolServicio
    {
        private readonly IRolRepositorio _rolRepositorio = rolRepositorio;

        public async Task<IEnumerable<RolResponseDto>> ConsultarRolesAsync()
        {
            var roles = await _rolRepositorio.ConsultarTodosAsync();
            return roles.Adapt<IEnumerable<RolResponseDto>>();
        }

        public async Task<RolResponseDto> ConsultarRolPorIdAsync(string id)
        {
            var rol = await _rolRepositorio.ConsultarPorIdAsync(id);
            return rol.Adapt<RolResponseDto>();
        }

        public async Task<RolResponseDto> ConsultarRolPorNombreAsync(string nombreRol)
        {
            var rol = await _rolRepositorio.ConsultarPorNombreAsync(nombreRol);
            return rol.Adapt<RolResponseDto>();
        }

        public async Task<RolResponseDto> AdicionarRolAsync(RolRequestDto item)
        {
            var rol = item.Adapt<Rol>();
            var nuevoRol = await _rolRepositorio.AdicionarAsync(rol);
            return nuevoRol.Adapt<RolResponseDto>();
        }

        public async Task ActualizarRolAsync(RolResponseDto item)
        {
            var rol = item.Adapt<Rol>();
            await _rolRepositorio.ActualizarAsync(rol);
        }

        public async Task EliminarRolAsync(string id)
        {
            await _rolRepositorio.EliminarAsync(id);
        }
    }
}
