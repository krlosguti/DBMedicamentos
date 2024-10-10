using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Database.Domain.Models
{
    public enum TipoUbicacion
    {
        Arriba,
        Izquierda,
        Derecha
    }
    public class Menu
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public TipoUbicacion Ubicacion { get; set; } = TipoUbicacion.Arriba;
        public string PanelId { get; set; }
        public int MaximoNroNiveles { get; set; } = 2;
    }
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.PanelId)
                .IsRequired()
                .HasMaxLength(36);
        }
    }
}
