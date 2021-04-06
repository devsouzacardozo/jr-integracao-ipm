using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models.Enum
    {
    public enum TipoDocumentoBancario : int
        {
          ChequeEmitidos = 1,
          AvisosDeDebito = 2,
          Bordero = 3,
          EncontroDeContas = 5,
          Doc = 6,
          Ted = 7,
          OrdemDePagamento = 8,
          DepositoBancario = 9,
          DebitoBancario = 10,
          PagamentoPeloBRDEFornecedor = 11,
          CreditoDepositoRecebido = 13,
          Saque = 14,
          DebitoNaContaPagamentoDeBoletoBancario = 15,
          Retencao = 99  //Apenas para dados de Pagamento
        }
    }
