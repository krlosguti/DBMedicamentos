using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace DBMedicamentos.Models.Auditoria
{
    public class Configuracion
    {
        public string Id { get; set; }
        public string NombreParametro { get; set; }
        public string ValorParametro { get; set; }
        public string TipoDato { get; set; }
    }
    public class ConfiguracionConfiguration : IEntityTypeConfiguration<Configuracion>
    {
        public void Configure(EntityTypeBuilder<Configuracion> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.NombreParametro)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.ValorParametro)
                .IsRequired()
                .HasMaxLength(500);
            builder.Property(x => x.TipoDato)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
