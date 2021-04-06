using jrintegracaoipm.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models
    {
    public class RetencaoLiquidacao
        {
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public TipoLiquidacao LiqTipo { get; set; }
        public int LiqSequencia { get; set; }
        public TipoPlano MyProperty { get; set; }
        public string PlnCodigo { get; set; }
        public double RtlValor { get; set; }
        public int CtlSequencia { get; set; }

        }
    }
