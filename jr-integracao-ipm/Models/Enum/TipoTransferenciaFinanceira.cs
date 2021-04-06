using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models.Enum
    {
    public enum TipoTransferenciaFinanceira : int
        {
        TransferenciaFinanceiraConcedida = 1,
        TransferenciaFinanceiraRecebida = 2,
        TransferenciaFinanceiraConcedida_Legislativo = 3,  // Entidade Prefeitura
        TransferenciaFinanceiraRecebida_Legislativo = 4   // Entidade Câmara
        }
    }
