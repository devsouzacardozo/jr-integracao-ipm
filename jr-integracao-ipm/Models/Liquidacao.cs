using jrintegracaoipm.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models
    {
    public class Liquidacao
        {
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public TipoLiquidacao LiqTipo { get; set; }
        public int LiqSequencia { get; set; }
        public int LoaAnoEmp { get; set; }
        public int EmpNro { get; set; }
        public int EmpSub { get; set; }
        public DateTime LiqData { get; set; }
        public DateTime LiqDataVencto { get; set; }
        public double LiqValor { get; set; }
        public string LiqHistorico { get; set; }
        public int CtlSequencia { get; set; }
        }
    }
