using jrintegracaoipm.Models.Enum;
using System;

namespace jrintegracaoipm.Models
    {
    public class ReceitaOrcamentaria
        {
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public RecTipo RecTipo { get; set; }
        public int RecSequencia { get; set; }
        public DateTime RecData { get; set; }
        public RecTipoDeducao RecTipoDeducao { get; set; }
        public double RecValor { get; set; }
        public string RecHistorico { get; set; }
        public RecTipoDeducao RecTipoDocumento { get; set; }
        public string RecNroDocumento { get; set; }
        public TipoPlano PlnTipoPlanoBanco{ get; set; }  // PlnTipoPlanoBanco
        public string PlnCodigoBanco { get; set; }
        public TipoPlano PlnTipoPlano { get; set; }
        public string PlnCodigo { get; set; }
        public int VinCodigo { get; set; }
        public int CtlSequencia { get; set; }
        }
    }
