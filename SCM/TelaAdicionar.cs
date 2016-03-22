using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;


namespace SCM
{
    public partial class TelaAdicionar : Form
    {
        private bool aberto = false;
        public TelaAdicionar()
        {
            InitializeComponent();
        }
        private void TelaAdicionar_Load(object sender, EventArgs e)
        {
            if (!aberto)
            {
                lbMaterial.Text = "Material Existente";
                rdBttMaterialExistente.Checked = true; // O padrão é alterar a quantidade de um material existente.


                txtBxNovoMaterial.Enabled = false;
                txtBxNovoMaterial.Visible = false;
                cmbBxMaterialExistente.Enabled = true;
                cmbBxMaterialExistente.Visible = true;
                aberto = true;
            }
            using (SQLiteConnection cnn = new SQLiteConnection("data source=scm.bd"))
            {
                cnn.Open();
                string query = "SELECT nome FROM material order by nome";
                using (SQLiteCommand command = new SQLiteCommand(query, cnn))
                {
                    using (SQLiteDataReader daTodos = command.ExecuteReader())
                    {
                        while (daTodos.Read())
                        {
                            if (!daTodos.IsDBNull(0))
                            {
                                cmbBxMaterialExistente.Items.Add(daTodos["nome"]);
                            }
                        }
                        
                    }
                }
                cnn.Close();
            }
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

        private void bttSalvar_Click(object sender, EventArgs e)
        {
            if (rdBttNovoMaterial.Checked && txtBxNovoMaterial.Text.ToString() == "")
            {
                MessageBox.Show("Não esqueça de preencher o campo Novo Material.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if ( rdBttMaterialExistente.Checked && cmbBxMaterialExistente.Text.ToString() == "")
                {
                    MessageBox.Show("Não esqueça de escolha um material existente.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (mskdTxtBxQuantidade.Text.ToString() == "" || Int32.Parse(mskdTxtBxQuantidade.Text.ToString()) <1)
                    {
                        MessageBox.Show("Não esqueça de informa uma quantidade válida do material.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        using (SQLiteConnection cnn = new SQLiteConnection("data source=scm.bd"))
                        {
                            cnn.Open();
                            using (SQLiteCommand cmd = new SQLiteCommand(cnn))
                            {
                                if (rdBttNovoMaterial.Checked)
                                {
                                    cmd.CommandText = "INSERT INTO material (nome,quant) VALUES (\'" + txtBxNovoMaterial.Text.ToString().ToUpper() + "','" + mskdTxtBxQuantidade.Text.ToString() + "\')";
                                    cmd.ExecuteNonQuery();
                                }
                                else
                                {
                                    if (rdBttMaterialExistente.Checked)
                                    {
                                        cmd.CommandText = "INSERT INTO material (nome,quant) VALUES (\'" + cmbBxMaterialExistente.Text.ToString() + "','" + mskdTxtBxQuantidade.Text.ToString() + "\')";
                                        cmd.ExecuteNonQuery();
                                        //*Quando o produto já estiver cadastrado, a nova quantidade é somada com a alterior.
                                    }
                                }
                            }// fim da instancia do objeto SQLiteCommand.
                            cnn.Close();
                        } // fim da instancia do objeto SQLiteConnection. */
                        
                        MessageBox.Show("O novo material foi armazenado com sucesso.", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBxNovoMaterial.ResetText();
                        mskdTxtBxQuantidade.ResetText();
                        cmbBxMaterialExistente.ResetText();
                    }
                }
            }
            TelaAdicionar_Load(null, null);
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            DialogResult rsFechar = MessageBox.Show("Cancelar a adição de matrial ?", "Aviso!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rsFechar == DialogResult.Yes)
            {
                txtBxNovoMaterial.ResetText();
                mskdTxtBxQuantidade.ResetText();
                cmbBxMaterialExistente.ResetText();
            }
        }
    }
}
