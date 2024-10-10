using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Database.Domain.Models
{
    public class Medio
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string TipoArchivo { get; set; }
        public string UrloTexto { get; set; }
    }
    public class MedioConfiguration : IEntityTypeConfiguration<Medio>
    {
        public void Configure(EntityTypeBuilder<Medio> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(400);
            builder.Property(x => x.TipoArchivo)
                .IsRequired()
                .HasMaxLength(30);
            builder.Property(x => x.UrloTexto)
                .IsRequired();
        }
    }
}
