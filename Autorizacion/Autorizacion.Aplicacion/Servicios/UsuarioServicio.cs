using Autorizacion.Aplicacion.DTOs;
using Autorizacion.Aplicacion.Interfaces;
using Autorizacion.Dominio.Repositorios;
using Common.Database.Domain.Models;
using Mapster;

namespace Autorizacion.Aplicacion.Servicios
{
    public class UsuarioServicio(IUsuarioRepositorio repositorio) : IUsuarioServicio
    {
        private readonly IUsuarioRepositorio _repositorio = repositorio;

        public async Task<IEnumerable<UsuarioResponseDto>> ConsultarUsuariosAsync()
        {
            var usuarios = await _repositorio.ConsultarTodosAsync();
            return usuarios.Adapt<IEnumerable<UsuarioResponseDto>>();
        }

        public async Task<UsuarioResponseDto> ConsultarUsuarioPorEmailAsync(string email)
        {
            var usuario = await _repositorio.ConsultarPorEmailAsync(email);
            return usuario.Adapt<UsuarioResponseDto>();
        }

        public async Task<UsuarioResponseDto> ConsultarUsuarioPorIdAsync(string id)
        {
            var usuario = await _repositorio.ConsultarPorIdAsync(id);
            return usuario.Adapt<UsuarioResponseDto>();
        }

        public async Task<UsuarioResponseDto> ConsultarUsuarioPorIdentificacionAsync(string identificacion)
        {
            var usuario = await _repositorio.ConsultarPorIdentificacionAsync(identificacion);
            return usuario.Adapt<UsuarioResponseDto>();
        }

        public async Task<UsuarioResponseDto> ConsultarUsuarioPorNombreusuarioAsync(string nombreUsuario)
        {
            var usuario = await _repositorio.ConsultarPorNombreusuarioAsync(nombreUsuario);
            return usuario.Adapt<UsuarioResponseDto>();
        }

        public async Task<IEnumerable<UsuarioResponseDto>> ConsultarUsuariosPorRolAsync(string rolId)
        {
            var usuarios = await _repositorio.ConsultarUsuariosPorRolAsync(rolId);
            return usuarios.Adapt<IEnumerable<UsuarioResponseDto>>();
        }

        public async Task<UsuarioResponseDto> AdicionarUsuarioAsync(UsuarioRequestDto item)
        {
            var usuario = item.Adapt<Usuario>();
            var nuevoUsuario = await _repositorio.AdicionarAsync(usuario);
            return nuevoUsuario.Adapt<UsuarioResponseDto>();
        }

        public async Task ActualizarUsuarioAsync(UsuarioResponseDto item)
        {
            var usuario = item.Adapt<Usuario>();
            await _repositorio.ActualizarAsync(usuario);
        }

        public async Task EliminarUsuarioAsync(string id)
        {
            await _repositorio.EliminarAsync(id);
        }
    }
}
