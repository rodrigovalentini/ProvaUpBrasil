using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class VendaMapping : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Vlr_total_item)
             .IsRequired()
             .HasColumnType("decimal(10,2)");

            builder.Property(p => p.Vlr_total_desconto)
             .IsRequired()
             .HasColumnType("decimal(10,2)");

            builder.Property(p => p.Vlr_total_venda)
             .IsRequired()
             .HasColumnType("decimal(10,2)");

            builder.Property(p => p.Des_observacao)
             .IsRequired()
             .HasColumnType("varchar(255)");

            builder.HasMany(v => v.VendaItens)
            .WithOne(i => i.Venda)
            .HasForeignKey(i => i.Cod_venda);

            builder.ToTable("TB_VENDA");
        }
    }
}
