using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBMedicamentos.Models.Autorizacion
{
    public class UsuarioRol
    {
        public string Id { get; set; }
        public string RolId { get; set; }
        public string UsuarioId { get; set; }
    }
    public class UsuarioRolConfiguration : IEntityTypeConfiguration<UsuarioRol>
    {
        public void Configure(EntityTypeBuilder<UsuarioRol> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.RolId)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.UsuarioId)
                .IsRequired()
                .HasMaxLength(36);
        }
    }
}
