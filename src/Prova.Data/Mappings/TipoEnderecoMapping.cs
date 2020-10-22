using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class TipoEnderecoMapping : IEntityTypeConfiguration<TipoEndereco>
    {
        public void Configure(EntityTypeBuilder<TipoEndereco> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.nom_tipo_endereco)
             .IsRequired()
             .HasColumnType("varchar(80)");

            builder.Property(p => p.Des_tipo_endereco)
             .IsRequired()
             .HasColumnType("varchar(255)");

            builder.HasMany(t => t.EnderecoClientes)
            .WithOne(e => e.TipoEndereco)
            .HasForeignKey(i => i.Cod_tipo_endereco);

            builder.ToTable("TB_TIPO_ENDERECO");
        }
    }
}
