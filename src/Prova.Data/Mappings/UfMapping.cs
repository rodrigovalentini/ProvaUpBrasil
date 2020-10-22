using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;

namespace Prova.Data.Mappings
{
    public class UfMapping : IEntityTypeConfiguration<Uf>
    {
        public void Configure(EntityTypeBuilder<Uf> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nom_uf)
                .IsRequired()
                .HasColumnType("varchar(80)");

            builder.Property(p => p.Sgl_uf)
               .IsRequired()
               .HasColumnType("char(2)");

            builder.HasMany(u => u.Cidades)
                .WithOne(c => c.Uf)
                .HasForeignKey(c => c.Cod_uf);

            builder.ToTable("TB_UF");
        }
    }
}
