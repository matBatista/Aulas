using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Aula1
{
    public partial class Form1 : Form
    {
        MySqlConnection conexao = new MySqlConnection("Database = aula; Data Source = localhost; User Id =root; Password=adm2556 ;");

        public Form1()
        {
            InitializeComponent();

            CarregaPerfil();
        }
        public void CarregaPerfil()
        {
            string sqlString = "SELECT * FROM TB_PERFIL";

            MySqlDataAdapter carregaPerfis = new MySqlDataAdapter(sqlString, conexao);
            DataSet dsPerfil = new DataSet();
            DataView dvPerfil = new DataView();

            carregaPerfis.Fill(dsPerfil, "tb_perfil");
            dvPerfil = dsPerfil.Tables["tb_perfil"].DefaultView;

            dataGridView1.DataSource = dvPerfil;
            dataGridView1.Refresh();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirma este cadastro?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //MenuPrincipal principal = new MenuPrincipal(txtPerfil.Text);
                //principal.ShowDialog();

                MySqlCommand adcionarCommando = new MySqlCommand();

                adcionarCommando.Connection = conexao;
                adcionarCommando.CommandType = CommandType.Text;

                adcionarCommando.Parameters.Add("@nome", MySqlDbType.VarChar);
                adcionarCommando.Parameters.Add("@tamanho", MySqlDbType.Int32);

                adcionarCommando.Parameters["@nome"].Value = txtPerfil.Text;
                adcionarCommando.Parameters["@tamanho"].Value = txtTamanho.Text;

                adcionarCommando.CommandText = "INSERT INTO tb_perfil (nome,tamanho) VALUES (@nome,@tamanho)";

                conexao.Open();
                try
                {
                    adcionarCommando.ExecuteNonQuery();

                    MessageBox.Show("Salvo com Sucesso");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conexao.Close();

                CarregaPerfil();
            }
            else
            {
                MessageBox.Show("Cancelado");
            }          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Finaliza sem salvar?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Cancelado");
                this.Close();
            }
        }
    }
}
