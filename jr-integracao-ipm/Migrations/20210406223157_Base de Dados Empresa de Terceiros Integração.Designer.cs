﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using jrintegracaoipm.Data;

namespace jrintegracaoipm.Migrations
{
    [DbContext(typeof(IntegracaoContext))]
    [Migration("20210406223157_Base de Dados Empresa de Terceiros Integração")]
    partial class BasedeDadosEmpresadeTerceirosIntegração
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("jrintegracaoipm.Models.AlteracaoOrcamentaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AcoCodigo");

                    b.Property<int>("AcoTipo");

                    b.Property<int>("AloData");

                    b.Property<int>("AloNumero");

                    b.Property<int>("CliCodigo");

                    b.Property<int>("FaoSequencia");

                    b.Property<int>("FaoTipo");

                    b.Property<int>("FaoTipoCredito");

                    b.Property<int>("FaoTipoFonte");

                    b.Property<double>("FaoValor");

                    b.Property<int>("LoaAno");

                    b.Property<int>("Orgcodigo");

                    b.Property<int>("PgrCodigo");

                    b.Property<int>("TfcCodigo");

                    b.Property<int>("TsfCodigo");

                    b.Property<int>("Undcodigo");

                    b.HasKey("Id");

                    b.ToTable("AlteracaoOrcamentarias");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.Empenho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AcoCodigo");

                    b.Property<int>("AcoTipo");

                    b.Property<int>("CliCodigo");

                    b.Property<int>("CtlSequencia");

                    b.Property<int>("EmpAnoBaixaResto");

                    b.Property<int>("EmpAnoInscResto");

                    b.Property<DateTime>("EmpDataEmissao");

                    b.Property<DateTime>("EmpDataVencimento");

                    b.Property<int>("EmpEspecie");

                    b.Property<string>("EmpHistorico");

                    b.Property<int>("EmpNro");

                    b.Property<int>("EmpSub");

                    b.Property<double>("EmpValor");

                    b.Property<int>("LoaAno");

                    b.Property<int>("OrgCodigo");

                    b.Property<int>("PgrCodigo");

                    b.Property<string>("PlnCodigo");

                    b.Property<string>("PlnCodigoDotacao");

                    b.Property<int>("PlnTipoPlano");

                    b.Property<int>("TfcCodigo");

                    b.Property<int>("TsfCodigo");

                    b.Property<int>("UndCodigo");

                    b.Property<string>("UniCpfCnpj");

                    b.Property<string>("UniNomeRazao");

                    b.Property<int>("VinCodigo");

                    b.HasKey("Id");

                    b.ToTable("Empenhos");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.EstornoEmpenho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<int>("CtlSequencia");

                    b.Property<int>("EmpNro");

                    b.Property<int>("EmpSup");

                    b.Property<DateTime>("EstData");

                    b.Property<string>("EstHistorico");

                    b.Property<int>("EstSequencia");

                    b.Property<int>("EstTipoCancResto");

                    b.Property<double>("EstValor");

                    b.Property<int>("LoaAno");

                    b.Property<int>("LoaAnoEmp");

                    b.HasKey("Id");

                    b.ToTable("EstornoEmpenhos");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.EstornoLiquidacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<int>("CtlSequencia");

                    b.Property<DateTime>("LesData");

                    b.Property<string>("LesHistorico");

                    b.Property<int>("LesSequencia");

                    b.Property<double>("LesValor");

                    b.Property<int>("LiqSequencia");

                    b.Property<int>("LiqTipo");

                    b.Property<int>("LoaAno");

                    b.Property<int>("LoaAnoLiq");

                    b.HasKey("Id");

                    b.ToTable("EstornosLiquidacoes");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.EstornoPagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<int>("CtlSequencia");

                    b.Property<int>("LoaAno");

                    b.Property<int>("LoaAnoPag");

                    b.Property<int>("PagNumero");

                    b.Property<int>("PagTipoEmp");

                    b.Property<DateTime>("PetData");

