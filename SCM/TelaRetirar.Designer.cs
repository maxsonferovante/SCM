namespace SCM
{
    partial class TelaRetirar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaRetirar));
            this.lbMaterial = new System.Windows.Forms.Label();
            this.cmbBxMaterial = new System.Windows.Forms.ComboBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.mskdTxtBxQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.lbSetor = new System.Windows.Forms.Label();
            this.cmbBxSetor = new System.Windows.Forms.ComboBox();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.bttCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBxFuncionario = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mskdTxtBxDataRetirada = new System.Windows.Forms.MaskedTextBox();
            this.txtBxQuantEstoque = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMaterial
            // 
            this.lbMaterial.AutoSize = true;
            this.lbMaterial.Location = new System.Drawing.Point(14, 9);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(47, 13);
            this.lbMaterial.TabIndex = 0;
            this.lbMaterial.Text = "Material:";
            // 
            // cmbBxMaterial
            // 
            this.cmbBxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxMaterial.FormattingEnabled = true;
            this.cmbBxMaterial.Location = new System.Drawing.Point(17, 25);
            this.cmbBxMaterial.Name = "cmbBxMaterial";
            this.cmbBxMaterial.Size = new System.Drawing.Size(269, 21);
            this.cmbBxMaterial.TabIndex = 1;
            this.cmbBxMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbBxMaterial_SelectedIndexChanged);
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(14, 49);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbQuantidade.TabIndex = 2;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // mskdTxtBxQuantidade
            // 
            this.mskdTxtBxQuantidade.Location = new System.Drawing.Point(17, 65);
            this.mskdTxtBxQuantidade.Mask = "00000";
            this.mskdTxtBxQuantidade.Name = "mskdTxtBxQuantidade";
            this.mskdTxtBxQuantidade.Size = new System.Drawing.Size(59, 20);
            this.mskdTxtBxQuantidade.TabIndex = 3;
            this.mskdTxtBxQuantidade.ValidatingType = typeof(int);
            // 
            // lbSetor
            // 
            this.lbSetor.AutoSize = true;
            this.lbSetor.Location = new System.Drawing.Point(9, 105);
            this.lbSetor.Name = "lbSetor";
            this.lbSetor.Size = new System.Drawing.Size(35, 13);
            this.lbSetor.TabIndex = 4;
            this.lbSetor.Text = "Setor:";
            // 
            // cmbBxSetor
            // 
            this.cmbBxSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxSetor.FormattingEnabled = true;
            this.cmbBxSetor.Location = new System.Drawing.Point(12, 121);
            this.cmbBxSetor.Name = "cmbBxSetor";
            this.cmbBxSetor.Size = new System.Drawing.Size(313, 21);
            this.cmbBxSetor.TabIndex = 5;
            // 
            // bttSalvar
            // 
            this.bttSalvar.Location = new System.Drawing.Point(12, 237);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(75, 23);
            this.bttSalvar.TabIndex = 6;
            this.bttSalvar.Text = "Salvar";
            this.bttSalvar.UseVisualStyleBackColor = true;
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(118, 237);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttCancelar.TabIndex = 7;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Funcionário:";
            // 
            // cmbBxFuncionario
            // 
            this.cmbBxFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxFuncionario.FormattingEnabled = true;
            this.cmbBxFuncionario.Location = new System.Drawing.Point(12, 185);
            this.cmbBxFuncionario.Name = "cmbBxFuncionario";
            this.cmbBxFuncionario.Size = new System.Drawing.Size(181, 21);
            this.cmbBxFuncionario.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data da retirada:";
            // 
            // mskdTxtBxDataRetirada
            // 
            this.mskdTxtBxDataRetirada.Enabled = false;
            this.mskdTxtBxDataRetirada.Location = new System.Drawing.Point(218, 184);
            this.mskdTxtBxDataRetirada.Mask = "00/00/0000";
            this.mskdTxtBxDataRetirada.Name = "mskdTxtBxDataRetirada";
            this.mskdTxtBxDataRetirada.Size = new System.Drawing.Size(68, 20);
            this.mskdTxtBxDataRetirada.TabIndex = 11;
            this.mskdTxtBxDataRetirada.ValidatingType = typeof(System.DateTime);
            // 
            // txtBxQuantEstoque
            // 
            this.txtBxQuantEstoque.Enabled = false;
            this.txtBxQuantEstoque.Location = new System.Drawing.Point(302, 26);
            this.txtBxQuantEstoque.Name = "txtBxQuantEstoque";
            this.txtBxQuantEstoque.Size = new System.Drawing.Size(44, 20);
            this.txtBxQuantEstoque.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(346, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(299, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Quantidade em estoque:";
            // 
            // TelaRetirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 272);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBxQuantEstoque);
            this.Controls.Add(this.mskdTxtBxDataRetirada);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbBxFuncionario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttSalvar);
            this.Controls.Add(this.cmbBxSetor);
            this.Controls.Add(this.lbSetor);
            this.Controls.Add(this.mskdTxtBxQuantidade);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.cmbBxMaterial);
            this.Controls.Add(this.lbMaterial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaRetirar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCM - Retirada de Material";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TelaRetirar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaterial;
        private System.Windows.Forms.ComboBox cmbBxMaterial;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.MaskedTextBox mskdTxtBxQuantidade;
        private System.Windows.Forms.Label lbSetor;
        private System.Windows.Forms.ComboBox cmbBxSetor;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBxFuncionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskdTxtBxDataRetirada;
        private System.Windows.Forms.TextBox txtBxQuantEstoque;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}