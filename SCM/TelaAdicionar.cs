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
    public partial class TelaAdicionar : Form
    {
        public TelaAdicionar()
        {
            InitializeComponent();
        }
        private void TelaAdicionar_Load(object sender, EventArgs e)
        {
            lbMaterial.Text = "Novo Material";
            rdBttNovoMaterial.Checked = true;
            txtBxNovoMaterial.Enabled = true;
            txtBxNovoMaterial.Visible = true;
            cmbBxMaterialExistente.Enabled = false;
            cmbBxMaterialExistente.Visible = false;
        }

        private void rdBttNovoMaterial_CheckedChanged(object sender, EventArgs e)
        {
            lbMaterial.Text = "Novo Material";
            txtBxNovoMaterial.Enabled = true;
            txtBxNovoMaterial.Visible = true;
            cmbBxMaterialExistente.Enabled = false;
            cmbBxMaterialExistente.Visible = false;
        }

        private void rdBttMaterialExistente_CheckedChanged(object sender, EventArgs e)
        {
            lbMaterial.Text = "Material Existente";
            txtBxNovoMaterial.Enabled = false;
            txtBxNovoMaterial.Visible = false;
            cmbBxMaterialExistente.Enabled = true;
            cmbBxMaterialExistente.Visible = true;
        }
    }
}
