using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class ItemMapping : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nom_item)
             .IsRequired()
             .HasColumnType("varchar(80)");

            builder.Property(p => p.Qtd_Item)
             .IsRequired()
             .HasColumnType("decimal(10,2)");

            builder.Property(p => p.Qtd_minima_item)
             .IsRequired()
             .HasColumnType("decimal(10,2)");

            builder.Property(p => p.Vlr_item)
             .IsRequired()
             .HasColumnType("decimal(10,2)");

            builder.HasMany(i => i.VendaItens)
            .WithOne(v => v.Item)
            .HasForeignKey(i => i.Cod_item);

            builder.ToTable("TB_ITEM");
        }
    }
}
