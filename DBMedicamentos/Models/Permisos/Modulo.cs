﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DBMedicamentos.Models.Permisos
{
    public class Modulo
    {
        public string Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
    }
    public class ModuloConfiguration : IEntityTypeConfiguration<Modulo>
    {
        public void Configure(EntityTypeBuilder<Modulo> builder)
        {
            builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(36);
            builder.Property(x => x.Nombre)
                .IsRequired()
                .HasMaxLength(100);
            builder.Property(x => x.Descripcion)
                .IsRequired()
                .HasMaxLength(400);
        }
    }
}
