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
    public partial class Login_Users : Form
    {
        

        public Login_Users()
        {
            InitializeComponent();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void BotãoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotãoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Botao_Admin_Click(object sender, EventArgs e)
        {
            Login_Admin Login_Admin = new Login_Admin();
            Login_Admin.Show();
            this.Hide();
        }

        private void Botao_criarconta_Click(object sender, EventArgs e)
        {
            Formulario_de_registro formulario_De_Registro = new Formulario_de_registro();
            formulario_De_Registro.Show();
            this.Hide();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Botao_Login_Click(object sender, EventArgs e)
        {

        }

        private void Botao_Gerente_Click(object sender, EventArgs e)
        {
            Login_Gerente Login_Gerente = new Login_Gerente();
            Login_Gerente.Show();
            this.Hide();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }
    }
}
