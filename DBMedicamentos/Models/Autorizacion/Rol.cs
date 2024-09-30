using DBMedicamentos.Models.Auditoria;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBMedicamentos.Models.Autorizacion
{
    public class Rol
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; } = true;
    }
    public class RolConfiguration : IEntityTypeConfiguration<Rol>
    {
        public void Configure(EntityTypeBuilder<Rol> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.Descripcion)
                .HasMaxLength(400);

        }
    }
}
