using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trab_hotel
{
    public partial class Formulario_de_registro : Form
    {
        public Formulario_de_registro()
        {
            InitializeComponent();
        }

        private void BotãoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BotãoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login_Users Login_Users = new Login_Users();
            Login_Users.Show();
            this.Hide();
        }
    }
}
