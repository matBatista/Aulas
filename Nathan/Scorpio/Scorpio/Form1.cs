using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scorpio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextA_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextB_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSenha_Click(object sender, EventArgs e)
        {

        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void ButFechar_Click(object sender, EventArgs e)
        {

        }

        private void ButEntrar_Click(object sender, EventArgs e)
        {
            if (TextA.Text != "NATHAN" || TextB.Text != "12345")
                MessageBox.Show("SENHA/USUARIO ERRADO");
            else { MessageBox.Show("Login Efetuado com Sucesso"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
