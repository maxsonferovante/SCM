namespace SCM
{
    partial class TelaAdicionar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAdicionar));
            this.bttCancelar = new System.Windows.Forms.Button();
            this.bttSalvar = new System.Windows.Forms.Button();
            this.mskdTxtBxQuantidade = new System.Windows.Forms.MaskedTextBox();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.cmbBxMaterialExistente = new System.Windows.Forms.ComboBox();
            this.lbMaterial = new System.Windows.Forms.Label();
            this.rdBttNovoMaterial = new System.Windows.Forms.RadioButton();
            this.rdBttMaterialExistente = new System.Windows.Forms.RadioButton();
            this.txtBxNovoMaterial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttCancelar
            // 
            this.bttCancelar.Location = new System.Drawing.Point(124, 208);
            this.bttCancelar.Name = "bttCancelar";
            this.bttCancelar.Size = new System.Drawing.Size(75, 23);
            this.bttCancelar.TabIndex = 13;
            this.bttCancelar.Text = "Cancelar";
            this.bttCancelar.UseVisualStyleBackColor = true;
            // 
            // bttSalvar
            // 
            this.bttSalvar.Location = new System.Drawing.Point(18, 208);
            this.bttSalvar.Name = "bttSalvar";
            this.bttSalvar.Size = new System.Drawing.Size(75, 23);
            this.bttSalvar.TabIndex = 12;
            this.bttSalvar.Text = "Salvar";
            this.bttSalvar.UseVisualStyleBackColor = true;
            // 
            // mskdTxtBxQuantidade
            // 
            this.mskdTxtBxQuantidade.Location = new System.Drawing.Point(341, 49);
            this.mskdTxtBxQuantidade.Mask = "00000";
            this.mskdTxtBxQuantidade.Name = "mskdTxtBxQuantidade";
            this.mskdTxtBxQuantidade.Size = new System.Drawing.Size(59, 20);
            this.mskdTxtBxQuantidade.TabIndex = 11;
            this.mskdTxtBxQuantidade.ValidatingType = typeof(int);
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(338, 33);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(62, 13);
            this.lbQuantidade.TabIndex = 10;
            this.lbQuantidade.Text = "Quantidade";
            // 
            // cmbBxMaterialExistente
            // 
            this.cmbBxMaterialExistente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxMaterialExistente.FormattingEnabled = true;
            this.cmbBxMaterialExistente.Location = new System.Drawing.Point(18, 49);
            this.cmbBxMaterialExistente.Name = "cmbBxMaterialExistente";
            this.cmbBxMaterialExistente.Size = new System.Drawing.Size(313, 21);
            this.cmbBxMaterialExistente.TabIndex = 9;
            // 
            // lbMaterial
            // 
            this.lbMaterial.AutoSize = true;
            this.lbMaterial.Location = new System.Drawing.Point(15, 33);
            this.lbMaterial.Name = "lbMaterial";
            this.lbMaterial.Size = new System.Drawing.Size(73, 13);
            this.lbMaterial.TabIndex = 8;
            this.lbMaterial.Text = "Novo Material";
            // 
            // rdBttNovoMaterial
            // 
            this.rdBttNovoMaterial.AutoSize = true;
            this.rdBttNovoMaterial.Location = new System.Drawing.Point(18, 12);
            this.rdBttNovoMaterial.Name = "rdBttNovoMaterial";
            this.rdBttNovoMaterial.Size = new System.Drawing.Size(91, 17);
            this.rdBttNovoMaterial.TabIndex = 14;
            this.rdBttNovoMaterial.TabStop = true;
            this.rdBttNovoMaterial.Text = "Novo Material";
            this.rdBttNovoMaterial.UseVisualStyleBackColor = true;
            this.rdBttNovoMaterial.CheckedChanged += new System.EventHandler(this.rdBttNovoMaterial_CheckedChanged);
            // 
            // rdBttMaterialExistente
            // 
            this.rdBttMaterialExistente.AutoSize = true;
            this.rdBttMaterialExistente.Location = new System.Drawing.Point(124, 12);
            this.rdBttMaterialExistente.Name = "rdBttMaterialExistente";
            this.rdBttMaterialExistente.Size = new System.Drawing.Size(108, 17);
            this.rdBttMaterialExistente.TabIndex = 15;
            this.rdBttMaterialExistente.TabStop = true;
            this.rdBttMaterialExistente.Text = "Material Existente";
            this.rdBttMaterialExistente.UseVisualStyleBackColor = true;
            this.rdBttMaterialExistente.CheckedChanged += new System.EventHandler(this.rdBttMaterialExistente_CheckedChanged);
            // 
            // txtBxNovoMaterial
            // 
            this.txtBxNovoMaterial.Location = new System.Drawing.Point(18, 50);
            this.txtBxNovoMaterial.Name = "txtBxNovoMaterial";
            this.txtBxNovoMaterial.Size = new System.Drawing.Size(313, 20);
            this.txtBxNovoMaterial.TabIndex = 16;
            // 
            // TelaAdicionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 241);
            this.Controls.Add(this.txtBxNovoMaterial);
            this.Controls.Add(this.rdBttMaterialExistente);
            this.Controls.Add(this.rdBttNovoMaterial);
            this.Controls.Add(this.bttCancelar);
            this.Controls.Add(this.bttSalvar);
            this.Controls.Add(this.mskdTxtBxQuantidade);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.cmbBxMaterialExistente);
            this.Controls.Add(this.lbMaterial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TelaAdicionar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adição de Material";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TelaAdicionar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttCancelar;
        private System.Windows.Forms.Button bttSalvar;
        private System.Windows.Forms.MaskedTextBox mskdTxtBxQuantidade;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.ComboBox cmbBxMaterialExistente;
        private System.Windows.Forms.Label lbMaterial;
        private System.Windows.Forms.RadioButton rdBttNovoMaterial;
        private System.Windows.Forms.RadioButton rdBttMaterialExistente;
        private System.Windows.Forms.TextBox txtBxNovoMaterial;
    }
}