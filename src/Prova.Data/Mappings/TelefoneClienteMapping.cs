using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class TelefoneClienteMapping : IEntityTypeConfiguration<TelefoneCliente>
    {
        public void Configure(EntityTypeBuilder<TelefoneCliente> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Idt_num_telefone)
             .IsRequired()
             .HasColumnType("varchar(18)");

            builder.Property(p => p.Idt_codigo_area)
             .IsRequired()
             .HasColumnType("varchar(18)");

            builder.Property(p => p.Des_observacao)
             .IsRequired()
             .HasColumnType("varchar(255)");

            builder.ToTable("TB_TELEFONE_CLIENTE");
        }
    }
}
