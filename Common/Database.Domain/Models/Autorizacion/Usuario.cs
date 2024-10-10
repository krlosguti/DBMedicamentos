using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Database.Domain.Models
{
    public class Usuario
    {
        public string Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string NombreUsuario { get; set; }
        public string TipoVinculacionId { get; set; }
        public string DependenciaId { get; set; }
        public DateTime FechaCaducidad { get; set; }
        public string TipoIdentificacionId { get; set; }
        public string Identificacion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Cargo { get; set; }
        public string Conexion { get; set; }
    }
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.Nombres)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.Apellidos)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.NombreUsuario)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.TipoVinculacionId)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.DependenciaId)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.TipoIdentificacionId)
                .HasMaxLength(36);
            builder.Property(x => x.Identificacion)
                .HasMaxLength(50);
            builder.Property(x => x.CorreoElectronico)
                .HasMaxLength(320);
            builder.Property(x => x.Cargo)
                .HasMaxLength(100);
            builder.Property(x => x.Conexion)
                .HasMaxLength(100);
        }
    }
}
