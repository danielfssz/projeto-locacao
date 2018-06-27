using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocacao.Controller
{
    class Equipamento
    {
        #region atributos

            public int EquipId { get; set; }
            public string Patrimonio { get; set; }
            public bool Avariado { get; set; }

        #endregion

        #region construtores

            public Equipamento(int id, TipoEquipamento tipo)
            {
                EquipId = id;
                Patrimonio = tipo.Nome + id;
                Avariado = false;
            }

        #endregion
    }
}
