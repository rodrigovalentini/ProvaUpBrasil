using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class CidadeMapping : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nom_cidade)
                .IsRequired()
                .HasColumnType("varchar(80)");

            builder.HasMany(c => c.Bairros)
            .WithOne(b => b.Cidade)
            .HasForeignKey(b => b.Cod_cidade);

            builder.ToTable("TB_CIDADE");
        }
    }
}
