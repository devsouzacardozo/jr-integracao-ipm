using jrintegracaoipm.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models
    {
    public class Empenho
        { 
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public int EmpNro { get; set; }
        public int EmpSub { get; set; }
        public int EmpEspecie { get; set; }
        public int EmpAnoInscResto { get; set; }
        public int EmpAnoBaixaResto { get; set; }
        public DateTime EmpDataEmissao { get; set; }
        public DateTime EmpDataVencimento { get; set; }
        public double EmpValor { get; set; }
        public string EmpHistorico { get; set; }
        public string UniCpfCnpj { get; set; }
        public string UniNomeRazao { get; set; }
        public TipoPlano PlnTipoPlano { get; set; }
        public string PlnCodigo { get; set; }
        public int OrgCodigo { get; set; }
        public int UndCodigo { get; set; }
        public int TfcCodigo { get; set; }
        public int TsfCodigo { get; set; }
        public int PgrCodigo { get; set; }
        public AcoTipo AcoTipo { get; set; }
        public int AcoCodigo { get; set; }
        public int VinCodigo { get; set; }
        public string PlnCodigoDotacao { get; set; }
        public int CtlSequencia { get; set; }
        }
    }
