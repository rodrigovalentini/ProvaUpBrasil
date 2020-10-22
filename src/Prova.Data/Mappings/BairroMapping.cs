using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Prova.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova.Data.Mappings
{
    public class BairroMapping : IEntityTypeConfiguration<Bairro>
    {
        public void Configure(EntityTypeBuilder<Bairro> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nom_bairro)
                .IsRequired()
                .HasColumnType("varchar(80)");

            builder.HasMany(b => b.EnderecoClientes)
                .WithOne(e => e.Bairro)
                .HasForeignKey(i => i.Cod_bairro);

            builder.ToTable("TB_BAIRRO");
        }
    }
}
