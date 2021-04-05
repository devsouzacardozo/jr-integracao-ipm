using jrintegracaoipm.Models;
using Microsoft.EntityFrameworkCore;

namespace jrintegracaoipm.Data
{
    public class IntegracaoContext : DbContext
    {
        public DbSet<Lancamento> Lancamentos { get; set; }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
            {
            optionsBuilder.UseNpgsql("Host=localhost;Database=dbintegracao;Username=postgres;Password=jrb@nc0Post");
            }
        }
    
}
