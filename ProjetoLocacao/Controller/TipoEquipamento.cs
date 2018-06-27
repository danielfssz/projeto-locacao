using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocacao.Controller
{
    class TipoEquipamento
    {
        public int TipoEquipId { get; set; }

        public string Nome { get; set; }

        public double Valor { get; set; }

        Queue<Equipamento> equipos = new Queue<Equipamento>();
        
    }
}
