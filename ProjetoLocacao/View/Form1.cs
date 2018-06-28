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
        List<Contrato> ContratosLiberados = new List<Contrato>();

        //Lista temp
        List<ItemContrato> itensAContratar = new List<ItemContrato>();

        int idEquip = 0, idContrato = 0, idTipoEquip = 0, idItemContrato = 0;

        public Form1()
        {
            InitializeComponent();
            lblItemRemove.Hide();
            btnItemRemove.Hide();
        }

        // botão para adicionar itens de contrato
        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            if (nmItemQtd.Value == 0)
            {
                MessageBox.Show("Escolha um valor maior que zero!");
                return;
            }

            if (cmbTipoItem.Text == "")
            {
                MessageBox.Show("Escolha um equipamento!");
                return;
            }

            int idPesq = retornaIndicePipe(cmbTipoItem.SelectedItem.ToString());

            TipoEquipamento tpEqpPesquisado = pesquisarTipoEquipamento(new TipoEquipamento(idPesq));

            int posicaoNoEstoque = Estoque.IndexOf(tpEqpPesquisado);

            if (tpEqpPesquisado.equipos.Count >= nmItemQtd.Value)
            {
                ItemContrato novoItemContrato = new ItemContrato(idItemContrato++, tpEqpPesquisado, int.Parse(nmItemQtd.Value.ToString()));

                for (int i = 0; i < nmItemQtd.Value; i++)
                {
                    novoItemContrato.EquipamentosRetirados.Push(Estoque[posicaoNoEstoque].equipos.Dequeue());
                }

                itensAContratar.Add(novoItemContrato);
            }
            else
            {
                MessageBox.Show("Não há quantidade suficiente no estoque desse item!");
            }

            lblQtdeDisponivel.Text = "Quantidade disponível: " + Estoque[posicaoNoEstoque].equipos.Count.ToString();

            //mostra os itens na lista
            lstItens.Items.Clear();
            foreach (ItemContrato ic in itensAContratar)
            {
                lstItens.Items.Add(ic.Id + " | ID: " + ic.TipoEquipamento.TipoEquipId + " | Tipo: " + ic.TipoEquipamento.Nome + " | Quantidade: " + ic.Qtde);
            }
        }

        // botão pra cadastrar tipos de equipamento OK
        private void btnCadastrarTipo_Click(object sender, EventArgs e)
        {
            string nome = tbNomeTipo.Text;
            double valor;

            //se o valor da textbox de valor for numérico, converte e pega
            //se não, retorna um erro
            if (nome.Trim() == "")
            {
                MessageBox.Show("O nome não pode ser vazio");
                return;
            }

            if (!double.TryParse(tbValorTipo.Text, out valor))
            {
                MessageBox.Show("Digite um valor numérico!");
                return;
            }

            //adiciona um novo tipo de equipamento no estoque
            Estoque.Add(new TipoEquipamento(idTipoEquip++, nome, valor));

            //limpa os campos
            tbNomeTipo.Clear();
            tbValorTipo.Clear();

            //lista os tipos no cadastro de equipamentos para cadastrar a quantidade desse item no estoque
            cmbCadEquip.Items.Clear();
            foreach (TipoEquipamento te in Estoque)
            {
                cmbCadEquip.Items.Add(te.TipoEquipId + " | " + te.Nome);
            }

            //lista os tipos no cadastro de contrato
            cmbTipoItem.Items.Clear();
            foreach (TipoEquipamento te in Estoque)
            {
                cmbTipoItem.Items.Add(te.TipoEquipId + " | " + te.Nome);
            }

            //lista os itens na consulta de tipos
            lstConsultaTipo.Items.Clear();
            foreach (TipoEquipamento te in Estoque)
            {
                lstConsultaTipo.Items.Add(te.TipoEquipId + " | " + te.Nome);
            }
        }

        //inserir quantidade no item do estoque
        private void btnCadastrarEquip_Click(object sender, EventArgs e)
        {
            int idPesq = retornaIndicePipe(cmbCadEquip.SelectedItem.ToString());

            TipoEquipamento tpEqpPesquisado = pesquisarTipoEquipamento(new TipoEquipamento(idPesq));

            int posicaoNoEstoque = Estoque.IndexOf(tpEqpPesquisado);

            Estoque[posicaoNoEstoque].equipos.Enqueue(new Equipamento(idEquip++, Estoque[posicaoNoEstoque]));

            lblQtd.Text = "Quantidade: " + Estoque[posicaoNoEstoque].equipos.Count.ToString();

        }

        private void cmbCadEquip_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoEquipamento contagem = null;

            //percorre todos os tipos de equipamentos do estoque
            for (int i = 0; i < Estoque.Count; i++)
            {
                //quando o item selecionado no combobox for igual
                //a algum da lista de estoque ele adiciona o valor da variável

                if (cmbCadEquip.Text == Estoque[i].TipoEquipId + " | " + Estoque[i].Nome)
                {
                    contagem = Estoque[i];
                }
            }

            lblQtd.Text = "Quantidade: " + contagem.equipos.Count.ToString();
        }

        //botão pra gerar contrato
        private void btnContAdd_Click(object sender, EventArgs e)
        {
            //entra se tiver algum item de contrato
            if (itensAContratar.Count > 0)
            {
                if (dtpSaida.Value < dtpIncio.Value)
                {
                    MessageBox.Show("Valor de inicio nao pode ser maior do que o de saida");
                    return;
                }
                List<ItemContrato> listPraPassar = new List<ItemContrato>();
                listPraPassar = itensAContratar;
                //cria um novo contrato
                Contratos.Add(new Contrato(idContrato++, DateTime.Now, dtpSaida.Value, listPraPassar));

                //limpa a lista temporária de itens de contrato e a lista que mostra os itens
                lstConsultaContratos.Items.Clear();
                foreach (Contrato c in Contratos)
                {
                    lstConsultaContratos.Items.Add(c.ContratoId + " | Data de saída: " + c.DtSaida.ToString("dd/mm/yyyy") + " | Data de retorno: " + c.DtRetorno.ToString("dd/mm/yyyy"));
                }

                lstItens.Items.Clear();
                itensAContratar.Clear();
            }
            else
            {
                MessageBox.Show("Não há itens de contrato na lista!");
            }

        }

        private void lstConsultaContratos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idPesq = retornaIndicePipe(lstConsultaContratos.SelectedItem.ToString());
            Contrato contratoPesq = pesquisarContrato(new Contrato(idPesq));
            int idContratos = Contratos.IndexOf(contratoPesq);

            lstItensContrato.Items.Clear();
            foreach (ItemContrato IC in contratoPesq.ItensContrato)
            {
                lstItensContrato.Items.Add(IC.Id + " | Nome:" + IC.TipoEquipamento.Nome + " | Qtde: " + IC.Qtde);
            }

        }

        private void lstItens_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnItemRemove.Show();
            lblItemRemove.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        private void btnItemRemove_Click(object sender, EventArgs e)
        {
            int idPesq = retornaIndicePipe(lstItens.SelectedItem.ToString());

            ItemContrato itemContPesq = pesquisarItemContrato(new ItemContrato(idPesq));

            for (int i = 0; i < itemContPesq.Qtde; i++)
            {
                Estoque[Estoque.IndexOf(itemContPesq.TipoEquipamento)].equipos.
                    Enqueue(itemContPesq.EquipamentosRetirados.Pop());
            }

            itensAContratar.RemoveAt(itensAContratar.IndexOf(itemContPesq));


            lstItens.Items.Remove(lstItens.SelectedItem.ToString());

            lstItens.Items.Clear();
            foreach (ItemContrato ic in itensAContratar)
            {
                lstItens.Items.Add(ic.Id + " | ID: " + ic.TipoEquipamento.TipoEquipId + " | Tipo: " + ic.TipoEquipamento.Nome + " | Quantidade: " + ic.Qtde);
            }
            lblItemRemove.Hide();
            btnItemRemove.Hide();
        }

        private void lstConsultaTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstConsultaTipo.SelectedItem == null)
            {
                MessageBox.Show("Selecione um item!");
                return;
            }

            int idPesq = retornaIndicePipe(lstConsultaTipo.SelectedItem.ToString());
            TipoEquipamento tpEqpPesquisado = pesquisarTipoEquipamento(new TipoEquipamento(idPesq));

            lstConsultaEquip.Items.Clear();
            foreach (Equipamento equip in tpEqpPesquisado.equipos)
            {
                lstConsultaEquip.Items.Add("ID: " + equip.EquipId + " | Patrimônio: " + equip.Patrimonio + " | Avariado: " + equip.Avariado);
            }
        }

        private void lblItemRemove_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoItem_SelectedIndexChanged(object sender, EventArgs e)
        {

            int idPesq = retornaIndicePipe(cmbTipoItem.SelectedItem.ToString());

            TipoEquipamento tpEqpPesquisado = pesquisarTipoEquipamento(new TipoEquipamento(idPesq));

            int posicaoNoEstoque = Estoque.IndexOf(tpEqpPesquisado);

            lblQtdeDisponivel.Text = "Quantidade disponível: " + Estoque[posicaoNoEstoque].equipos.Count.ToString();
        }


        //Metodo que retorna o indice do pipe
        int retornaIndicePipe(string var)
        {
            bool permiteCarater = false;
            int contador = 0;
            int idPesq = -1;

            do
            {
                if (var[contador].ToString().Trim() == "|")
                {
                    idPesq = int.Parse(var.Substring(0, contador - 1));
                    permiteCarater = true;
                }
                contador++;
            } while (!permiteCarater);

            return idPesq;
        }

        //Pesquisas
        TipoEquipamento pesquisarTipoEquipamento(TipoEquipamento tipoEquipamento)
        {
            TipoEquipamento eqpAchado = new TipoEquipamento();
            int i = Estoque.IndexOf(tipoEquipamento);
            if (i >= 0)
                eqpAchado = Estoque[i];
            else
                eqpAchado = null;
            return eqpAchado;
        }

        ItemContrato pesquisarItemContrato(ItemContrato itemContrato)
        {
            ItemContrato itemAchado = new ItemContrato();
            int i = itensAContratar.IndexOf(itemContrato);
            if (i >= 0)
                itemAchado = itensAContratar[i];
            else
                itemAchado = null;
            return itemAchado;
        }

        Contrato pesquisarContrato(Contrato contrato)
        {
            Contrato contratoAchado = new Contrato();
            int i = Contratos.IndexOf(contrato);
            if (i >= 0)
                contratoAchado = Contratos[i];
            else
                contratoAchado = null;
            return contratoAchado;
        }
    }

}


//1. Cadastrar tipo de equipamento - Construtor da classe TipoEquipamento - OK

//2. Consultar tipo de equipamento(com os respectivos itens cadastrados) - na Aba de consultas - OK

//3. Cadastrar equipamento(item em um determinado tipo) - Construtor da classe Equipamento - OK

//4. Registrar Contrato de Locação - na aba Cadastro de equipamentos - OK

//5. Consultar Contratos de Locação(com os respectivos itens contratados)

//6. Liberar de Contrato de Locação

//7. Consultar Contratos de Locação liberados(com os respectivos itens)

//8. Devolver equipamentos de Contrato de Locação liberado