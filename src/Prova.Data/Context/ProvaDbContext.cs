using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Prova.Business.Models;
using System.Linq;

namespace Prova.Data.Context
{
    public class ProvaDbContext : DbContext
    {
        public ProvaDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Bairro> Bairros { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<EnderecoCliente> EnderecoClientes { get; set; }
        public DbSet<GrupoItem> GrupoItems { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<StatusVenda> StatusVendas { get; set; }
        public DbSet<TelefoneCliente> TelefoneClientes { get; set; }
        public DbSet<TipoEndereco> TipoEnderecos { get; set; }
        public DbSet<TipoItem> TipoItems { get; set; }
        public DbSet<TipoTelefone> TipoTelefones { get; set; }
        public DbSet<TipoVenda> TipoVendas { get; set; }
        public DbSet<Uf> Ufs { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<VendaItem> VendaItems { get; set; }
        public DbSet<Vendedor> Vendedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                .SelectMany(e => e.GetProperties().Where(p => p.ClrType == typeof(string))))
            {
                property.Relational().ColumnType = "varchar(100)";
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProvaDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }
    }
}
