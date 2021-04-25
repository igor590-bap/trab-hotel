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
    public partial class Menu_Gerente : Form
    {
        public Menu_Gerente()
        {
            InitializeComponent();
        }

        private void BotãoFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BotãoMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int IParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BThospedes_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void MenuBarrasLaterais_Click(object sender, EventArgs e)
        {
            if(BarraLateralDentro.Width == 220)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Botao_sair_Click(object sender, EventArgs e)
        {
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Login_Gerente Login_Gerente = new Login_Gerente();
            Login_Gerente.Show();
            this.Hide();
        }

        private void BarraLateral_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Botao_Clientes_Click(object sender, EventArgs e)
        {
            extensao_clientes.Visible = true;
        }

        private void BarraLateralDentro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LinhaSidebar_Load(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
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

        private void botao_checkin_Click_1(object sender, EventArgs e)
        {
            extensao_clientes.Visible = false;
            Abrirpaginas(new checkin());
        }

        private void botao_checkout_Click(object sender, EventArgs e)
        {
            extensao_clientes.Visible = false;
            Abrirpaginas(new checkout());
        }

        private void Botao_quartos_Click(object sender, EventArgs e)
        {
            Abrirpaginas(new quartos());
        }

        private void Botao_funcionarios_Click(object sender, EventArgs e)
        {
            Abrirpaginas(new funcionarios());
        }

        private void Botao_relatorios_Click(object sender, EventArgs e)
        {
            Abrirpaginas(new relatorios());
        }
    }
}
