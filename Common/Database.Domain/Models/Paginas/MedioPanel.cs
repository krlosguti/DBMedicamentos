using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Database.Domain.Models
{
    public enum TipoUbicacionMedios
    {
        Normal,
        Carrusel,
        Lista
    }
    public class MedioPanel
    {
        public string Id { get; set; }
        public string PanelId { get; set; }
        public List<string> MediosId { get; set; }
        public string Etiqueta { get; set; }
        public TipoUbicacionMedios TipoUbicacion { get; set; }
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
            builder.Property(x => x.MediosId)
                .IsRequired();
            builder.Property(x => x.Etiqueta)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
