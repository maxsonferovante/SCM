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
    public partial class TelaRetirar : Form
    {
        private int quantidade = 0;
        public TelaRetirar()
        {
            InitializeComponent();
        }

        private void TelaRetirar_Load(object sender, EventArgs e)
        {
            mskdTxtBxDataRetirada.Text = DateTime.Now.ToString("dd-MM-yyyy"); // Inicialização da data (com a do dia vigente) de retirada do material.
            
            /*Preenchendo o combobox de materias.*/
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
                                cmbBxMaterial.Items.Add(daTodos["nome"]);
                            }
                        }
                    }
                } //Fim do SQLiteCommand
                cnn.Close();
            } //Fim do SQLiteConnection.
        }

        private void cmbBxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxMaterial.SelectedIndex >= 0)
            /* Para atualizar o textbox 'quantidade em estoque.'*/
            {
                using (SQLiteConnection cnn = new SQLiteConnection("data source=scm.bd"))
                {
                    cnn.Open();
                    string query = "SELECT *FROM material WHERE nome = '" + cmbBxMaterial.Text.ToString() +"'";
                    using (SQLiteCommand command = new SQLiteCommand(query, cnn))
                    {
                        using (SQLiteDataReader daTodos = command.ExecuteReader())
                        {
                            daTodos.Read();
                            txtBxQuantEstoque.Text = daTodos["quant"].ToString();
                            if (0 == Int32.Parse(daTodos["quant"].ToString()))
                                mskdTxtBxQuantidade.Enabled = false;
                            else
                                mskdTxtBxQuantidade.Enabled = true;
                        }
                    } //Fim do SQLiteCommand
                    cnn.Close();
                } //Fim do SQLiteConnection.
            }
        }

     }
}
