using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Database.Domain.Models
{
    public class OpcionMenu
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string MenuId { get; set; }
        public string? OpcionMenuPadreId { get; set; } = null;
        public string PanelId { get; set; }
        public int Orden { get; set; } = 0;
    }
    public class OpcionMenuConfiguration : IEntityTypeConfiguration<OpcionMenu>
    {
        public void Configure(EntityTypeBuilder<OpcionMenu> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(x => x.MenuId)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.OpcionMenuPadreId)
                .HasMaxLength(36);
            builder.Property(x => x.PanelId)
                .IsRequired()
                .HasMaxLength(36);
        }
    }
}
