using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class VendaItemMapping : IEntityTypeConfiguration<VendaItem>
    {
        public void Configure(EntityTypeBuilder<VendaItem> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Vlr_total_item)
             .IsRequired()
             .HasColumnType("decimal(10,2)");

            builder.Property(p => p.Qtd_item)
             .IsRequired()
             .HasColumnType("decimal(10,2)");

            builder.Property(p => p.Vlr_item)
             .IsRequired()
             .HasColumnType("decimal(10,2)");

            builder.Property(p => p.Vlr_desconto)
           .IsRequired()
           .HasColumnType("decimal(10,2)");

            builder.Property(p => p.Vlr_total_item)
           .IsRequired()
           .HasColumnType("decimal(10,2)");

            builder.ToTable("TB_VENDA_ITEM");
        }
    }
}
