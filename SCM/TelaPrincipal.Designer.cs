namespace SCM
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.bttRetirar = new System.Windows.Forms.Button();
            this.bttAdicionar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttRelatorio = new System.Windows.Forms.Button();
            this.bttRegistro = new System.Windows.Forms.Button();
            this.bttBackup = new System.Windows.Forms.Button();
            this.bttnCadFuncionarios = new System.Windows.Forms.Button();
            this.bttnSobre = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttRetirar
            // 
            this.bttRetirar.Location = new System.Drawing.Point(12, 12);
            this.bttRetirar.Name = "bttRetirar";
            this.bttRetirar.Size = new System.Drawing.Size(75, 47);
            this.bttRetirar.TabIndex = 0;
            this.bttRetirar.Text = "Retirada de Material";
            this.bttRetirar.UseVisualStyleBackColor = true;
            this.bttRetirar.Click += new System.EventHandler(this.bttRetirar_Click);
            // 
            // bttAdicionar
            // 
            this.bttAdicionar.Location = new System.Drawing.Point(93, 12);
            this.bttAdicionar.Name = "bttAdicionar";
            this.bttAdicionar.Size = new System.Drawing.Size(75, 47);
            this.bttAdicionar.TabIndex = 1;
            this.bttAdicionar.Text = "Adição de Material";
            this.bttAdicionar.UseVisualStyleBackColor = true;
            this.bttAdicionar.Click += new System.EventHandler(this.bttAdicionar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(664, 260);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bttRelatorio
            // 
            this.bttRelatorio.Location = new System.Drawing.Point(390, 12);
            this.bttRelatorio.Name = "bttRelatorio";
            this.bttRelatorio.Size = new System.Drawing.Size(75, 47);
            this.bttRelatorio.TabIndex = 3;
            this.bttRelatorio.Text = "Relatórios dos Materias";
            this.bttRelatorio.UseVisualStyleBackColor = true;
            this.bttRelatorio.Click += new System.EventHandler(this.bttRelatorio_Click);
            // 
            // bttRegistro
            // 
            this.bttRegistro.Location = new System.Drawing.Point(228, 12);
            this.bttRegistro.Name = "bttRegistro";
            this.bttRegistro.Size = new System.Drawing.Size(75, 47);
            this.bttRegistro.TabIndex = 4;
            this.bttRegistro.Text = "Registro de Materias";
            this.bttRegistro.UseVisualStyleBackColor = true;
            this.bttRegistro.Click += new System.EventHandler(this.bttRegistro_Click);
            // 
            // bttBackup
            // 
            this.bttBackup.Location = new System.Drawing.Point(520, 12);
            this.bttBackup.Name = "bttBackup";
            this.bttBackup.Size = new System.Drawing.Size(75, 47);
            this.bttBackup.TabIndex = 5;
            this.bttBackup.Text = "Backup";
            this.bttBackup.UseVisualStyleBackColor = true;
            this.bttBackup.Click += new System.EventHandler(this.bttBackup_Click);
            // 
            // bttnCadFuncionarios
            // 
            this.bttnCadFuncionarios.Location = new System.Drawing.Point(309, 12);
            this.bttnCadFuncionarios.Name = "bttnCadFuncionarios";
            this.bttnCadFuncionarios.Size = new System.Drawing.Size(75, 47);
            this.bttnCadFuncionarios.TabIndex = 6;
            this.bttnCadFuncionarios.Text = "Cadastro de Funcionários";
            this.bttnCadFuncionarios.UseVisualStyleBackColor = true;
            this.bttnCadFuncionarios.Click += new System.EventHandler(this.bttnCadFuncionarios_Click);
            // 
            // bttnSobre
            // 
            this.bttnSobre.Location = new System.Drawing.Point(601, 12);
            this.bttnSobre.Name = "bttnSobre";
            this.bttnSobre.Size = new System.Drawing.Size(75, 47);
            this.bttnSobre.TabIndex = 7;
            this.bttnSobre.Text = "Sobre";
            this.bttnSobre.UseVisualStyleBackColor = true;
            this.bttnSobre.Click += new System.EventHandler(this.bttnSobre_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 341);
            this.Controls.Add(this.bttnSobre);
            this.Controls.Add(this.bttnCadFuncionarios);
            this.Controls.Add(this.bttBackup);
            this.Controls.Add(this.bttRegistro);
            this.Controls.Add(this.bttRelatorio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bttAdicionar);
            this.Controls.Add(this.bttRetirar);
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCM - Divisão de Informática";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttRetirar;
        private System.Windows.Forms.Button bttAdicionar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttRelatorio;
        private System.Windows.Forms.Button bttRegistro;
        private System.Windows.Forms.Button bttBackup;
        private System.Windows.Forms.Button bttnCadFuncionarios;
        private System.Windows.Forms.Button bttnSobre;
    }
}