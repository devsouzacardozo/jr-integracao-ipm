using jrintegracaoipm.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models
    {
    public class ReceitaExtraOrcamentaria
        {
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public int RxtSequencia { get; set; }
        public DateTime RxData { get; set; }
        public double RxtValor { get; set; }
        public string RxtHistorico { get; set; }
        public TipoDocumentoBancario RxtTipoDocumento  { get; set; }
        public string RxtNroDocumento { get; set; }
        public TipoPlano PlnTipoPlanoBanco { get; set; }
        public string PlnCodigoBanco { get; set; }
        public TipoPlano PlntipoPlano  { get; set; }
        public string PlnCodigo { get; set; }
        public int VinCodigo { get; set; }
        public int CtlSequencia { get; set; }

        }
    }
