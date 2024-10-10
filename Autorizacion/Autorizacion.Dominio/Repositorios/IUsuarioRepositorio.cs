using Common.Database.Domain.Models;

namespace Autorizacion.Dominio.Repositorios
{
    public interface IUsuarioRepositorio
    {
        Task<IEnumerable<Usuario>> ConsultarTodosAsync();
        Task<IEnumerable<Usuario>> ConsultarUsuariosPorRolAsync(string rolId);
        Task<Usuario> ConsultarPorIdAsync(string id);
        Task<Usuario> ConsultarPorNombreusuarioAsync(string nombreUsuario);
        Task<Usuario> ConsultarPorEmailAsync(string email);
        Task<Usuario> ConsultarPorIdentificacionAsync(string identificacion);
        Task<Usuario> AdicionarAsync(Usuario item);
        Task ActualizarAsync(Usuario item);
        Task EliminarAsync(string id);
    }
}
