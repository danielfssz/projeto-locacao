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
using ProjetoLocacao.Controller;

namespace ProjetoLocacao
{
    public partial class Form1 : Form
    {
        //como n tem interação com o banco a "persistência" dos dados
        //é feita nessas duas listas
        List<TipoEquipamento> Estoque = new List<TipoEquipamento>();
        List<Contrato> Contratos = new List<Contrato>();

        List<ItemContrato> itensContrato = new List<ItemContrato>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ItemContrato> listaItens = new List<Entities.ItemContrato>();

            Contrato contrato = new Contrato(DateTime.Now, Convert.ToDateTime("12-12-2019"), listaItens);
        }

        // botão para adicionar itens de contrato
        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            TipoEquipamento tipoItemContrato = null;

            //percorre todos os tipos de equipamentos do estoque
            for (int i = 0; i < Estoque.Count; i++)
            {
                //quando o item selecionado no combobox for igual
                //a algum da lista de estoque ele adiciona o valor da variável
                if (cmbTipoItem.Text == Estoque[i].Nome)
                {
                    tipoItemContrato = Estoque[i];
                }
            }

            //se tiver equipamentos suficientes no estoque
            //adiciona um item novo na lista de contratos
            if (tipoItemContrato.equipos.Count >= int.Parse(nmItemQtd.Text))
            {
                itensContrato.Add(new ItemContrato(tipoItemContrato, int.Parse(nmItemQtd.Text)));
            }
            else
            {
                MessageBox.Show("Não há equipamentos suficientes no estoque!");
            }

            //mostra os itens na lista
            lstItens.Items.Clear();
            foreach(ItemContrato ic in itensContrato)
            {
                lstItens.Items.Add("Tipo: " + ic.TipoEquipamento.Nome + " | Quantidade: " + ic.Qtde);
            }
        }

        // botão pra cadastrar tipos de equipamento
        private void btnCadastrarTipo_Click(object sender, EventArgs e)
        {
            string nome = tbNomeTipo.Text;

            double valor;

            //se o valor da textbox de valor for numérico, converte e pega
            //se não, retorna um erro
            if(double.TryParse(tbValorTipo.Text, out valor)) { }
            else
            {
                MessageBox.Show("Digite um valor numérico!");
            }

            //adiciona um novo tipo de equipamento no estoque
            Estoque.Add(new TipoEquipamento(nome, valor));

            //limpa os campos
            tbNomeTipo.Clear();
            tbValorTipo.Clear();

            //lista os tipos no cadastro de contrato
            cmbTipoItem.Items.Clear();
            foreach (TipoEquipamento te in Estoque)
            {
                cmbTipoItem.Items.Add(te.Nome);
            }

            //lista os tipos no cadastro de equipamentos
            cmbCadEquip.Items.Clear();
            foreach (TipoEquipamento te in Estoque)
            {
                cmbCadEquip.Items.Add(te.Nome);
            }
        }

        private void btnCadastrarEquip_Click(object sender, EventArgs e)
        {
            //percorre todos os tipos de equipamentos do estoque
            for (int i = 0; i < Estoque.Count; i++)
            {
                //quando o item selecionado no combobox for igual
                //a algum da lista de estoque ele adiciona o valor da variável
                if (cmbCadEquip.Text == Estoque[i].Nome)
                {
                    Estoque[i].equipos.Enqueue(new Equipamento(Estoque[i]));
                }
            }
        }
    }

}


//1. Cadastrar tipo de equipamento - Construtor da classe TipoEquipamento - OK

//2. Consultar tipo de equipamento(com os respectivos itens cadastrados)

//3. Cadastrar equipamento(item em um determinado tipo) - Construtor da classe Equipamento - OK

//4. Registrar Contrato de Locação

//5. Consultar Contratos de Locação(com os respectivos itens contratados)

//6. Liberar de Contrato de Locação

//7. Consultar Contratos de Locação liberados(com os respectivos itens)

//8. Devolver equipamentos de Contrato de Locação liberado
