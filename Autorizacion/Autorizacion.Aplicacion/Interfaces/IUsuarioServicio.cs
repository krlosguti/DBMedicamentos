using Autorizacion.Aplicacion.DTOs;

namespace Autorizacion.Aplicacion.Interfaces
{
    public interface IUsuarioServicio
    {
        Task<IEnumerable<UsuarioResponseDto>> ConsultarUsuariosAsync();
        Task<IEnumerable<UsuarioResponseDto>> ConsultarUsuariosPorRolAsync(string rolId);
        Task<UsuarioResponseDto> ConsultarUsuarioPorIdAsync(string id);
        Task<UsuarioResponseDto> ConsultarUsuarioPorNombreusuarioAsync(string nombreUsuario);
        Task<UsuarioResponseDto> ConsultarUsuarioPorEmailAsync(string email);
        Task<UsuarioResponseDto> ConsultarUsuarioPorIdentificacionAsync(string identificacion);
        Task<UsuarioResponseDto> AdicionarUsuarioAsync(UsuarioRequestDto item);
        Task ActualizarUsuarioAsync(UsuarioResponseDto item);
        Task EliminarUsuarioAsync(string id);
    }
}
