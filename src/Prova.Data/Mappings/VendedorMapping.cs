using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class VendedorMapping : IEntityTypeConfiguration<Vendedor>
    {
        public void Configure(EntityTypeBuilder<Vendedor> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nom_vendedor)
                .IsRequired()
                .HasColumnType("varchar(80)");

            builder.HasMany(v => v.Vendas)
            .WithOne(v => v.Vendedor)
            .HasForeignKey(i => i.Cod_vendedor);

            builder.ToTable("TB_VENDEDOR");
        }
    }
}
