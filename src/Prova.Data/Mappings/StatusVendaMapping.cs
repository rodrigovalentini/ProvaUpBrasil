using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class StatusVendaMapping : IEntityTypeConfiguration<StatusVenda>
    {
        public void Configure(EntityTypeBuilder<StatusVenda> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nom_status_venda)
             .IsRequired()
             .HasColumnType("varchar(80)");

            builder.Property(p => p.Des_status_venda)
             .IsRequired()
             .HasColumnType("varchar(255)");

            builder.HasMany(s => s.Vendas)
            .WithOne(v => v.StatusVenda)
            .HasForeignKey(i => i.Cod_status_venda);

            builder.ToTable("TB_STATUS_VENDA");
        }
    }
}
