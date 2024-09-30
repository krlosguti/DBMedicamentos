using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBMedicamentos.Models.Paginas
{
    public class Medio
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string TipoArchivo { get; set; }
        public string Url { get; set; }
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
            builder.Property(x => x.Url)
                .IsRequired()
                .HasMaxLength(4096);
        }
    }
}
