using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula1
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal(string perfil)
        {
            InitializeComponent();

            lblNome.Text = perfil;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
