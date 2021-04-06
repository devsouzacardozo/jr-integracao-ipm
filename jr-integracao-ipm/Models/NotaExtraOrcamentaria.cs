using jrintegracaoipm.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models
    {
    public class NotaExtraOrcamentaria
        {
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public int ExtNumero { get; set; }
        public TipoNotaExtra ExtTipoOrigem { get; set; }
        public DateTime ExtDataEmissao { get; set; }
        public DateTime ExtDataVencto { get; set; }
        public double ExtValor { get; set; }
        public string ExtHistorico { get; set; }
        public DateTime ExtDataEstorno { get; set; }
        public IndicativoBooleano ExtFlagEstorno { get; set; }
        public string UniCpfCnpj { get; set; }
        public string UniNomeRazao { get; set; }
        public TipoPlano PlnTipoPlano { get; set; }
        public string PlnCodigo { get; set; }
        public int Vincodigo { get; set; }
        }
    }
