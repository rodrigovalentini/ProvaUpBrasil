using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class TipoTelefoneMapping : IEntityTypeConfiguration<TipoTelefone>
    {
        public void Configure(EntityTypeBuilder<TipoTelefone> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nom_tipo_telefone)
             .IsRequired()
             .HasColumnType("varchar(80)");

            builder.HasMany(t => t.TelefoneClientes)
            .WithOne(i => i.TipoTelefone)
            .HasForeignKey(i => i.Cod_tipo_telefone);

            builder.ToTable("TB_TIPO_TELEFONE");
        }
    }
}
