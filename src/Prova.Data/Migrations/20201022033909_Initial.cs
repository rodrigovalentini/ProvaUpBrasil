using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Prova.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_CLIENTE",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom_cliente = table.Column<string>(type: "varchar(80)", nullable: false),
                    Dt_cadastramento = table.Column<DateTime>(nullable: false),
                    Des_observacao = table.Column<string>(type: "varchar(255)", nullable: false),
                    Fl_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CLIENTE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_GRUPO_ITEM",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom_grupo_item = table.Column<string>(type: "varchar(80)", nullable: false),
                    Des_grupo_item = table.Column<string>(type: "varchar(255)", nullable: false),
                    Fl_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_GRUPO_ITEM", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_STATUS_VENDA",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom_status_venda = table.Column<string>(type: "varchar(80)", nullable: false),
                    Des_status_venda = table.Column<string>(type: "varchar(255)", nullable: false),
                    Fl_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_STATUS_VENDA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPO_ENDERECO",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    nom_tipo_endereco = table.Column<string>(type: "varchar(80)", nullable: false),
                    Des_tipo_endereco = table.Column<string>(type: "varchar(255)", nullable: false),
                    Fl_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TIPO_ENDERECO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPO_TELEFONE",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom_tipo_telefone = table.Column<string>(type: "varchar(80)", nullable: false),
                    Fl_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TIPO_TELEFONE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPO_VENDA",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom_tipo_venda = table.Column<string>(type: "varchar(80)", nullable: false),
                    Des_tipo_venda = table.Column<string>(type: "varchar(255)", nullable: false),
                    Fl_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TIPO_VENDA", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_UF",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom_uf = table.Column<string>(type: "varchar(80)", nullable: false),
                    Sgl_uf = table.Column<string>(type: "char(2)", nullable: false),
                    Fl_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_UF", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_VENDEDOR",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom_vendedor = table.Column<string>(type: "varchar(80)", nullable: false),
                    Dt_cadastramento = table.Column<DateTime>(nullable: false),
                    Fl_ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_VENDEDOR", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TB_TELEFONE_CLIENTE",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Idt_num_telefone = table.Column<string>(type: "varchar(18)", nullable: false),
                    Idt_codigo_area = table.Column<string>(type: "varchar(18)", nullable: false),
                    Des_observacao = table.Column<string>(type: "varchar(255)", nullable: false),
                    Fl_ativo = table.Column<bool>(nullable: false),
                    Cod_cliente = table.Column<Guid>(nullable: false),
                    Cod_tipo_telefone = table.Column<Guid>(nullable: false),
                    ClienteId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TELEFONE_CLIENTE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_TELEFONE_CLIENTE_TB_CLIENTE_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "TB_CLIENTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_TELEFONE_CLIENTE_TB_TIPO_TELEFONE_Cod_tipo_telefone",
                        column: x => x.Cod_tipo_telefone,
                        principalTable: "TB_TIPO_TELEFONE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_CIDADE",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom_cidade = table.Column<string>(type: "varchar(80)", nullable: false),
                    Fl_ativo = table.Column<bool>(nullable: false),
                    Cod_uf = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_CIDADE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_CIDADE_TB_UF_Cod_uf",
                        column: x => x.Cod_uf,
                        principalTable: "TB_UF",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_VENDA",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Dt_cadastramento = table.Column<DateTime>(nullable: false),
                    Dt_venda = table.Column<DateTime>(nullable: false),
                    Vlr_total_item = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Vlr_total_desconto = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Vlr_total_venda = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Des_observacao = table.Column<string>(type: "varchar(255)", nullable: false),
                    Cod_tipo_venda = table.Column<Guid>(nullable: false),
                    Cod_status_venda = table.Column<Guid>(nullable: false),
                    Cod_vendedor = table.Column<Guid>(nullable: false),
                    Cod_cliente = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_VENDA", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_VENDA_TB_CLIENTE_Cod_cliente",
                        column: x => x.Cod_cliente,
                        principalTable: "TB_CLIENTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_VENDA_TB_STATUS_VENDA_Cod_status_venda",
                        column: x => x.Cod_status_venda,
                        principalTable: "TB_STATUS_VENDA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_VENDA_TB_TIPO_VENDA_Cod_tipo_venda",
                        column: x => x.Cod_tipo_venda,
                        principalTable: "TB_TIPO_VENDA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_VENDA_TB_VENDEDOR_Cod_vendedor",
                        column: x => x.Cod_vendedor,
                        principalTable: "TB_VENDEDOR",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_BAIRRO",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom_bairro = table.Column<string>(type: "varchar(80)", nullable: false),
                    Fl_ativo = table.Column<bool>(nullable: false),
                    Cod_cidade = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_BAIRRO", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_BAIRRO_TB_CIDADE_Cod_cidade",
                        column: x => x.Cod_cidade,
                        principalTable: "TB_CIDADE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_ENDERECO_CLIENTE",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Des_endereco = table.Column<string>(type: "varchar(255)", nullable: false),
                    Des_complemento = table.Column<string>(type: "varchar(255)", nullable: false),
                    Idt_caixa_postal = table.Column<string>(type: "varchar(18)", nullable: false),
                    Idt_cep = table.Column<string>(type: "varchar(18)", nullable: false),
                    Des_observacao = table.Column<string>(type: "varchar(255)", nullable: false),
                    Fl_ativo = table.Column<bool>(nullable: false),
                    Cod_cliente = table.Column<Guid>(nullable: false),
                    Cod_tipo_endereco = table.Column<Guid>(nullable: false),
                    Cod_bairro = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ENDERECO_CLIENTE", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_ENDERECO_CLIENTE_TB_BAIRRO_Cod_bairro",
                        column: x => x.Cod_bairro,
                        principalTable: "TB_BAIRRO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_ENDERECO_CLIENTE_TB_CLIENTE_Cod_cliente",
                        column: x => x.Cod_cliente,
                        principalTable: "TB_CLIENTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_ENDERECO_CLIENTE_TB_TIPO_ENDERECO_Cod_tipo_endereco",
                        column: x => x.Cod_tipo_endereco,
                        principalTable: "TB_TIPO_ENDERECO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_ITEM",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom_item = table.Column<string>(type: "varchar(80)", nullable: false),
                    Qtd_Item = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Qtd_minima_item = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Vlr_item = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Dt_cadastramento = table.Column<DateTime>(nullable: false),
                    Fl_ativo = table.Column<bool>(nullable: false),
                    Cod_grupo_item = table.Column<Guid>(nullable: false),
                    Cod_tipo_item = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_ITEM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_ITEM_TB_GRUPO_ITEM_Cod_grupo_item",
                        column: x => x.Cod_grupo_item,
                        principalTable: "TB_GRUPO_ITEM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_TIPO_ITEM",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nom_tipo_item = table.Column<string>(type: "varchar(80)", nullable: false),
                    Des_tipo_item = table.Column<string>(type: "varchar(255)", nullable: false),
                    Fl_ativo = table.Column<bool>(nullable: false),
                    ItemId = table.Column<Guid>(nullable: true),
                    Cod_item = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_TIPO_ITEM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_TIPO_ITEM_TB_ITEM_ItemId",
                        column: x => x.ItemId,
                        principalTable: "TB_ITEM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TB_VENDA_ITEM",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Qtd_item = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Vlr_item = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Vlr_desconto = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Vlr_total_item = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Cod_item = table.Column<Guid>(nullable: false),
                    Cod_venda = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_VENDA_ITEM", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TB_VENDA_ITEM_TB_ITEM_Cod_item",
                        column: x => x.Cod_item,
                        principalTable: "TB_ITEM",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TB_VENDA_ITEM_TB_VENDA_Cod_venda",
                        column: x => x.Cod_venda,
                        principalTable: "TB_VENDA",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TB_BAIRRO_Cod_cidade",
                table: "TB_BAIRRO",
                column: "Cod_cidade");

            migrationBuilder.CreateIndex(
                name: "IX_TB_CIDADE_Cod_uf",
                table: "TB_CIDADE",
                column: "Cod_uf");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ENDERECO_CLIENTE_Cod_bairro",
                table: "TB_ENDERECO_CLIENTE",
                column: "Cod_bairro");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ENDERECO_CLIENTE_Cod_cliente",
                table: "TB_ENDERECO_CLIENTE",
                column: "Cod_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ENDERECO_CLIENTE_Cod_tipo_endereco",
                table: "TB_ENDERECO_CLIENTE",
                column: "Cod_tipo_endereco");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ITEM_Cod_grupo_item",
                table: "TB_ITEM",
                column: "Cod_grupo_item");

            migrationBuilder.CreateIndex(
                name: "IX_TB_ITEM_Cod_tipo_item",
                table: "TB_ITEM",
                column: "Cod_tipo_item");

            migrationBuilder.CreateIndex(
                name: "IX_TB_TELEFONE_CLIENTE_ClienteId",
                table: "TB_TELEFONE_CLIENTE",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_TELEFONE_CLIENTE_Cod_tipo_telefone",
                table: "TB_TELEFONE_CLIENTE",
                column: "Cod_tipo_telefone");

            migrationBuilder.CreateIndex(
                name: "IX_TB_TIPO_ITEM_ItemId",
                table: "TB_TIPO_ITEM",
                column: "ItemId");

            migrationBuilder.CreateIndex(
                name: "IX_TB_VENDA_Cod_cliente",
                table: "TB_VENDA",
                column: "Cod_cliente");

            migrationBuilder.CreateIndex(
                name: "IX_TB_VENDA_Cod_status_venda",
                table: "TB_VENDA",
                column: "Cod_status_venda");

            migrationBuilder.CreateIndex(
                name: "IX_TB_VENDA_Cod_tipo_venda",
                table: "TB_VENDA",
                column: "Cod_tipo_venda");

            migrationBuilder.CreateIndex(
                name: "IX_TB_VENDA_Cod_vendedor",
                table: "TB_VENDA",
                column: "Cod_vendedor");

            migrationBuilder.CreateIndex(
                name: "IX_TB_VENDA_ITEM_Cod_item",
                table: "TB_VENDA_ITEM",
                column: "Cod_item");

            migrationBuilder.CreateIndex(
                name: "IX_TB_VENDA_ITEM_Cod_venda",
                table: "TB_VENDA_ITEM",
                column: "Cod_venda");

            migrationBuilder.AddForeignKey(
                name: "FK_TB_ITEM_TB_TIPO_ITEM_Cod_tipo_item",
                table: "TB_ITEM",
                column: "Cod_tipo_item",
                principalTable: "TB_TIPO_ITEM",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TB_ITEM_TB_GRUPO_ITEM_Cod_grupo_item",
                table: "TB_ITEM");

            migrationBuilder.DropForeignKey(
                name: "FK_TB_ITEM_TB_TIPO_ITEM_Cod_tipo_item",
                table: "TB_ITEM");

            migrationBuilder.DropTable(
                name: "TB_ENDERECO_CLIENTE");

            migrationBuilder.DropTable(
                name: "TB_TELEFONE_CLIENTE");

            migrationBuilder.DropTable(
                name: "TB_VENDA_ITEM");

            migrationBuilder.DropTable(
                name: "TB_BAIRRO");

            migrationBuilder.DropTable(
                name: "TB_TIPO_ENDERECO");

            migrationBuilder.DropTable(
                name: "TB_TIPO_TELEFONE");

            migrationBuilder.DropTable(
                name: "TB_VENDA");

            migrationBuilder.DropTable(
                name: "TB_CIDADE");

            migrationBuilder.DropTable(
                name: "TB_CLIENTE");

            migrationBuilder.DropTable(
                name: "TB_STATUS_VENDA");

            migrationBuilder.DropTable(
                name: "TB_TIPO_VENDA");

            migrationBuilder.DropTable(
                name: "TB_VENDEDOR");

            migrationBuilder.DropTable(
                name: "TB_UF");

            migrationBuilder.DropTable(
                name: "TB_GRUPO_ITEM");

            migrationBuilder.DropTable(
                name: "TB_TIPO_ITEM");

            migrationBuilder.DropTable(
                name: "TB_ITEM");
        }
    }
}
