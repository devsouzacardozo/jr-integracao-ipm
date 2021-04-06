using jrintegracaoipm.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models
    {
    public class TransferenciaFinanceira
        {
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int TrnSequencia { get; set; }
        public TipoTransferenciaFinanceira TrnTipo { get; set; }
        public DateTime TrnData { get; set; }
        public double TrnValor { get; set; }
        public string TrnHistorico { get; set; }
        public TipoDocumentoBancario TrnTipoDocumento { get; set; }
        public string TrnNroDocumento { get; set; }
        public TipoPlano PlnTipoPlano { get; set; }
        public string PlncodigoBanco { get; set; }
        public string PlnCodigo { get; set; }
        public int VinCodigo { get; set; }
        public int CtlSequencia { get; set; }
        }
    }
