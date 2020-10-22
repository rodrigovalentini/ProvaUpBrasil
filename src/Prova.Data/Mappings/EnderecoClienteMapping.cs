using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class EnderecoClienteMapping : IEntityTypeConfiguration<EnderecoCliente>
    {
        public void Configure(EntityTypeBuilder<EnderecoCliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Des_endereco)
                .IsRequired()
                .HasColumnType("varchar(255)");

            builder.Property(p => p.Des_complemento)
               .IsRequired()
               .HasColumnType("varchar(255)");

            builder.Property(p => p.Idt_caixa_postal)
              .IsRequired()
              .HasColumnType("varchar(18)");

            builder.Property(p => p.Idt_cep)
              .IsRequired()
              .HasColumnType("varchar(18)");

            builder.Property(p => p.Des_observacao)
              .IsRequired()
              .HasColumnType("varchar(255)");

            builder.ToTable("TB_ENDERECO_CLIENTE");
        }
    }
}
