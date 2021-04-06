using jrintegracaoipm.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models
    {
    public class EstornoLiquidacao
        {
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public int LoaAnoLiq { get; set; }
        public TipoLiquidacao LiqTipo { get; set; }
        public int LiqSequencia { get; set; }
        public int LesSequencia { get; set; }
        public DateTime LesData { get; set; }
        public double LesValor { get; set; }
        public string LesHistorico { get; set; }
        public int CtlSequencia { get; set; }
        }
    }
