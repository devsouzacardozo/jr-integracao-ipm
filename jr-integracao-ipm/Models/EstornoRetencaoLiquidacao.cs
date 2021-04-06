using jrintegracaoipm.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models
    {
    public class EstornoRetencaoLiquidacao
        {
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public TipoLiquidacao LiqTipo  { get; set; }
        public int LiqSequencia { get; set; }
        public int LesSequencia { get; set; }
        public int LoaAnoRet { get; set; }
        public DateTime RleData { get; set; }
        public double RleValor { get; set; }
        public TipoPlano PlnTipoPlano { get; set; }
        public string PlnCodigo { get; set; }
        }
    }
