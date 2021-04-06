using jrintegracaoipm.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models
    {
    public class Lancamento
        {
        public int Id {get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public int CtlSequencia { get; set; }
        public DateTime LanData { get; set; }
        public string LanHistorico { get; set; }
        public double LanValor { get; set; }
        public IndicativoBooleano FlagEstorno { get; set; }
        public TlcCodigo TlcCodigo  { get; set; }
        public TipoPlano PlnTipoPlano{ get; set; }
        public string Plncodigo { get; set; }
        public TipoPlano PlnTipoPlanoContra { get; set; }
        public string PlnCodigoContra { get; set; }
        public int VinCodigo { get; set; }
        }
    }
