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
            private int countPatrimonio = 1;

        #endregion

        #region construtores

            public Equipamento(TipoEquipamento tipo)
            {
                EquipId = cadastrarID();
                Patrimonio = gerarPatrimonio(tipo);
                Avariado = false;
            }

        #endregion

        #region métodos

            public string gerarPatrimonio(TipoEquipamento tipo)
            {
                int aux = countPatrimonio;
                countPatrimonio++;
                return tipo.Nome + aux;
            }

            public int cadastrarID()
            {
                int aux = EquipId;
                EquipId++;
                return aux;
            }

        #endregion
    }
}
