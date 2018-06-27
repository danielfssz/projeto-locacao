using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocacao.Entities
{
    class Contrato
    {
        #region atributos
            public int ContratoId { get; set; }
            public DateTime DtSaida { get; set; }
            public DateTime DtRetorno { get; set; }
            public List<ItemContrato> itensContrato = new List<ItemContrato>();
        #endregion

        #region métodos
            public Contrato(int id, DateTime dataSaida, DateTime dataRetorno, List<ItemContrato> lstItensContrato)
            {
                ContratoId = id;
                DtSaida = dataSaida;
                DtRetorno = dataRetorno;
                itensContrato = lstItensContrato;
            }
        #endregion
    }
}
