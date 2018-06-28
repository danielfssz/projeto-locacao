using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocacao.Controller
{
    class TipoEquipamento
    {
        #region atributos

        public int TipoEquipId { get; set; }
        public string Nome { get; set; }
        public double Valor { get; set; }
        public Queue<Equipamento> equipos;

        #endregion

        #region contrutores

        public TipoEquipamento(int id, string nome, double valor)
        {
            TipoEquipId = id;
            Nome = nome;
            Valor = valor;
            equipos = new Queue<Equipamento>();
        }
        public TipoEquipamento(int idEqp)
        {
            TipoEquipId = idEqp;
        }

        public TipoEquipamento()
        {
        }

        #endregion

        #region métodos
                
        public override bool Equals(object obj)
        {
            return this.TipoEquipId.Equals(((TipoEquipamento)obj).TipoEquipId);
        }
        #endregion
    }
}
