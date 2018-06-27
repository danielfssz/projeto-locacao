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
            this.btnContAdd = new System.Windows.Forms.Button();
            this.lstItens = new System.Windows.Forms.ListBox();
            this.cmbTipoItem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.nmItemQtd = new System.Windows.Forms.DomainUpDown();
            this.btnItemRemove = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarEquip = new System.Windows.Forms.Button();
            this.cmbCadEquip = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCadastrarTipo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbValorTipo = new System.Windows.Forms.TextBox();
            this.tbNomeTipo = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnContAdd);
            this.groupBox1.Controls.Add(this.lstItens);
            this.groupBox1.Controls.Add(this.cmbTipoItem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnItemAdd);
            this.groupBox1.Controls.Add(this.nmItemQtd);
            this.groupBox1.Controls.Add(this.btnItemRemove);
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 264);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de item";
            // 
            // btnContAdd
            // 
            this.btnContAdd.Location = new System.Drawing.Point(136, 216);
            this.btnContAdd.Name = "btnContAdd";
            this.btnContAdd.Size = new System.Drawing.Size(108, 38);
            this.btnContAdd.TabIndex = 13;
            this.btnContAdd.Text = "Criar contrato";
            this.btnContAdd.UseVisualStyleBackColor = true;
            // 
            // lstItens
            // 
            this.lstItens.FormattingEnabled = true;
            this.lstItens.Location = new System.Drawing.Point(6, 66);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(181, 121);
            this.lstItens.TabIndex = 11;
            // 
            // cmbTipoItem
            // 
            this.cmbTipoItem.FormattingEnabled = true;
            this.cmbTipoItem.Location = new System.Drawing.Point(6, 19);
            this.cmbTipoItem.Name = "cmbTipoItem";
            this.cmbTipoItem.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoItem.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Location = new System.Drawing.Point(6, 216);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(108, 38);
            this.btnItemAdd.TabIndex = 12;
            this.btnItemAdd.Text = "Adicionar item";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            // 
            // nmItemQtd
            // 
            this.nmItemQtd.Location = new System.Drawing.Point(157, 20);
            this.nmItemQtd.Name = "nmItemQtd";
            this.nmItemQtd.Size = new System.Drawing.Size(120, 20);
            this.nmItemQtd.TabIndex = 9;
            this.nmItemQtd.Text = "domainUpDown1";
            // 
            // btnItemRemove
            // 
            this.btnItemRemove.Location = new System.Drawing.Point(202, 103);
            this.btnItemRemove.Name = "btnItemRemove";
            this.btnItemRemove.Size = new System.Drawing.Size(75, 23);
            this.btnItemRemove.TabIndex = 13;
            this.btnItemRemove.Text = "remove";
            this.btnItemRemove.UseVisualStyleBackColor = true;
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
            this.groupBox2.Location = new System.Drawing.Point(302, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 264);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data de devolução";
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
            this.groupBox4.Controls.Add(this.btnCadastrarEquip);
            this.groupBox4.Controls.Add(this.cmbCadEquip);
            this.groupBox4.Location = new System.Drawing.Point(323, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(303, 264);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cadastrar equipamento";
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
            this.label3.Location = new System.Drawing.Point(34, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Valor: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome: ";
            // 
            // tbValorTipo
            // 
            this.tbValorTipo.Location = new System.Drawing.Point(87, 128);
            this.tbValorTipo.Name = "tbValorTipo";
            this.tbValorTipo.Size = new System.Drawing.Size(172, 20);
            this.tbValorTipo.TabIndex = 1;
            // 
            // tbNomeTipo
            // 
            this.tbNomeTipo.Location = new System.Drawing.Point(87, 64);
            this.tbNomeTipo.Name = "tbNomeTipo";
            this.tbNomeTipo.Size = new System.Drawing.Size(172, 20);
            this.tbNomeTipo.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(632, 276);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(632, 276);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
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
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstItens;
        private System.Windows.Forms.ComboBox cmbTipoItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.DomainUpDown nmItemQtd;
        private System.Windows.Forms.Button btnItemRemove;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
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
    }
}

