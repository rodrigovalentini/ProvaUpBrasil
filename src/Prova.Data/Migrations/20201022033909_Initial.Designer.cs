﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Prova.Data.Context;

namespace Prova.Data.Migrations
{
    [DbContext(typeof(ProvaDbContext))]
    [Migration("20201022033909_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Prova.Business.Models.Bairro", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Cod_cidade");

                    b.Property<bool>("Fl_ativo");

                    b.Property<string>("Nom_bairro")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.HasIndex("Cod_cidade");

                    b.ToTable("TB_BAIRRO");
                });

            modelBuilder.Entity("Prova.Business.Models.Cidade", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Cod_uf");

                    b.Property<bool>("Fl_ativo");

                    b.Property<string>("Nom_cidade")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.HasIndex("Cod_uf");

                    b.ToTable("TB_CIDADE");
                });

            modelBuilder.Entity("Prova.Business.Models.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Des_observacao")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("Dt_cadastramento");

                    b.Property<bool>("Fl_ativo");

                    b.Property<string>("Nom_cliente")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("TB_CLIENTE");
                });

            modelBuilder.Entity("Prova.Business.Models.EnderecoCliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Cod_bairro");

                    b.Property<Guid>("Cod_cliente");

                    b.Property<Guid>("Cod_tipo_endereco");

                    b.Property<string>("Des_complemento")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Des_endereco")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Des_observacao")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Fl_ativo");

                    b.Property<string>("Idt_caixa_postal")
                        .IsRequired()
                        .HasColumnType("varchar(18)");

                    b.Property<string>("Idt_cep")
                        .IsRequired()
                        .HasColumnType("varchar(18)");

                    b.HasKey("Id");

                    b.HasIndex("Cod_bairro");

                    b.HasIndex("Cod_cliente");

                    b.HasIndex("Cod_tipo_endereco");

                    b.ToTable("TB_ENDERECO_CLIENTE");
                });

            modelBuilder.Entity("Prova.Business.Models.GrupoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Des_grupo_item")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Fl_ativo");

                    b.Property<string>("Nom_grupo_item")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("TB_GRUPO_ITEM");
                });

            modelBuilder.Entity("Prova.Business.Models.Item", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Cod_grupo_item");

                    b.Property<Guid>("Cod_tipo_item");

                    b.Property<DateTime>("Dt_cadastramento");

                    b.Property<bool>("Fl_ativo");

                    b.Property<string>("Nom_item")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<decimal>("Qtd_Item")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Qtd_minima_item")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Vlr_item")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("Cod_grupo_item");

                    b.HasIndex("Cod_tipo_item");

                    b.ToTable("TB_ITEM");
                });

            modelBuilder.Entity("Prova.Business.Models.StatusVenda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Des_status_venda")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Fl_ativo");

                    b.Property<string>("Nom_status_venda")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("TB_STATUS_VENDA");
                });

            modelBuilder.Entity("Prova.Business.Models.TelefoneCliente", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ClienteId");

                    b.Property<Guid>("Cod_cliente");

                    b.Property<Guid>("Cod_tipo_telefone");

                    b.Property<string>("Des_observacao")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Fl_ativo");

                    b.Property<string>("Idt_codigo_area")
                        .IsRequired()
                        .HasColumnType("varchar(18)");

                    b.Property<string>("Idt_num_telefone")
                        .IsRequired()
                        .HasColumnType("varchar(18)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("Cod_tipo_telefone");

                    b.ToTable("TB_TELEFONE_CLIENTE");
                });

            modelBuilder.Entity("Prova.Business.Models.TipoEndereco", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Des_tipo_endereco")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Fl_ativo");

                    b.Property<string>("nom_tipo_endereco")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("TB_TIPO_ENDERECO");
                });

            modelBuilder.Entity("Prova.Business.Models.TipoItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Cod_item");

                    b.Property<string>("Des_tipo_item")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Fl_ativo");

                    b.Property<Guid?>("ItemId");

                    b.Property<string>("Nom_tipo_item")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.HasIndex("ItemId");

                    b.ToTable("TB_TIPO_ITEM");
                });

            modelBuilder.Entity("Prova.Business.Models.TipoTelefone", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Fl_ativo");

                    b.Property<string>("Nom_tipo_telefone")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("TB_TIPO_TELEFONE");
                });

            modelBuilder.Entity("Prova.Business.Models.TipoVenda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Des_tipo_venda")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<bool>("Fl_ativo");

                    b.Property<string>("Nom_tipo_venda")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("TB_TIPO_VENDA");
                });

            modelBuilder.Entity("Prova.Business.Models.Uf", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Fl_ativo");

                    b.Property<string>("Nom_uf")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.Property<string>("Sgl_uf")
                        .IsRequired()
                        .HasColumnType("char(2)");

                    b.HasKey("Id");

                    b.ToTable("TB_UF");
                });

            modelBuilder.Entity("Prova.Business.Models.Venda", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Cod_cliente");

                    b.Property<Guid>("Cod_status_venda");

                    b.Property<Guid>("Cod_tipo_venda");

                    b.Property<Guid>("Cod_vendedor");

                    b.Property<string>("Des_observacao")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("Dt_cadastramento");

                    b.Property<DateTime>("Dt_venda");

                    b.Property<decimal>("Vlr_total_desconto")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Vlr_total_item")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Vlr_total_venda")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("Cod_cliente");

                    b.HasIndex("Cod_status_venda");

                    b.HasIndex("Cod_tipo_venda");

                    b.HasIndex("Cod_vendedor");

                    b.ToTable("TB_VENDA");
                });

            modelBuilder.Entity("Prova.Business.Models.VendaItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("Cod_item");

                    b.Property<Guid>("Cod_venda");

                    b.Property<decimal>("Qtd_item")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Vlr_desconto")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Vlr_item")
                        .HasColumnType("decimal(10,2)");

                    b.Property<decimal>("Vlr_total_item")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("Id");

                    b.HasIndex("Cod_item");

                    b.HasIndex("Cod_venda");

                    b.ToTable("TB_VENDA_ITEM");
                });

            modelBuilder.Entity("Prova.Business.Models.Vendedor", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Dt_cadastramento");

                    b.Property<bool>("Fl_ativo");

                    b.Property<string>("Nom_vendedor")
                        .IsRequired()
                        .HasColumnType("varchar(80)");

                    b.HasKey("Id");

                    b.ToTable("TB_VENDEDOR");
                });

            modelBuilder.Entity("Prova.Business.Models.Bairro", b =>
                {
                    b.HasOne("Prova.Business.Models.Cidade", "Cidade")
                        .WithMany("Bairros")
                        .HasForeignKey("Cod_cidade");
                });

            modelBuilder.Entity("Prova.Business.Models.Cidade", b =>
                {
                    b.HasOne("Prova.Business.Models.Uf", "Uf")
                        .WithMany("Cidades")
                        .HasForeignKey("Cod_uf");
                });

            modelBuilder.Entity("Prova.Business.Models.EnderecoCliente", b =>
                {
                    b.HasOne("Prova.Business.Models.Bairro", "Bairro")
                        .WithMany("EnderecoClientes")
                        .HasForeignKey("Cod_bairro");

                    b.HasOne("Prova.Business.Models.Cliente", "Cliente")
                        .WithMany("EnderecoClientes")
                        .HasForeignKey("Cod_cliente");

                    b.HasOne("Prova.Business.Models.TipoEndereco", "TipoEndereco")
                        .WithMany("EnderecoClientes")
                        .HasForeignKey("Cod_tipo_endereco");
                });

            modelBuilder.Entity("Prova.Business.Models.Item", b =>
                {
                    b.HasOne("Prova.Business.Models.GrupoItem", "GrupoItem")
                        .WithMany("Items")
                        .HasForeignKey("Cod_grupo_item");

                    b.HasOne("Prova.Business.Models.TipoItem", "TipoItem")
                        .WithMany("Items")
                        .HasForeignKey("Cod_tipo_item");
                });

            modelBuilder.Entity("Prova.Business.Models.TelefoneCliente", b =>
                {
                    b.HasOne("Prova.Business.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("Prova.Business.Models.TipoTelefone", "TipoTelefone")
                        .WithMany("TelefoneClientes")
                        .HasForeignKey("Cod_tipo_telefone");
                });

            modelBuilder.Entity("Prova.Business.Models.TipoItem", b =>
                {
                    b.HasOne("Prova.Business.Models.Item", "Item")
                        .WithMany()
                        .HasForeignKey("ItemId");
                });

            modelBuilder.Entity("Prova.Business.Models.Venda", b =>
                {
                    b.HasOne("Prova.Business.Models.Cliente", "Cliente")
                        .WithMany("Vendas")
                        .HasForeignKey("Cod_cliente");

                    b.HasOne("Prova.Business.Models.StatusVenda", "StatusVenda")
                        .WithMany("Vendas")
                        .HasForeignKey("Cod_status_venda");

                    b.HasOne("Prova.Business.Models.TipoVenda", "TipoVenda")
                        .WithMany("Vendas")
                        .HasForeignKey("Cod_tipo_venda");

                    b.HasOne("Prova.Business.Models.Vendedor", "Vendedor")
                        .WithMany("Vendas")
                        .HasForeignKey("Cod_vendedor");
                });

            modelBuilder.Entity("Prova.Business.Models.VendaItem", b =>
                {
                    b.HasOne("Prova.Business.Models.Item", "Item")
                        .WithMany("VendaItens")
                        .HasForeignKey("Cod_item");

                    b.HasOne("Prova.Business.Models.Venda", "Venda")
                        .WithMany("VendaItens")
                        .HasForeignKey("Cod_venda");
                });
#pragma warning restore 612, 618
        }
    }
}
