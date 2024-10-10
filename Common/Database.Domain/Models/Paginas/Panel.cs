using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Common.Database.Domain.Models
{
    public class Panel
    {
        public string Id { get; set; }
        public string PlantillaHtml { get; set; }
        public string HojaEstilo { get; set; }
        
    }
    public class PanelConfiguration : IEntityTypeConfiguration<Panel>
        {
            public void Configure(EntityTypeBuilder<Panel> builder)
            {
                builder.Property(x => x.Id)
                .IsRequired()
                .HasMaxLength(36);
            }
        }
}
