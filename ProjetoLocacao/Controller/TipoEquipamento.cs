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

            public TipoEquipamento(string nome, double valor)
            {
                TipoEquipId = cadastrarID();
                Nome = nome;
                Valor = valor;
                equipos = new Queue<Equipamento>();
            }

        #endregion

        #region métodos

            public int cadastrarID()
            {
                int aux = TipoEquipId;
                TipoEquipId++;
                return aux;
            }

        #endregion
    }
}
