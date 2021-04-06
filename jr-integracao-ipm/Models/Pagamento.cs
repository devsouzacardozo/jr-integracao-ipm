using jrintegracaoipm.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models
    {
    public class Pagamento
        {
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public TipoPagamento PagTipoEmp { get; set; }
        public int PagNumero { get; set; }
        public TipoDocumentoBancario PagTipo { get; set; }
        public IndicativoBooleano PagTipoRetencao { get; set; }
        public DateTime PagData { get; set; }
        public string PagDocumento { get; set; }
        public double PagValor { get; set; }
        public string PagHistorico { get; set; }
        public int LoaAnoLiq { get; set; }
        public TipoLiquidacao LiqTipo { get; set; }
        public int LiqSequencia { get; set; }
        public int LoaAnoLix { get; set; }
        public int LixSequencia { get; set; }
        public TipoPlano PlnTipoPlano { get; set; }
        public string PlnCodigo { get; set; }
        public int CtlSequenncia { get; set; }
        }
    }
