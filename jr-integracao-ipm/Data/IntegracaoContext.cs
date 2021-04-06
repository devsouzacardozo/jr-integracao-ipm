using jrintegracaoipm.Models;
using Microsoft.EntityFrameworkCore;

namespace jrintegracaoipm.Data
{
    public class IntegracaoContext : DbContext
    {
        public DbSet<Lancamento> Lancamentos { get; set; }
        public DbSet<AlteracaoOrcamentaria> AlteracaoOrcamentarias { get; set; }
        public DbSet<ReceitaExtraOrcamentaria> ReceitaOrcamentarias { get; set; }
        public DbSet<EstornoReceitaOrcamentaria> EstornoReceitaOrcamentarias { get; set; }
        public DbSet<ReceitaExtraOrcamentaria> ReceitaExtraOrcamentarias { get; set; }
        public DbSet<Empenho> Empenhos { get; set; }
        public DbSet<EstornoEmpenho> EstornoEmpenhos { get; set; }
        public DbSet<Liquidacao> Liquidacoes { get; set; }
        public DbSet<EstornoLiquidacao> EstornosLiquidacoes { get; set; }
        public DbSet<LiquidacaoNotaExtraOrcamentaria> LiquidacaoNotaExtraOrcamentarias { get; set; }
        public DbSet<RetencaoLiquidacao> RetencaoLiquidacoes { get; set; }
        public DbSet<EstornoRetencaoLiquidacao> EstornosRetencoesLiquidacoes { get; set; }
        public DbSet<NotaExtraOrcamentaria> NotaExtraOrcamentarias { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<EstornoPagamento> EstornosPAgamentos{ get; set; }
        public DbSet<PagamentoRetencao> PagamentosRetencoes { get; set; }
        public DbSet<EstornoPagamentoRetencao> EstornosPagamentosRetencoes{ get; set; }
        public DbSet<TransferenciaFinanceira> TransferenciasFinanceiras { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
            {
            optionsBuilder.UseNpgsql("Host=localhost;Database=dbintegracao;Username=postgres;Password=jrb@nc0Post");
            }
        }
    
}
