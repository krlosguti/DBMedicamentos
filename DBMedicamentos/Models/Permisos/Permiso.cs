using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBMedicamentos.Models.Permisos
{
    public class Permiso
    {
        public string Id { get; set; }
        public string Descripcion { get; set; }
        public string FuncionalidadId { get; set; }
        public string RolId { get; set; }
        public bool PuedeVer { get; set; } = true;
        public bool PuedeCrear { get; set; } = false;
        public bool PuedeEditar { get; set; } = false;
        public bool PuedeEliminar { get; set; } = false;
    }
    public class PermisoConfiguration : IEntityTypeConfiguration<Permiso>
    {
        public void Configure(EntityTypeBuilder<Permiso> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.Descripcion)
                .HasMaxLength(400);
            builder.Property(x => x.FuncionalidadId)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.RolId)
                .IsRequired()
                .HasMaxLength(36);
        }
    }
}
