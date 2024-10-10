using Autorizacion.Aplicacion.DTOs;
using Autorizacion.Aplicacion.Interfaces;
using Autorizacion.Dominio.Repositorios;

namespace Autorizacion.Aplicacion.Servicios
{
    public class UsuarioRolServicio(IUsuarioRolRepositorio repositorio) : IUsuarioRolServicio
    {
        private readonly IUsuarioRolRepositorio _repositorio = repositorio;

        public async Task AsignarRolAUsuarioAsync(UsuarioRolResponseDto usuarioRolDto)
        {
            await _repositorio.AsignarRolAUsuarioAsync(usuarioRolDto.UsuarioId, usuarioRolDto.RolId);
        }

        public async Task EliminarRolDeUsuarioAsync(UsuarioRolResponseDto usuarioRolDto)
        {
            await _repositorio.EliminarRolDeUsuarioAsync(usuarioRolDto.UsuarioId, usuarioRolDto.RolId);
        }
    }
}
