using DBMedicamentos.Models.Auditoria;
using DBMedicamentos.Models.Autorizacion;
using DBMedicamentos.Models.Paginas;
using DBMedicamentos.Models.Permisos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DBMedicamentos.Data
{
    public interface IAplicacionDbContext
    {
        public DbSet<Auditoria> Auditorias { get; set; }
        public DbSet<Configuracion> Configuraciones { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<UsuarioRol> UsuariosRol { get; set; }
        public DbSet<Medio> Medios { get; set; }
        public DbSet<MedioPanel> MediosPanel { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<OpcionMenu> OpcionesMenu { get; set; }
        public DbSet<Panel> Paneles { get; set; }
        public DbSet<Dashboard> Dashboard { get; set; }
        public DbSet<Funcionalidad> Funcionalidades { get; set; }
        public DbSet<Modulo> Modulos { get; set; }
        public DbSet<Permiso> Permisos { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
        EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
    }
}
