using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nom_cliente)
                .IsRequired()
                .HasColumnType("varchar(80)");

            builder.Property(p => p.Des_observacao)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.HasMany(c => c.EnderecoClientes)
                .WithOne(e => e.Cliente)
                .HasForeignKey(e => e.Cod_cliente);

            builder.HasMany(c => c.Vendas)
            .WithOne(v => v.Cliente)
            .HasForeignKey(i => i.Cod_cliente);

            builder.ToTable("TB_CLIENTE");
        }
    }
}
