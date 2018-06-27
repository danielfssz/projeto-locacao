using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoLocacao.Controller;

namespace ProjetoLocacao.Entities
{
    class ItemContrato
    {
        #region atributos
            public TipoEquipamento TipoEquipamento { get; set; }
            public int Qtde { get; set; }
            Stack<Equipamento> EquipamentosRetirados = new Stack<Equipamento>();
        #endregion

        #region construtores
            public ItemContrato(TipoEquipamento tipoEqpo, int qtdeRetirada)
            {
                TipoEquipamento = tipoEqpo;
                Qtde = qtdeRetirada;

                for (int i = 0; i < qtdeRetirada; i++)
                {
                    EquipamentosRetirados.Push(tipoEqpo.equipos.Dequeue());
                }
            }
        #endregion
    }
}
