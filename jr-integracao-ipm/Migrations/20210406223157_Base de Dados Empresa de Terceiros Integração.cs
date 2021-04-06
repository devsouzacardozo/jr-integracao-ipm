using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace jrintegracaoipm.Migrations
{
    public partial class BasedeDadosEmpresadeTerceirosIntegração : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AlteracaoOrcamentarias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    AloNumero = table.Column<int>(nullable: false),
                    AloData = table.Column<int>(nullable: false),
                    FaoSequencia = table.Column<int>(nullable: false),
                    FaoTipo = table.Column<int>(nullable: false),
                    FaoTipoFonte = table.Column<int>(nullable: false),
                    FaoTipoCredito = table.Column<int>(nullable: false),
                    FaoValor = table.Column<double>(nullable: false),
                    Orgcodigo = table.Column<int>(nullable: false),
                    Undcodigo = table.Column<int>(nullable: false),
                    TfcCodigo = table.Column<int>(nullable: false),
                    TsfCodigo = table.Column<int>(nullable: false),
                    PgrCodigo = table.Column<int>(nullable: false),
                    AcoTipo = table.Column<int>(nullable: false),
                    AcoCodigo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AlteracaoOrcamentarias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empenhos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    EmpNro = table.Column<int>(nullable: false),
                    EmpSub = table.Column<int>(nullable: false),
                    EmpEspecie = table.Column<int>(nullable: false),
                    EmpAnoInscResto = table.Column<int>(nullable: false),
                    EmpAnoBaixaResto = table.Column<int>(nullable: false),
                    EmpDataEmissao = table.Column<DateTime>(nullable: false),
                    EmpDataVencimento = table.Column<DateTime>(nullable: false),
                    EmpValor = table.Column<double>(nullable: false),
                    EmpHistorico = table.Column<string>(nullable: true),
                    UniCpfCnpj = table.Column<string>(nullable: true),
                    UniNomeRazao = table.Column<string>(nullable: true),
                    PlnTipoPlano = table.Column<int>(nullable: false),
                    PlnCodigo = table.Column<string>(nullable: true),
                    OrgCodigo = table.Column<int>(nullable: false),
                    UndCodigo = table.Column<int>(nullable: false),
                    TfcCodigo = table.Column<int>(nullable: false),
                    TsfCodigo = table.Column<int>(nullable: false),
                    PgrCodigo = table.Column<int>(nullable: false),
                    AcoTipo = table.Column<int>(nullable: false),
                    AcoCodigo = table.Column<int>(nullable: false),
                    VinCodigo = table.Column<int>(nullable: false),
                    PlnCodigoDotacao = table.Column<string>(nullable: true),
                    CtlSequencia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empenhos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstornoEmpenhos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    LoaAnoEmp = table.Column<int>(nullable: false),
                    EmpNro = table.Column<int>(nullable: false),
                    EmpSup = table.Column<int>(nullable: false),
                    EstSequencia = table.Column<int>(nullable: false),
                    EstHistorico = table.Column<string>(nullable: true),
                    EstTipoCancResto = table.Column<int>(nullable: false),
                    EstData = table.Column<DateTime>(nullable: false),
                    EstValor = table.Column<double>(nullable: false),
                    CtlSequencia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstornoEmpenhos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstornoReceitaOrcamentarias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    RecSequencia = table.Column<int>(nullable: false),
                    EsrSequencia = table.Column<int>(nullable: false),
                    EsrTipo = table.Column<int>(nullable: false),
                    EsrDataEstorno = table.Column<DateTime>(nullable: false),
                    EsrValor = table.Column<double>(nullable: false),
                    EsrHistorico = table.Column<string>(nullable: true),
                    EsrTipoDocumento = table.Column<int>(nullable: false),
                    EsrNroDocumento = table.Column<string>(nullable: true),
                    PlnTipoPlanoBanco = table.Column<int>(nullable: false),
                    PlnCodigoBanco = table.Column<string>(nullable: true),
                    PlnTipoPlano = table.Column<int>(nullable: false),
                    PlnCodigo = table.Column<string>(nullable: true),
                    VinCodigo = table.Column<int>(nullable: false),
                    CtlSequencia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstornoReceitaOrcamentarias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstornosLiquidacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    LoaAnoLiq = table.Column<int>(nullable: false),
                    LiqTipo = table.Column<int>(nullable: false),
                    LiqSequencia = table.Column<int>(nullable: false),
                    LesSequencia = table.Column<int>(nullable: false),
                    LesData = table.Column<DateTime>(nullable: false),
                    LesValor = table.Column<double>(nullable: false),
                    LesHistorico = table.Column<string>(nullable: true),
                    CtlSequencia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstornosLiquidacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstornosPAgamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    LoaAnoPag = table.Column<int>(nullable: false),
                    PagTipoEmp = table.Column<int>(nullable: false),
                    PagNumero = table.Column<int>(nullable: false),
                    PetSequencia = table.Column<int>(nullable: false),
                    PetData = table.Column<DateTime>(nullable: false),
                    PetValor = table.Column<double>(nullable: false),
                    PetHistorico = table.Column<string>(nullable: true),
                    CtlSequencia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstornosPAgamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstornosPagamentosRetencoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    LoaAnoPag = table.Column<int>(nullable: false),
                    PagTipoEmp = table.Column<int>(nullable: false),
                    PagNumero = table.Column<int>(nullable: false),
                    PetSequencia = table.Column<int>(nullable: false),
                    PerValor = table.Column<double>(nullable: false),
                    PlnTipoPlano = table.Column<int>(nullable: false),
                    PlnCodigo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstornosPagamentosRetencoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstornosRetencoesLiquidacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    LiqTipo = table.Column<int>(nullable: false),
                    LiqSequencia = table.Column<int>(nullable: false),
                    LesSequencia = table.Column<int>(nullable: false),
                    LoaAnoRet = table.Column<int>(nullable: false),
                    RleData = table.Column<DateTime>(nullable: false),
                    RleValor = table.Column<double>(nullable: false),
                    PlnTipoPlano = table.Column<int>(nullable: false),
                    PlnCodigo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstornosRetencoesLiquidacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LiquidacaoNotaExtraOrcamentarias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    ExtNumero = table.Column<int>(nullable: false),
                    LixSequencia = table.Column<int>(nullable: false),
                    LixData = table.Column<DateTime>(nullable: false),
                    LixDataVencto = table.Column<DateTime>(nullable: false),
                    LixValor = table.Column<double>(nullable: false),
                    LixHistorico = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiquidacaoNotaExtraOrcamentarias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Liquidacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    LiqTipo = table.Column<int>(nullable: false),
                    LiqSequencia = table.Column<int>(nullable: false),
                    LoaAnoEmp = table.Column<int>(nullable: false),
                    EmpNro = table.Column<int>(nullable: false),
                    EmpSub = table.Column<int>(nullable: false),
                    LiqData = table.Column<DateTime>(nullable: false),
                    LiqDataVencto = table.Column<DateTime>(nullable: false),
                    LiqValor = table.Column<double>(nullable: false),
                    LiqHistorico = table.Column<string>(nullable: true),
                    CtlSequencia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Liquidacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotaExtraOrcamentarias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    ExtNumero = table.Column<int>(nullable: false),
                    ExtTipoOrigem = table.Column<int>(nullable: false),
                    ExtDataEmissao = table.Column<DateTime>(nullable: false),
                    ExtDataVencto = table.Column<DateTime>(nullable: false),
                    ExtValor = table.Column<double>(nullable: false),
                    ExtHistorico = table.Column<string>(nullable: true),
                    ExtDataEstorno = table.Column<DateTime>(nullable: false),
                    ExtFlagEstorno = table.Column<int>(nullable: false),
                    UniCpfCnpj = table.Column<string>(nullable: true),
                    UniNomeRazao = table.Column<string>(nullable: true),
                    PlnTipoPlano = table.Column<int>(nullable: false),
                    PlnCodigo = table.Column<string>(nullable: true),
                    Vincodigo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaExtraOrcamentarias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pagamentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    PagTipoEmp = table.Column<int>(nullable: false),
                    PagNumero = table.Column<int>(nullable: false),
                    PagTipo = table.Column<int>(nullable: false),
                    PagTipoRetencao = table.Column<int>(nullable: false),
                    PagData = table.Column<DateTime>(nullable: false),
                    PagDocumento = table.Column<string>(nullable: true),
                    PagValor = table.Column<double>(nullable: false),
                    PagHistorico = table.Column<string>(nullable: true),
                    LoaAnoLiq = table.Column<int>(nullable: false),
                    LiqTipo = table.Column<int>(nullable: false),
                    LiqSequencia = table.Column<int>(nullable: false),
                    LoaAnoLix = table.Column<int>(nullable: false),
                    LixSequencia = table.Column<int>(nullable: false),
                    PlnTipoPlano = table.Column<int>(nullable: false),
                    PlnCodigo = table.Column<string>(nullable: true),
                    CtlSequenncia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pagamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PagamentosRetencoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    PagTipoEmp = table.Column<int>(nullable: false),
                    PagNumero = table.Column<int>(nullable: false),
                    PrtValor = table.Column<double>(nullable: false),
                    PlnTipoPlano = table.Column<int>(nullable: false),
                    PlnCodigo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagamentosRetencoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReceitaExtraOrcamentaria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    RxtSequencia = table.Column<int>(nullable: false),
                    RxData = table.Column<DateTime>(nullable: false),
                    RxtValor = table.Column<double>(nullable: false),
                    RxtHistorico = table.Column<string>(nullable: true),
                    RxtTipoDocumento = table.Column<int>(nullable: false),
                    RxtNroDocumento = table.Column<string>(nullable: true),
                    PlnTipoPlanoBanco = table.Column<int>(nullable: false),
                    PlnCodigoBanco = table.Column<string>(nullable: true),
                    PlntipoPlano = table.Column<int>(nullable: false),
                    PlnCodigo = table.Column<string>(nullable: true),
                    VinCodigo = table.Column<int>(nullable: false),
                    CtlSequencia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReceitaExtraOrcamentaria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RetencaoLiquidacoes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    LoaAno = table.Column<int>(nullable: false),
                    LiqTipo = table.Column<int>(nullable: false),
                    LiqSequencia = table.Column<int>(nullable: false),
                    MyProperty = table.Column<int>(nullable: false),
                    PlnCodigo = table.Column<string>(nullable: true),
                    RtlValor = table.Column<double>(nullable: false),
                    CtlSequencia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RetencaoLiquidacoes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TransferenciasFinanceiras",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    CliCodigo = table.Column<int>(nullable: false),
                    TrnSequencia = table.Column<int>(nullable: false),
                    TrnTipo = table.Column<int>(nullable: false),
                    TrnData = table.Column<DateTime>(nullable: false),
                    TrnValor = table.Column<double>(nullable: false),
                    TrnHistorico = table.Column<string>(nullable: true),
                    TrnTipoDocumento = table.Column<int>(nullable: false),
                    TrnNroDocumento = table.Column<string>(nullable: true),
                    PlnTipoPlano = table.Column<int>(nullable: false),
                    PlncodigoBanco = table.Column<string>(nullable: true),
                    PlnCodigo = table.Column<string>(nullable: true),
                    VinCodigo = table.Column<int>(nullable: false),
                    CtlSequencia = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransferenciasFinanceiras", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AlteracaoOrcamentarias");

            migrationBuilder.DropTable(
                name: "Empenhos");

            migrationBuilder.DropTable(
                name: "EstornoEmpenhos");

            migrationBuilder.DropTable(
                name: "EstornoReceitaOrcamentarias");

            migrationBuilder.DropTable(
                name: "EstornosLiquidacoes");

            migrationBuilder.DropTable(
                name: "EstornosPAgamentos");

            migrationBuilder.DropTable(
                name: "EstornosPagamentosRetencoes");

            migrationBuilder.DropTable(
                name: "EstornosRetencoesLiquidacoes");

            migrationBuilder.DropTable(
                name: "LiquidacaoNotaExtraOrcamentarias");

            migrationBuilder.DropTable(
                name: "Liquidacoes");

            migrationBuilder.DropTable(
                name: "NotaExtraOrcamentarias");

            migrationBuilder.DropTable(
                name: "Pagamentos");

            migrationBuilder.DropTable(
                name: "PagamentosRetencoes");

            migrationBuilder.DropTable(
                name: "ReceitaExtraOrcamentaria");

            migrationBuilder.DropTable(
                name: "RetencaoLiquidacoes");

            migrationBuilder.DropTable(
                name: "TransferenciasFinanceiras");
        }
    }
}
