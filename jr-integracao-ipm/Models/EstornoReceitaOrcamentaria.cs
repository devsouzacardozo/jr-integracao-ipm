using jrintegracaoipm.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models
    {
    public class EstornoReceitaOrcamentaria
        {
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public int RecSequencia { get; set; }
        public int EsrSequencia { get; set; }
        public RecTipo EsrTipo { get; set; }
        public DateTime EsrDataEstorno { get; set; }
        public double EsrValor { get; set; }
        public string EsrHistorico { get; set; }
        public TipoDocumentoBancario EsrTipoDocumento { get; set; }
        public string EsrNroDocumento { get; set; }
        public TipoPlano PlnTipoPlanoBanco { get; set; }
        public string PlnCodigoBanco { get; set; }
        public TipoPlano PlnTipoPlano { get; set; }
        public string PlnCodigo { get; set; }
        public int VinCodigo { get; set; }
        public int CtlSequencia { get; set; }
        }
    }
