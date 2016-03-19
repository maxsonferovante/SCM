namespace SCM
{
    partial class Telalogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Telalogin));
            this.bttEntrar = new System.Windows.Forms.Button();
            this.bttAlterarSenha = new System.Windows.Forms.Button();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttEntrar
            // 
            this.bttEntrar.Location = new System.Drawing.Point(53, 64);
            this.bttEntrar.Name = "bttEntrar";
            this.bttEntrar.Size = new System.Drawing.Size(84, 23);
            this.bttEntrar.TabIndex = 0;
            this.bttEntrar.Text = "Entrar";
            this.bttEntrar.UseVisualStyleBackColor = true;
            this.bttEntrar.Click += new System.EventHandler(this.bttEntrar_Click);
            // 
            // bttAlterarSenha
            // 
            this.bttAlterarSenha.Location = new System.Drawing.Point(145, 64);
            this.bttAlterarSenha.Name = "bttAlterarSenha";
            this.bttAlterarSenha.Size = new System.Drawing.Size(84, 23);
            this.bttAlterarSenha.TabIndex = 1;
            this.bttAlterarSenha.Text = "Alterar Senha";
            this.bttAlterarSenha.UseVisualStyleBackColor = true;
            this.bttAlterarSenha.Click += new System.EventHandler(this.bttAlterarSenha_Click);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Location = new System.Drawing.Point(3, 36);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(41, 13);
            this.lbSenha.TabIndex = 2;
            this.lbSenha.Text = "Senha:";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(53, 33);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(176, 20);
            this.txtSenha.TabIndex = 3;
            // 
            // Telalogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 99);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.bttAlterarSenha);
            this.Controls.Add(this.bttEntrar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Telalogin";
            this.Text = "SCM - Login";
            this.Load += new System.EventHandler(this.Telalogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttEntrar;
        private System.Windows.Forms.Button bttAlterarSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txtSenha;
    }
}