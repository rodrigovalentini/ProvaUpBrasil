using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class GrupoItemMapping : IEntityTypeConfiguration<GrupoItem>
    {
        public void Configure(EntityTypeBuilder<GrupoItem> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nom_grupo_item)
             .IsRequired()
             .HasColumnType("varchar(80)");

            builder.Property(p => p.Des_grupo_item)
             .IsRequired()
             .HasColumnType("varchar(255)");

            builder.HasMany(g => g.Items)
            .WithOne(i => i.GrupoItem)
            .HasForeignKey(i => i.Cod_grupo_item);

            builder.ToTable("TB_GRUPO_ITEM");
        }
    }
}
