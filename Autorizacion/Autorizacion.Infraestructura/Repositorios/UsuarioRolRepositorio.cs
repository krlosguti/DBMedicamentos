using Autorizacion.Dominio.Repositorios;
using Common.Database.Domain.Data;
using Common.Database.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Autorizacion.Infraestructura.Repositorios
{
    public class UsuarioRolRepositorio(AplicacionDbContext contexto) : IUsuarioRolRepositorio
    {
        private readonly AplicacionDbContext _contexto = contexto;

        public async Task AsignarRolAUsuarioAsync(string idUsuario, string idRol)
        {
            _contexto.UsuariosRol.Add(new UsuarioRol { RolId = idRol, UsuarioId = idUsuario });
            await _contexto.SaveChangesAsync();
        }

        public async Task EliminarRolDeUsuarioAsync(string idUsuario, string idRol)
        {
            var item = await _contexto.UsuariosRol.FirstOrDefaultAsync(x => x.RolId == idRol && x.UsuarioId == idUsuario);
            if (item == null) return;
            _contexto.UsuariosRol.Remove(item);
            await _contexto.SaveChangesAsync();

        }
    }
}
