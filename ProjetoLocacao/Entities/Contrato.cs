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

        internal List<ItemContrato> ItensContrato
        {
            get
            {
                return itensContrato;
            }            
        }

        List<ItemContrato> itensContrato;
        #endregion

        #region métodos
        public Contrato(int id, DateTime dataSaida, DateTime dataRetorno, List<ItemContrato> lstItensContrato)
        {
            ContratoId = id;
            DtSaida = dataSaida;
            DtRetorno = dataRetorno;
            itensContrato = lstItensContrato;
        }

        public Contrato(int id)
        {
            ContratoId = id;
        }

        public Contrato() { }
        #endregion

        public override bool Equals(object obj)
        {
            return this.ContratoId.Equals(((Contrato)obj).ContratoId);
        }
    }
}
