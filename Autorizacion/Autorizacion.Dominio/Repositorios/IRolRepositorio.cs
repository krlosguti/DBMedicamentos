using Common.Database.Domain.Models;

namespace Autorizacion.Dominio.Repositorios
{
    public interface IRolRepositorio
    {
        Task<IEnumerable<Rol>> ConsultarTodosAsync();
        Task<Rol> ConsultarPorIdAsync(string id);
        Task<Rol> ConsultarPorNombreAsync(string nombreRol);
        Task<Rol> AdicionarAsync(Rol item);
        Task ActualizarAsync(Rol item);
        Task EliminarAsync(string id);
    }
}
