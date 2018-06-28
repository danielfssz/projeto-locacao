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
        public int Id { get; set; }
        public TipoEquipamento TipoEquipamento { get; set; }
        public int Qtde { get; set; }
        public Stack<Equipamento> EquipamentosRetirados = new Stack<Equipamento>();
        #endregion

        #region construtores
        public ItemContrato(int id, TipoEquipamento tipoEqpo, int qtdeRetirada)
        {
            this.Id = id;
            TipoEquipamento = tipoEqpo;
            Qtde = qtdeRetirada;
        }
        public ItemContrato(int id)
        {
            this.Id = id;
        }

        public ItemContrato()
        {

        }

        #endregion

        public override bool Equals(object obj)
        {
            return this.Id.Equals(((ItemContrato)obj).Id);
        }
    }
}
