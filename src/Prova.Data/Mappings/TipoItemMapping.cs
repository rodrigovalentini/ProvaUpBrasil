using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class TipoItemMapping : IEntityTypeConfiguration<TipoItem>
    {
        public void Configure(EntityTypeBuilder<TipoItem> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nom_tipo_item)
             .IsRequired()
             .HasColumnType("varchar(80)");

            builder.Property(p => p.Des_tipo_item)
             .IsRequired()
             .HasColumnType("varchar(255)");

            builder.HasMany(g => g.Items)
            .WithOne(i => i.TipoItem)
            .HasForeignKey(i => i.Cod_tipo_item);

            builder.ToTable("TB_TIPO_ITEM");
        }
    }
}
