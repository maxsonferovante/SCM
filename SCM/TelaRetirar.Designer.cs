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
            this.SuspendLayout();
            // 
            // lbMaterial
            // 
            this.lbMaterial.AutoSize = true;
            this.lbMaterial.Location = new System.Drawing.Point(14, 9);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(44, 13);
            this.lbMaterial.TabIndex = 0;
            this.lbMaterial.Text = "Material";
            // 
            // cmbBxMaterial
            // 
            this.cmbBxMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxMaterial.FormattingEnabled = true;
            this.cmbBxMaterial.Location = new System.Drawing.Point(17, 25);
            this.cmbBxMaterial.Name = "cmbBxMaterial";
            this.cmbBxMaterial.Size = new System.Drawing.Size(313, 21);
            this.cmbBxMaterial.TabIndex = 1;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(337, 9);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbQuantidade.TabIndex = 2;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // mskdTxtBxQuantidade
            // 
            this.mskdTxtBxQuantidade.Location = new System.Drawing.Point(340, 25);
            this.mskdTxtBxQuantidade.Mask = "00000";
            this.mskdTxtBxQuantidade.Name = "mskdTxtBxQuantidade";
            this.mskdTxtBxQuantidade.Size = new System.Drawing.Size(59, 20);
            this.mskdTxtBxQuantidade.TabIndex = 3;
            this.mskdTxtBxQuantidade.ValidatingType = typeof(int);
            // 
            // lbSetor
            // 
            this.lbSetor.AutoSize = true;
            this.lbSetor.Location = new System.Drawing.Point(14, 72);
            this.lbSetor.Name = "lbSetor";
            this.lbSetor.Size = new System.Drawing.Size(32, 13);
            this.lbSetor.TabIndex = 4;
            this.lbSetor.Text = "Setor";
            // 
            // cmbBxSetor
            // 
            this.cmbBxSetor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxSetor.FormattingEnabled = true;
            this.cmbBxSetor.Location = new System.Drawing.Point(17, 88);
            this.cmbBxSetor.Name = "cmbBxSetor";
            this.cmbBxSetor.Size = new System.Drawing.Size(313, 21);
            this.cmbBxSetor.TabIndex = 5;
            // 
            // bttSalvar
            // 
            this.bttSalvar.Location = new System.Drawing.Point(17, 208);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(75, 23);
            this.bttSalvar.TabIndex = 6;
            this.bttSalvar.Text = "Salvar";
            this.bttSalvar.UseVisualStyleBackColor = true;
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(123, 208);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttCancelar.TabIndex = 7;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            // 
            // TelaRetirar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 241);
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
    }
}