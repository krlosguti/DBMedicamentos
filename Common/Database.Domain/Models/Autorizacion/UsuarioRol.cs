using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Database.Domain.Models
{
    public class UsuarioRol
    {
        public string RolId { get; set; }
        public string UsuarioId { get; set; }

        public Rol Rol { get; set; }
        public Usuario Usuario { get; set; }
    }
    public class UsuarioRolConfiguration : IEntityTypeConfiguration<UsuarioRol>
    {
        public void Configure(EntityTypeBuilder<UsuarioRol> builder)
        {
            builder.Property(x => x.RolId)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.UsuarioId)
                .IsRequired()
                .HasMaxLength(36);
            builder.HasKey(x => new { x.RolId, x.UsuarioId });
        }
    }
}
