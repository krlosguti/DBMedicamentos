using Autorizacion.Aplicacion.DTOs;

namespace Autorizacion.Aplicacion.Interfaces
{
    public interface IUsuarioRolServicio
    {
        Task AsignarRolAUsuarioAsync(UsuarioRolResponseDto usuarioRolDto);
        Task EliminarRolDeUsuarioAsync(UsuarioRolResponseDto usuarioRolDto);
    }
}
