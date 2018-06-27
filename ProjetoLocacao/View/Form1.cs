using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoLocacao.Entities;

namespace ProjetoLocacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ItemContrato> listaItens = new List<Entities.ItemContrato>();

            Contrato contrato = new Contrato(DateTime.Now, Convert.ToDateTime("12-12-2019"), listaItens);
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }
        
    }

}
