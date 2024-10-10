using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Database.Domain.Models
{
    public class Funcionalidad
    {
        public string Id { get; set; }
        public string ModuloId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string? DashboardId { get; set; }
    }
    public class FuncionalidadConfiguration : IEntityTypeConfiguration<Funcionalidad>
    {
        public void Configure(EntityTypeBuilder<Funcionalidad> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.ModuloId)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.DashboardId)
                .HasMaxLength(36);
            builder.Property(x => x.Descripcion)
                .HasMaxLength(400);
        }
    }
}