                    b.Property<string>("PetHistorico");

                    b.Property<int>("PetSequencia");

                    b.Property<double>("PetValor");

                    b.HasKey("Id");

                    b.ToTable("EstornosPAgamentos");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.EstornoPagamentoRetencao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<int>("LoaAno");

                    b.Property<int>("LoaAnoPag");

                    b.Property<int>("PagNumero");

                    b.Property<int>("PagTipoEmp");

                    b.Property<double>("PerValor");

                    b.Property<int>("PetSequencia");

                    b.Property<string>("PlnCodigo");

                    b.Property<int>("PlnTipoPlano");

                    b.HasKey("Id");

                    b.ToTable("EstornosPagamentosRetencoes");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.EstornoReceitaOrcamentaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<int>("CtlSequencia");

                    b.Property<DateTime>("EsrDataEstorno");

                    b.Property<string>("EsrHistorico");

                    b.Property<string>("EsrNroDocumento");

                    b.Property<int>("EsrSequencia");

                    b.Property<int>("EsrTipo");

                    b.Property<int>("EsrTipoDocumento");

                    b.Property<double>("EsrValor");

                    b.Property<int>("LoaAno");

                    b.Property<string>("PlnCodigo");

                    b.Property<string>("PlnCodigoBanco");

                    b.Property<int>("PlnTipoPlano");

                    b.Property<int>("PlnTipoPlanoBanco");

                    b.Property<int>("RecSequencia");

                    b.Property<int>("VinCodigo");

                    b.HasKey("Id");

                    b.ToTable("EstornoReceitaOrcamentarias");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.EstornoRetencaoLiquidacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<int>("LesSequencia");

                    b.Property<int>("LiqSequencia");

                    b.Property<int>("LiqTipo");

                    b.Property<int>("LoaAno");

                    b.Property<int>("LoaAnoRet");

                    b.Property<string>("PlnCodigo");

                    b.Property<int>("PlnTipoPlano");

                    b.Property<DateTime>("RleData");

                    b.Property<double>("RleValor");

                    b.HasKey("Id");

                    b.ToTable("EstornosRetencoesLiquidacoes");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.Lancamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<int>("CtlSequencia");

                    b.Property<int>("FlagEstorno");

                    b.Property<DateTime>("LanData");

                    b.Property<string>("LanHistorico");

                    b.Property<double>("LanValor");

                    b.Property<int>("LoaAno");

                    b.Property<string>("PlnCodigoContra");

                    b.Property<int>("PlnTipoPlano");

                    b.Property<int>("PlnTipoPlanoContra");

                    b.Property<string>("Plncodigo");

                    b.Property<int>("TlcCodigo");

                    b.Property<int>("VinCodigo");

                    b.HasKey("Id");

                    b.ToTable("Lancamentos");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.Liquidacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<int>("CtlSequencia");

                    b.Property<int>("EmpNro");

                    b.Property<int>("EmpSub");

                    b.Property<DateTime>("LiqData");

                    b.Property<DateTime>("LiqDataVencto");

                    b.Property<string>("LiqHistorico");

                    b.Property<int>("LiqSequencia");

                    b.Property<int>("LiqTipo");

                    b.Property<double>("LiqValor");

                    b.Property<int>("LoaAno");

                    b.Property<int>("LoaAnoEmp");

                    b.HasKey("Id");

                    b.ToTable("Liquidacoes");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.LiquidacaoNotaExtraOrcamentaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<int>("ExtNumero");

                    b.Property<DateTime>("LixData");

                    b.Property<DateTime>("LixDataVencto");

                    b.Property<int>("LixHistorico");

                    b.Property<int>("LixSequencia");

                    b.Property<double>("LixValor");

                    b.Property<int>("LoaAno");

                    b.HasKey("Id");

                    b.ToTable("LiquidacaoNotaExtraOrcamentarias");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.NotaExtraOrcamentaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<DateTime>("ExtDataEmissao");

                    b.Property<DateTime>("ExtDataEstorno");

