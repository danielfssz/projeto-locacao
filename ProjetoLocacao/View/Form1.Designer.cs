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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstItens = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nmItemQtd = new System.Windows.Forms.DomainUpDown();
            this.btnItemRemove = new System.Windows.Forms.Button();
            this.cmbTipoItem = new System.Windows.Forms.ComboBox();
            this.btnItemAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 320);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Criar contrato";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstItens);
            this.groupBox1.Controls.Add(this.cmbTipoItem);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnItemAdd);
            this.groupBox1.Controls.Add(this.nmItemQtd);
            this.groupBox1.Controls.Add(this.btnItemRemove);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 254);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de item";
            // 
            // lstItens
            // 
            this.lstItens.FormattingEnabled = true;
            this.lstItens.Location = new System.Drawing.Point(6, 66);
            this.lstItens.Name = "lstItens";
            this.lstItens.Size = new System.Drawing.Size(181, 121);
            this.lstItens.TabIndex = 11;
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
            // cmbTipoItem
            // 
            this.cmbTipoItem.FormattingEnabled = true;
            this.cmbTipoItem.Location = new System.Drawing.Point(6, 19);
            this.cmbTipoItem.Name = "cmbTipoItem";
            this.cmbTipoItem.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoItem.TabIndex = 10;
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.Location = new System.Drawing.Point(91, 208);
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(108, 38);
            this.btnItemAdd.TabIndex = 12;
            this.btnItemAdd.Text = "button2";
            this.btnItemAdd.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 355);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstItens;
        private System.Windows.Forms.ComboBox cmbTipoItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnItemAdd;
        private System.Windows.Forms.DomainUpDown nmItemQtd;
        private System.Windows.Forms.Button btnItemRemove;
    }
}

