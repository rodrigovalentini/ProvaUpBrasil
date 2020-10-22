using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class TipoVendaMapping : IEntityTypeConfiguration<TipoVenda>
    {
        public void Configure(EntityTypeBuilder<TipoVenda> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nom_tipo_venda)
             .IsRequired()
             .HasColumnType("varchar(80)");

            builder.Property(p => p.Des_tipo_venda)
             .IsRequired()
             .HasColumnType("varchar(255)");

            builder.HasMany(t => t.Vendas)
            .WithOne(i => i.TipoVenda)
            .HasForeignKey(i => i.Cod_tipo_venda);

            builder.ToTable("TB_TIPO_VENDA");
        }
    }
}
