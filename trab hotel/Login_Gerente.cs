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
    public partial class Login_Gerente : Form
    {
        public Login_Gerente()
        {
            InitializeComponent();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;

        private void BotãoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BotãoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Botao_Admin_Click(object sender, EventArgs e)
        {
            Login_Admin Login_Admin = new Login_Admin();
            Login_Admin.Show();
            this.Hide();
        }

        private void BotãoMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            BotãoMax.Visible = false;
            BotãoRestaurar.Visible = true;
        }

        private void BotãoRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            BotãoRestaurar.Visible = false;
            BotãoMax.Visible = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
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
