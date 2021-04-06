using jrintegracaoipm.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models
    {
    public class EstornoPagamentoRetencao
        {
        public int Id { get; set; }
        public int CliCodigo { get; set; }
        public int LoaAno { get; set; }
        public int LoaAnoPag { get; set; }
        public TipoPagamento PagTipoEmp { get; set; }
        public int PagNumero { get; set; }
        public int PetSequencia { get; set; }
        public double PerValor { get; set; }
        public TipoPlano PlnTipoPlano { get; set; }
        public string PlnCodigo { get; set; }
        }
    }
