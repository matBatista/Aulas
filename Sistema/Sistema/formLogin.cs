using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = "";
            string senha = "";

            usuario = txtUsuario.Text.ToUpper();
            senha = txtSenha.Text;

            if (usuario == "RICARDO" && senha == "123")
            {
                Sistema.formMenu menu = new formMenu(usuario,senha);
                menu.Show();
            }
            else if (usuario != "RICARDO")
            {
                lblUsuario.Text = "USUARIO INCORRETO";
            }
            else if (senha != "123")
            {
                lblSenha.Text = "Senha Inválida";
            }
        }
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Fechar?","Fechar",MessageBoxButtons.YesNo) == DialogResult.Yes)
                 this.Close();

        }


    }
}
