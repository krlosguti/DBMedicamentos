using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBMedicamentos.Models.Paginas
{
    public class MedioPanel
    {
        public string Id { get; set; }
        public string PanelId { get; set; }
        public string MedioId { get; set; }
        public string Etiqueta { get; set; }
    }
    public class MedioPanelConfiguration : IEntityTypeConfiguration<MedioPanel>
    {
        public void Configure(EntityTypeBuilder<MedioPanel> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.PanelId)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.MedioId)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.Etiqueta)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
