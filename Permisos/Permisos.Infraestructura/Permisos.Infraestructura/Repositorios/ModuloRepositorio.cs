using Common.Database.Domain.Data;
using Common.Database.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Permisos.Dominio.Repositorios;

namespace Permisos.Infraestructura.Repositorios
{
    public class ModuloRepositorio(AplicacionDbContext contexto) : IModuloRepositorio
    {
        private readonly AplicacionDbContext _contexto = contexto;
        public async Task<IEnumerable<Modulo>> ConsultarTodosAsync()
        {
            return await _contexto.Modulos.ToListAsync();
        }
        public async Task<Modulo> ConsultarPorIdAsync(string id)
        {
            return await _contexto.Modulos.FindAsync(id);
        }
        public async Task<Modulo> AdicionarAsync(Modulo modulo)
        {
            _contexto.Modulos.Add(modulo);
            await _contexto.SaveChangesAsync();
            return modulo;
        }
        public async Task ActualizarAsync(Modulo modulo)
        {
            _contexto.Modulos.Update(modulo);
            await _contexto.SaveChangesAsync();
        }
        public async Task EliminarAsync(string id)
        {
            var modulo = await ConsultarPorIdAsync(id);
            if (modulo == null) return;
            _contexto.Modulos.Remove(modulo);
            await _contexto.SaveChangesAsync();
        }
    }
}
