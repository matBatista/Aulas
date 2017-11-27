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
    public partial class formMenu : Form
    {
        string usuario = "TESTE USUARIO";
        string senha = "123456789";

        public formMenu(string usuario, string senha)
        {
            InitializeComponent();

            this.usuario = usuario;
            this.senha = senha;

            lblUsuario.Text = this.usuario;
            lblSenha.Text = this.senha;



        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

        }

        private void formMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