                    b.Property<DateTime>("ExtDataVencto");

                    b.Property<int>("ExtFlagEstorno");

                    b.Property<string>("ExtHistorico");

                    b.Property<int>("ExtNumero");

                    b.Property<int>("ExtTipoOrigem");

                    b.Property<double>("ExtValor");

                    b.Property<int>("LoaAno");

                    b.Property<string>("PlnCodigo");

                    b.Property<int>("PlnTipoPlano");

                    b.Property<string>("UniCpfCnpj");

                    b.Property<string>("UniNomeRazao");

                    b.Property<int>("Vincodigo");

                    b.HasKey("Id");

                    b.ToTable("NotaExtraOrcamentarias");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<int>("CtlSequenncia");

                    b.Property<int>("LiqSequencia");

                    b.Property<int>("LiqTipo");

                    b.Property<int>("LixSequencia");

                    b.Property<int>("LoaAno");

                    b.Property<int>("LoaAnoLiq");

                    b.Property<int>("LoaAnoLix");

                    b.Property<DateTime>("PagData");

                    b.Property<string>("PagDocumento");

                    b.Property<string>("PagHistorico");

                    b.Property<int>("PagNumero");

                    b.Property<int>("PagTipo");

                    b.Property<int>("PagTipoEmp");

                    b.Property<int>("PagTipoRetencao");

                    b.Property<double>("PagValor");

                    b.Property<string>("PlnCodigo");

                    b.Property<int>("PlnTipoPlano");

                    b.HasKey("Id");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.PagamentoRetencao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<int>("LoaAno");

                    b.Property<int>("PagNumero");

                    b.Property<int>("PagTipoEmp");

                    b.Property<string>("PlnCodigo");

                    b.Property<int>("PlnTipoPlano");

                    b.Property<double>("PrtValor");

                    b.HasKey("Id");

                    b.ToTable("PagamentosRetencoes");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.ReceitaExtraOrcamentaria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<int>("CtlSequencia");

                    b.Property<int>("LoaAno");

                    b.Property<string>("PlnCodigo");

                    b.Property<string>("PlnCodigoBanco");

                    b.Property<int>("PlnTipoPlanoBanco");

                    b.Property<int>("PlntipoPlano");

                    b.Property<DateTime>("RxData");

                    b.Property<string>("RxtHistorico");

                    b.Property<string>("RxtNroDocumento");

                    b.Property<int>("RxtSequencia");

                    b.Property<int>("RxtTipoDocumento");

                    b.Property<double>("RxtValor");

                    b.Property<int>("VinCodigo");

                    b.HasKey("Id");

                    b.ToTable("ReceitaExtraOrcamentaria");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.RetencaoLiquidacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<int>("CtlSequencia");

                    b.Property<int>("LiqSequencia");

                    b.Property<int>("LiqTipo");

                    b.Property<int>("LoaAno");

                    b.Property<int>("MyProperty");

                    b.Property<string>("PlnCodigo");

                    b.Property<double>("RtlValor");

                    b.HasKey("Id");

                    b.ToTable("RetencaoLiquidacoes");
                });

            modelBuilder.Entity("jrintegracaoipm.Models.TransferenciaFinanceira", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CliCodigo");

                    b.Property<int>("CtlSequencia");

                    b.Property<string>("PlnCodigo");

                    b.Property<int>("PlnTipoPlano");

                    b.Property<string>("PlncodigoBanco");

                    b.Property<DateTime>("TrnData");

                    b.Property<string>("TrnHistorico");

                    b.Property<string>("TrnNroDocumento");

                    b.Property<int>("TrnSequencia");

                    b.Property<int>("TrnTipo");

                    b.Property<int>("TrnTipoDocumento");

                    b.Property<double>("TrnValor");

                    b.Property<int>("VinCodigo");

                    b.HasKey("Id");

                    b.ToTable("TransferenciasFinanceiras");
                });
#pragma warning restore 612, 618
        }
    }
}
