using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SCM
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void bttRetirar_Click(object sender, EventArgs e)
        {
            TelaRetirar retirar = new TelaRetirar();
            retirar.ShowDialog();
        }

        private void bttAdicionar_Click(object sender, EventArgs e)
        {
            TelaAdicionar adicionar = new TelaAdicionar();
            adicionar.ShowDialog();
        }

        private void bttRegistro_Click(object sender, EventArgs e)
        {
            TelaRegistro registro = new TelaRegistro();
            registro.ShowDialog();
        }

        private void bttRelatorio_Click(object sender, EventArgs e)
        {
            TelaRelatorio relatorio = new TelaRelatorio();
            relatorio.ShowDialog();
        }

        private void bttBackup_Click(object sender, EventArgs e)
        {
            TelaBackup backup = new TelaBackup();
            backup.ShowDialog();
        }
    }
}
