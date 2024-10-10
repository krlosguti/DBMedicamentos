using Autorizacion.Dominio.Repositorios;
using Common.Database.Domain.Data;
using Common.Database.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Autorizacion.Infraestructura.Repositorios
{
    public class RolRepositorio(AplicacionDbContext contexto) : IRolRepositorio
    {
        private readonly AplicacionDbContext _contexto = contexto;

        public async Task<IEnumerable<Rol>> ConsultarTodosAsync()
        {
            return await _contexto.Roles.ToListAsync();
        }

        public async Task<Rol> ConsultarPorIdAsync(string id)
        {
            return await _contexto.Roles.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Rol> ConsultarPorNombreAsync(string nombreRol)
        {
            return await _contexto.Roles.FirstOrDefaultAsync(x => x.Nombre == nombreRol);
        }

        public async Task<Rol> AdicionarAsync(Rol item)
        {
            _contexto.Roles.Add(item);
            await _contexto.SaveChangesAsync();
            return item;
        }

        public async Task ActualizarAsync(Rol item)
        {
            _contexto.Roles.Update(item);
            await _contexto.SaveChangesAsync();
        }

        public async Task EliminarAsync(string id)
        {
            var item = await ConsultarPorIdAsync(id);
            if (item == null) return;
            _contexto.Roles.Remove(item);
            await _contexto.SaveChangesAsync();
        }
    }
}
