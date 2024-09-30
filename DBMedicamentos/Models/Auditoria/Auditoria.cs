using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace DBMedicamentos.Models.Auditoria
{
    public enum TipoTransaccion
    {
        Crear,
        Actualizar,
        Eliminar
    }
    public class Auditoria
    {
        public string Id { get; set; }
        public string? RegistroAnterior { get; set; }
        public string? RegistroNuevo { get; set; }
        public string RegistroId { get; set; }
        public string FechaTransaccion { get; set; }
        public string NombreTabla { get; set; }
        public TipoTransaccion Transaccion { get; set; }
    }

    public class AuditoriaConfiguration : IEntityTypeConfiguration<Auditoria>
    {
        public void Configure(EntityTypeBuilder<Auditoria> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.FechaTransaccion)
                .IsRequired();
            builder.Property(x => x.Transaccion)
                .IsRequired();
            builder.Property(x => x.RegistroId)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.NombreTabla)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
