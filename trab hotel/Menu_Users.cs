using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace trab_hotel
{
    public partial class Menu_Users : Form
    {
        public Menu_Users()
        {
            InitializeComponent();
        }

        int mouseX = 0, mouseY = 0;
        bool mouseDown;
        private void BarraLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuBarrasLaterais_Click(object sender, EventArgs e)
        {
            if (BarraLateralDentro.Width == 220)
            {
                BarraLateralDentro.Visible = false;
                BarraLateralDentro.Width = 75;
                BarraLateral.Width = 97;
                LinhaSidebar.Width = 50;
                AnimacaoBarraLateral.Show(BarraLateralDentro);
            }
            else
            {
                BarraLateralDentro.Visible = false;
                BarraLateralDentro.Width = 220;
                BarraLateral.Width = 242;
                LinhaSidebar.Width = 195;
                AnimacaoBarraLateral_Volta.Show(BarraLateralDentro);
            }
        }

   

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

       

        private void BotãoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BotãoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_Users_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Menu_Users_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
        }

        private void BarraTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void BarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                mouseX = MousePosition.X - 200;
                mouseY = MousePosition.Y - 40;

                this.SetDesktopLocation(mouseX, mouseY);
            }
        }

        private void Botao_logout_Click(object sender, EventArgs e)
        {
            Login_Users Login_Users = new Login_Users();
            Login_Users.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Users_MouseDown(object sender, MouseEventArgs e)
        {
            
        }
        private void Abrirpaginas(object paginas)
        {
            if (this.BarraCentral.Controls.Count > 0)
                this.BarraCentral.Controls.RemoveAt(0);
            Form fh = paginas as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.BarraCentral.Controls.Add(fh);
            this.BarraCentral.Tag = fh;
            fh.Show();
        }

        private void Botao_quartos_Click(object sender, EventArgs e)
        {
            Abrirpaginas(new quartos());
        }

        private void Botao_Reservas_Click(object sender, EventArgs e)
        {
            Abrirpaginas(new reservas());
        }

        private void Botao_fazer_checkin_Click(object sender, EventArgs e)
        {
            Abrirpaginas(new checkin());
        }
    }
}
