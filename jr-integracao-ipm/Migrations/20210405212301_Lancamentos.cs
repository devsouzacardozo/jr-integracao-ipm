using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace jrintegracaoipm.Migrations
{
    public partial class Lancamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lancamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    CtlSequencia = table.Column<int>(nullable: false),
                    LanData = table.Column<DateTime>(nullable: false),
                    LanHistorico = table.Column<string>(nullable: true),
                    LanValor = table.Column<double>(nullable: false),
                    FlagEstorno = table.Column<int>(nullable: false),
                    TlcCodigo = table.Column<int>(nullable: false),
                    PlnTipoPlano = table.Column<int>(nullable: false),
                    Plncodigo = table.Column<string>(nullable: true),
                    PlnTipoPlanoContra = table.Column<int>(nullable: false),
                    PlnCodigoContra = table.Column<string>(nullable: true),
                    VinCodigo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lancamentos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lancamentos");
        }
    }
}
