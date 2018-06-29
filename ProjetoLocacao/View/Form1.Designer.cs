
namespace ProjetoLocacao
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblQtdeDisponivel = new System.Windows.Forms.Label();
            this.nmItemQtd = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lstItens = new System.Windows.Forms.ListBox();
            this.cmbTipoItem = new System.Windows.Forms.ComboBox();
            this.lblItemRemove = new System.Windows.Forms.Label();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.btnItemRemove = new System.Windows.Forms.Button();
            this.btnContAdd = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpIncio = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSaida = new System.Windows.Forms.DateTimePicker();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCadastrarEquip = new System.Windows.Forms.Button();
            this.cmbCadEquip = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarTipo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValorTipo = new System.Windows.Forms.TextBox();
            this.tbNomeTipo = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lstConsultaEquip = new System.Windows.Forms.ListBox();
            this.lstConsultaTipo = new System.Windows.Forms.ListBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.lstItensContrato = new System.Windows.Forms.ListBox();
            this.lstConsultaContratos = new System.Windows.Forms.ListBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.lstContratosNaoLiberados = new System.Windows.Forms.ListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lstLiberaItensContrato = new System.Windows.Forms.ListBox();
            this.cmbEquipamentos = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.chkAvariado = new System.Windows.Forms.CheckBox();
            this.btnLiberaContrato = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmItemQtd)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQtdeDisponivel);
            this.groupBox1.Controls.Add(this.nmItemQtd);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lstItens);
            this.groupBox1.Controls.Add(this.cmbTipoItem);
            this.groupBox1.Controls.Add(this.lblItemRemove);
            this.groupBox1.Controls.Add(this.btnItemAdd);
            this.groupBox1.Controls.Add(this.btnItemRemove);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(348, 264);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Itens de Contrato";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblQtdeDisponivel
            // 
            this.lblQtdeDisponivel.AutoSize = true;
            this.lblQtdeDisponivel.Location = new System.Drawing.Point(154, 79);
            this.lblQtdeDisponivel.Name = "lblQtdeDisponivel";
            this.lblQtdeDisponivel.Size = new System.Drawing.Size(0, 13);
            this.lblQtdeDisponivel.TabIndex = 10;
            // 
            // nmItemQtd
            // 
            this.nmItemQtd.Location = new System.Drawing.Point(157, 45);
            this.nmItemQtd.Name = "nmItemQtd";
            this.nmItemQtd.Size = new System.Drawing.Size(120, 20);
            this.nmItemQtd.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(154, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Selecione a qtde";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Selecione o equipamento";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 123);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Itens do contrato";
            // 
            // lstItens
            // 
            this.lstItens.FormattingEnabled = true;
            this.lstItens.Location = new System.Drawing.Point(3, 137);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(226, 121);
            this.lstItens.TabIndex = 11;
            this.lstItens.SelectedIndexChanged += new System.EventHandler(this.lstItens_SelectedIndexChanged);
            // 
            // cmbTipoItem
            // 
            this.cmbTipoItem.FormattingEnabled = true;
            this.cmbTipoItem.Location = new System.Drawing.Point(6, 45);
            this.cmbTipoItem.Name = "cmbTipoItem";
            this.cmbTipoItem.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoItem.TabIndex = 10;
            this.cmbTipoItem.SelectedIndexChanged += new System.EventHandler(this.cmbTipoItem_SelectedIndexChanged);
            // 
            // lblItemRemove
            // 
            this.lblItemRemove.AutoSize = true;
            this.lblItemRemove.Location = new System.Drawing.Point(235, 175);
            this.lblItemRemove.Name = "lblItemRemove";
            this.lblItemRemove.Size = new System.Drawing.Size(101, 13);
            this.lblItemRemove.TabIndex = 14;
            this.lblItemRemove.Text = "Clique para remover";
            this.lblItemRemove.Click += new System.EventHandler(this.lblItemRemove_Click);
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Location = new System.Drawing.Point(6, 72);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(86, 26);
            this.btnItemAdd.TabIndex = 12;
            this.btnItemAdd.Text = "Adicionar item";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // btnItemRemove
            // 
            this.btnItemRemove.Location = new System.Drawing.Point(247, 191);
            this.btnItemRemove.Name = "btnItemRemove";
            this.btnItemRemove.Size = new System.Drawing.Size(75, 23);
            this.btnItemRemove.TabIndex = 13;
            this.btnItemRemove.Text = "Remover";
            this.btnItemRemove.UseVisualStyleBackColor = true;
            this.btnItemRemove.Click += new System.EventHandler(this.btnItemRemove_Click);
            // 
            // btnContAdd
            // 
            this.btnContAdd.Location = new System.Drawing.Point(74, 208);
            this.btnContAdd.Name = "btnContAdd";
            this.btnContAdd.Size = new System.Drawing.Size(108, 38);
            this.btnContAdd.TabIndex = 13;
            this.btnContAdd.Text = "Criar contrato";
            this.btnContAdd.UseVisualStyleBackColor = true;
            this.btnContAdd.Click += new System.EventHandler(this.btnContAdd_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 302);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(632, 276);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastro de Contratos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtpIncio);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnContAdd);
            this.groupBox2.Controls.Add(this.dtpSaida);
            this.groupBox2.Location = new System.Drawing.Point(357, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 264);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gerar contrato";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Data de Ínicio do Contrato:";
            // 
            // dtpIncio
            // 
            this.dtpIncio.Location = new System.Drawing.Point(24, 46);
            this.dtpIncio.Name = "dtpIncio";
            this.dtpIncio.Size = new System.Drawing.Size(200, 20);
            this.dtpIncio.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Data de devolução:";
            // 
            // dtpSaida
            // 
            this.dtpSaida.Location = new System.Drawing.Point(24, 168);
            this.dtpSaida.Name = "dtpSaida";
            this.dtpSaida.Size = new System.Drawing.Size(200, 20);
            this.dtpSaida.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(632, 276);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro de Equipamentos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblQtd);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.btnCadastrarEquip);
            this.groupBox4.Controls.Add(this.cmbCadEquip);
            this.groupBox4.Location = new System.Drawing.Point(323, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 264);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cadastrar equipamento";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(60, 116);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(68, 13);
            this.lblQtd.TabIndex = 7;
            this.lblQtd.Text = "Quantidade: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 6;
            this.label4.Tag = "Tipo:";
            this.label4.Text = "Tipo: ";
            // 
            // btnCadastrarEquip
            // 
            this.btnCadastrarEquip.Location = new System.Drawing.Point(105, 195);
            this.btnCadastrarEquip.Name = "btnCadastrarEquip";
            this.btnCadastrarEquip.Size = new System.Drawing.Size(121, 38);
            this.btnCadastrarEquip.TabIndex = 5;
            this.btnCadastrarEquip.Text = "Cadastrar";
            this.btnCadastrarEquip.UseVisualStyleBackColor = true;
            this.btnCadastrarEquip.Click += new System.EventHandler(this.btnCadastrarEquip_Click);
            // 
            // cmbCadEquip
            // 
            this.cmbCadEquip.FormattingEnabled = true;
            this.cmbCadEquip.Location = new System.Drawing.Point(60, 88);
            this.cmbCadEquip.Name = "cmbCadEquip";
            this.cmbCadEquip.Size = new System.Drawing.Size(193, 21);
            this.cmbCadEquip.TabIndex = 0;
            this.cmbCadEquip.SelectedIndexChanged += new System.EventHandler(this.cmbCadEquip_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCadastrarTipo);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbValorTipo);
            this.groupBox3.Controls.Add(this.tbNomeTipo);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(303, 264);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Cadastrar tipo";
            // 
            // btnCadastrarTipo
            // 
            this.btnCadastrarTipo.Location = new System.Drawing.Point(87, 195);
            this.btnCadastrarTipo.Name = "btnCadastrarTipo";
            this.btnCadastrarTipo.Size = new System.Drawing.Size(113, 38);
            this.btnCadastrarTipo.TabIndex = 4;
            this.btnCadastrarTipo.Text = "Cadastrar";
            this.btnCadastrarTipo.UseVisualStyleBackColor = true;
            this.btnCadastrarTipo.Click += new System.EventHandler(this.btnCadastrarTipo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor do aluguel por dia: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome: ";
            // 
            // tbValorTipo
            // 
            this.tbValorTipo.Location = new System.Drawing.Point(37, 128);
            this.tbValorTipo.Name = "tbValorTipo";
            this.tbValorTipo.Size = new System.Drawing.Size(222, 20);
            this.tbValorTipo.TabIndex = 1;
            // 
            // tbNomeTipo
            // 
            this.tbNomeTipo.Location = new System.Drawing.Point(37, 64);
            this.tbNomeTipo.Name = "tbNomeTipo";
            this.tbNomeTipo.Size = new System.Drawing.Size(222, 20);
            this.tbNomeTipo.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(632, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consultas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(-4, -2);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(641, 282);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.lstConsultaEquip);
            this.tabPage5.Controls.Add(this.lstConsultaTipo);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(633, 256);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "Tipo de equipamento";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Equipamentos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipos de Equipamento no estoque";
            // 
            // lstConsultaEquip
            // 
            this.lstConsultaEquip.FormattingEnabled = true;
            this.lstConsultaEquip.Location = new System.Drawing.Point(319, 64);
            this.lstConsultaEquip.Name = "lstConsultaEquip";
            this.lstConsultaEquip.Size = new System.Drawing.Size(277, 186);
            this.lstConsultaEquip.TabIndex = 1;
            // 
            // lstConsultaTipo
            // 
            this.lstConsultaTipo.FormattingEnabled = true;
            this.lstConsultaTipo.Location = new System.Drawing.Point(6, 64);
            this.lstConsultaTipo.Name = "lstConsultaTipo";
            this.lstConsultaTipo.Size = new System.Drawing.Size(228, 186);
            this.lstConsultaTipo.TabIndex = 0;
            this.lstConsultaTipo.SelectedIndexChanged += new System.EventHandler(this.lstConsultaTipo_SelectedIndexChanged);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.label11);
            this.tabPage6.Controls.Add(this.lstItensContrato);
            this.tabPage6.Controls.Add(this.lstConsultaContratos);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(633, 256);
            this.tabPage6.TabIndex = 1;
            this.tabPage6.Text = "Contratos de locação";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.label11.Location = new System.Drawing.Point(6, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(248, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "Clique no contrato para ver os itens ao lado!!";
            // 
            // lstItensContrato
            // 
            this.lstItensContrato.FormattingEnabled = true;
            this.lstItensContrato.Location = new System.Drawing.Point(357, 64);
            this.lstItensContrato.Name = "lstItensContrato";
            this.lstItensContrato.Size = new System.Drawing.Size(239, 186);
            this.lstItensContrato.TabIndex = 11;
            // 
            // lstConsultaContratos
            // 
            this.lstConsultaContratos.FormattingEnabled = true;
            this.lstConsultaContratos.Location = new System.Drawing.Point(6, 64);
            this.lstConsultaContratos.Name = "lstConsultaContratos";
            this.lstConsultaContratos.Size = new System.Drawing.Size(345, 186);
            this.lstConsultaContratos.TabIndex = 10;
            this.lstConsultaContratos.SelectedIndexChanged += new System.EventHandler(this.lstConsultaContratos_SelectedIndexChanged);
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(633, 256);
            this.tabPage7.TabIndex = 2;
            this.tabPage7.Text = "Contratos de locação liberados";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnLiberaContrato);
            this.tabPage4.Controls.Add(this.chkAvariado);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.cmbEquipamentos);
            this.tabPage4.Controls.Add(this.lstLiberaItensContrato);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.lstContratosNaoLiberados);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(632, 276);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Devolução de contratos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Contratos ";
            // 
            // lstContratosNaoLiberados
            // 
            this.lstContratosNaoLiberados.FormattingEnabled = true;
            this.lstContratosNaoLiberados.Location = new System.Drawing.Point(6, 91);
            this.lstContratosNaoLiberados.Name = "lstContratosNaoLiberados";
            this.lstContratosNaoLiberados.Size = new System.Drawing.Size(248, 173);
            this.lstContratosNaoLiberados.TabIndex = 0;
            this.lstContratosNaoLiberados.SelectedIndexChanged += new System.EventHandler(this.lstContratosNaoLiberados_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(257, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Itens do Contrato";
            // 
            // lstLiberaItensContrato
            // 
            this.lstLiberaItensContrato.FormattingEnabled = true;
            this.lstLiberaItensContrato.Location = new System.Drawing.Point(260, 91);
            this.lstLiberaItensContrato.Name = "lstLiberaItensContrato";
            this.lstLiberaItensContrato.Size = new System.Drawing.Size(136, 173);
            this.lstLiberaItensContrato.TabIndex = 3;
            this.lstLiberaItensContrato.SelectedIndexChanged += new System.EventHandler(this.lstLiberaItensContrato_SelectedIndexChanged);
            // 
            // cmbEquipamentos
            // 
            this.cmbEquipamentos.FormattingEnabled = true;
            this.cmbEquipamentos.Location = new System.Drawing.Point(402, 91);
            this.cmbEquipamentos.Name = "cmbEquipamentos";
            this.cmbEquipamentos.Size = new System.Drawing.Size(121, 21);
            this.cmbEquipamentos.TabIndex = 4;
            this.cmbEquipamentos.SelectedIndexChanged += new System.EventHandler(this.cmbEquipamentos_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(402, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(127, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Selecione o equipamento";
            // 
            // chkAvariado
            // 
            this.chkAvariado.AutoSize = true;
            this.chkAvariado.Location = new System.Drawing.Point(405, 118);
            this.chkAvariado.Name = "chkAvariado";
            this.chkAvariado.Size = new System.Drawing.Size(67, 17);
            this.chkAvariado.TabIndex = 6;
            this.chkAvariado.Text = "avariado";
            this.chkAvariado.UseVisualStyleBackColor = true;
            this.chkAvariado.CheckedChanged += new System.EventHandler(this.chkAvariado_CheckedChanged);
            // 
            // btnLiberaContrato
            // 
            this.btnLiberaContrato.Location = new System.Drawing.Point(490, 207);
            this.btnLiberaContrato.Name = "btnLiberaContrato";
            this.btnLiberaContrato.Size = new System.Drawing.Size(124, 57);
            this.btnLiberaContrato.TabIndex = 7;
            this.btnLiberaContrato.Text = "Liberar Contrato";
            this.btnLiberaContrato.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 322);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmItemQtd)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstItens;
        private System.Windows.Forms.ComboBox cmbTipoItem;
        private System.Windows.Forms.Label lblItemRemove;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.Button btnItemRemove;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnContAdd;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCadastrarTipo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbValorTipo;
        private System.Windows.Forms.TextBox tbNomeTipo;
        private System.Windows.Forms.Button btnCadastrarEquip;
        private System.Windows.Forms.ComboBox cmbCadEquip;
        private System.Windows.Forms.DateTimePicker dtpSaida;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.ListBox lstConsultaEquip;
        private System.Windows.Forms.ListBox lstConsultaTipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lstConsultaContratos;
        private System.Windows.Forms.ListBox lstItensContrato;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nmItemQtd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQtdeDisponivel;
        private System.Windows.Forms.DateTimePicker dtpIncio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lstContratosNaoLiberados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstLiberaItensContrato;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox chkAvariado;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbEquipamentos;
        private System.Windows.Forms.Button btnLiberaContrato;
    }
}