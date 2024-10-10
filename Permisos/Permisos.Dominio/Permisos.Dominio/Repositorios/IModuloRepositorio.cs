using Common.Database.Domain.Models;

namespace Permisos.Dominio.Repositorios
{
    public interface IModuloRepositorio
    {
        Task<IEnumerable<Modulo>> ConsultarTodosAsync();
        Task<Modulo> ConsultarPorIdAsync(string id);
        Task<Modulo> AdicionarAsync(Modulo modulo);
        Task ActualizarAsync(Modulo modulo);
        Task EliminarAsync(string id);
    }
}
