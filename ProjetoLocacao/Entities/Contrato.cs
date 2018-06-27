﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocacao.Entities
{
    class Contrato
    {
        public int ContratoId { get; set; }

        public DateTime DtSaida { get; set; }

        public DateTime DtRetorno { get; set; }

        List<ItemContrato> itensContrato = new List<ItemContrato>();

        public Contrato(DateTime dataSaida, DateTime dataRetorno, List<ItemContrato> lstItensContrato)
        {
            DtSaida = dataSaida;
            DtRetorno = dataRetorno;
            itensContrato = lstItensContrato;
        }
    }
}