using DBMedicamentos.Models.Auditoria;
using DBMedicamentos.Models.Autorizacion;
using DBMedicamentos.Models.Paginas;
using DBMedicamentos.Models.Permisos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace DBMedicamentos.Data
{
    public class AplicacionDbContext: DbContext,IAplicacionDbContext
    {
        public AplicacionDbContext(DbContextOptions<AplicacionDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Aplica automáticamente todas las configuraciones que implementen IEntityTypeConfiguration<>
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AplicacionDbContext).Assembly);
        }

        public new async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await base.SaveChangesAsync(cancellationToken);
        }

        public new EntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            return base.Entry(entity);
        }

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
    }
}
