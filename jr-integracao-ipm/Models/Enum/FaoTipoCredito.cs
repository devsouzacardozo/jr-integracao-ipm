using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jrintegracaoipm.Models.Enum
    {
    public enum FaoTipoCredito : int
        {
           Suplementar = 1,
           Especial = 2,
           ExtraOrdinaria = 3,
           TransposicaoPorIncremento = 4,
           TransposicaoPorDecremento = 5,
           ReaberturaCreditoEspecial = 6,
           ReaberturaCreditoExtraordinario = 7,
           RemanejamentoEspecificoPR = 8,
           TransferenciaEspecificoPR = 9
        }
    }
