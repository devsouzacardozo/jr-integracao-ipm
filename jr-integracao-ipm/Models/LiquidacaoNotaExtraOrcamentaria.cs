using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models
    {
    public class LiquidacaoNotaExtraOrcamentaria
        {
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public int ExtNumero { get; set; }
        public int LixSequencia { get; set; }
        public DateTime LixData { get; set; }
        public DateTime LixDataVencto { get; set; }
        public double LixValor { get; set; }
        public int LixHistorico { get; set; }
        }
    }
