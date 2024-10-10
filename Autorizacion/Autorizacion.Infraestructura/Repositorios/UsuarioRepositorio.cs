using Autorizacion.Dominio.Repositorios;
using Common.Database.Domain.Data;
using Common.Database.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Autorizacion.Infraestructura.Repositorios
{
    public class UsuarioRepositorio(AplicacionDbContext contexto) : IUsuarioRepositorio
    {
        private readonly AplicacionDbContext _contexto = contexto;

        public async Task<IEnumerable<Usuario>> ConsultarTodosAsync()
        {
            return await _contexto.Usuarios.ToListAsync();
        }

        public async Task<Usuario> ConsultarPorEmailAsync(string email)
        {
            return await _contexto.Usuarios.FirstOrDefaultAsync(x => x.CorreoElectronico == email);
        }

        public async Task<Usuario> ConsultarPorIdAsync(string id)
        {
            return await _contexto.Usuarios.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Usuario> ConsultarPorIdentificacionAsync(string identificacion)
        {
            return await _contexto.Usuarios.FirstOrDefaultAsync(x => x.Identificacion == identificacion);
        }

        public async Task<Usuario> ConsultarPorNombreusuarioAsync(string nombreUsuario)
        {
            return await _contexto.Usuarios.FirstOrDefaultAsync(x => x.NombreUsuario == nombreUsuario);
        }

        public async Task<IEnumerable<Usuario>> ConsultarUsuariosPorRolAsync(string rolId)
        {
            return await _contexto.UsuariosRol
                                .Where(ur => ur.RolId == rolId)
                                .Include(ur => ur.Usuario)
                                .Select(ur => ur.Usuario)
                                .ToListAsync();
        }

        public async Task<Usuario> AdicionarAsync(Usuario item)
        {
            _contexto.Usuarios.Add(item);
            await _contexto.SaveChangesAsync();
            return item;
        }

        public async Task ActualizarAsync(Usuario item)
        {
            _contexto.Usuarios.Update(item);
            await _contexto.SaveChangesAsync();
        }

        public async Task EliminarAsync(string id)
        {
            var item = await ConsultarPorIdAsync(id);
            if (item == null) return;
            _contexto.Usuarios.Remove(item);
            await _contexto.SaveChangesAsync();
        }
    }
}
