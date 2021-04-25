
namespace trab_hotel
{
    partial class Menu_Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Admin));
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Logo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BotãoMinimizar = new System.Windows.Forms.PictureBox();
            this.BotãoFechar = new System.Windows.Forms.PictureBox();
            this.BarraLateral = new System.Windows.Forms.Panel();
            this.BarraLateralDentro = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.botao_checkout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.botao_checkin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Botao_Clientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Botao_logout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.MenuBarrasLaterais = new System.Windows.Forms.PictureBox();
            this.Botao_quartos = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Botao_Reservas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.LinhaSidebar = new Bunifu.Framework.UI.BunifuSeparator();
            this.AnimacaoBarraLateral_Volta = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.BarraCentral = new System.Windows.Forms.Panel();
            this.AnimacaoBarraLateral = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Curva_logout = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CurvaBarraLateralDentro = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Curva_cliente = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Curva_reservas = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Curva_quartos = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Curva_funcionarios = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Curva_relatorios = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.extensao_clientes = new System.Windows.Forms.Panel();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BotãoMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotãoFechar)).BeginInit();
            this.BarraLateral.SuspendLayout();
            this.BarraLateralDentro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBarrasLaterais)).BeginInit();
            this.extensao_clientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.BarraTitulo.Controls.Add(this.bunifuFlatButton1);
            this.BarraTitulo.Controls.Add(this.Logo);
            this.BarraTitulo.Controls.Add(this.BotãoMinimizar);
            this.BarraTitulo.Controls.Add(this.BotãoFechar);
            this.AnimacaoBarraLateral.SetDecoration(this.BarraTitulo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.BarraTitulo, BunifuAnimatorNS.DecorationType.None);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1300, 68);
            this.BarraTitulo.TabIndex = 1;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "MENU ADMIN";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral.SetDecoration(this.bunifuFlatButton1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 100D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(23, 14);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.PaleTurquoise;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(195, 48);
            this.bunifuFlatButton1.TabIndex = 11;
            this.bunifuFlatButton1.Text = "MENU ADMIN";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("OldSansBlack", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Logo
            // 
            this.Logo.Activecolor = System.Drawing.Color.Transparent;
            this.Logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Logo.BorderRadius = 0;
            this.Logo.ButtonText = "   HOTELOGIC";
            this.Logo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral.SetDecoration(this.Logo, BunifuAnimatorNS.DecorationType.None);
            this.Logo.DisabledColor = System.Drawing.Color.Gray;
            this.Logo.Iconcolor = System.Drawing.Color.Transparent;
            this.Logo.Iconimage = null;
            this.Logo.Iconimage_right = ((System.Drawing.Image)(resources.GetObject("Logo.Iconimage_right")));
            this.Logo.Iconimage_right_Selected = null;
            this.Logo.Iconimage_Selected = null;
            this.Logo.IconMarginLeft = 0;
            this.Logo.IconMarginRight = 0;
            this.Logo.IconRightVisible = true;
            this.Logo.IconRightZoom = 0D;
            this.Logo.IconVisible = true;
            this.Logo.IconZoom = 100D;
            this.Logo.IsTab = false;
            this.Logo.Location = new System.Drawing.Point(640, 12);
            this.Logo.Name = "Logo";
            this.Logo.Normalcolor = System.Drawing.Color.Transparent;
            this.Logo.OnHovercolor = System.Drawing.Color.Transparent;
            this.Logo.OnHoverTextColor = System.Drawing.Color.PaleTurquoise;
            this.Logo.selected = false;
            this.Logo.Size = new System.Drawing.Size(251, 48);
            this.Logo.TabIndex = 10;
            this.Logo.Text = "   HOTELOGIC";
            this.Logo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Logo.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.Logo.TextFont = new System.Drawing.Font("OldSansBlack", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BotãoMinimizar
            // 
            this.BotãoMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotãoMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.BotãoMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral.SetDecoration(this.BotãoMinimizar, BunifuAnimatorNS.DecorationType.None);
            this.BotãoMinimizar.Image = global::trab_hotel.Properties.Resources.diminuir1;
            this.BotãoMinimizar.Location = new System.Drawing.Point(1202, 20);
            this.BotãoMinimizar.Name = "BotãoMinimizar";
            this.BotãoMinimizar.Size = new System.Drawing.Size(31, 25);
            this.BotãoMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotãoMinimizar.TabIndex = 2;
            this.BotãoMinimizar.TabStop = false;
            this.BotãoMinimizar.Click += new System.EventHandler(this.BotãoMinimizar_Click);
            // 
            // BotãoFechar
            // 
            this.BotãoFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BotãoFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BotãoFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.BotãoFechar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral.SetDecoration(this.BotãoFechar, BunifuAnimatorNS.DecorationType.None);
            this.BotãoFechar.Image = global::trab_hotel.Properties.Resources.application_exit_icon_181084;
            this.BotãoFechar.Location = new System.Drawing.Point(1251, 20);
            this.BotãoFechar.Name = "BotãoFechar";
            this.BotãoFechar.Size = new System.Drawing.Size(28, 25);
            this.BotãoFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BotãoFechar.TabIndex = 0;
            this.BotãoFechar.TabStop = false;
            this.BotãoFechar.Click += new System.EventHandler(this.BotãoFechar_Click);
            // 
            // BarraLateral
            // 
            this.BarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.BarraLateral.Controls.Add(this.BarraLateralDentro);
            this.AnimacaoBarraLateral.SetDecoration(this.BarraLateral, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.BarraLateral, BunifuAnimatorNS.DecorationType.None);
            this.BarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.BarraLateral.Location = new System.Drawing.Point(0, 68);
            this.BarraLateral.Name = "BarraLateral";
            this.BarraLateral.Size = new System.Drawing.Size(242, 582);
            this.BarraLateral.TabIndex = 2;
            this.BarraLateral.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraLateral_Paint);
            // 
            // BarraLateralDentro
            // 
            this.BarraLateralDentro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BarraLateralDentro.BackgroundImage")));
            this.BarraLateralDentro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BarraLateralDentro.Controls.Add(this.extensao_clientes);
            this.BarraLateralDentro.Controls.Add(this.Botao_Reservas);
            this.BarraLateralDentro.Controls.Add(this.Botao_quartos);
            this.BarraLateralDentro.Controls.Add(this.Botao_Clientes);
            this.BarraLateralDentro.Controls.Add(this.Botao_logout);
            this.BarraLateralDentro.Controls.Add(this.label1);
            this.BarraLateralDentro.Controls.Add(this.MenuBarrasLaterais);
            this.BarraLateralDentro.Controls.Add(this.LinhaSidebar);
            this.AnimacaoBarraLateral.SetDecoration(this.BarraLateralDentro, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.BarraLateralDentro, BunifuAnimatorNS.DecorationType.None);
            this.BarraLateralDentro.GradientBottomLeft = System.Drawing.Color.Aquamarine;
            this.BarraLateralDentro.GradientBottomRight = System.Drawing.Color.MediumTurquoise;
            this.BarraLateralDentro.GradientTopLeft = System.Drawing.Color.Turquoise;
            this.BarraLateralDentro.GradientTopRight = System.Drawing.Color.DarkSlateGray;
            this.BarraLateralDentro.Location = new System.Drawing.Point(12, 6);
            this.BarraLateralDentro.Name = "BarraLateralDentro";
            this.BarraLateralDentro.Quality = 10;
            this.BarraLateralDentro.Size = new System.Drawing.Size(220, 564);
            this.BarraLateralDentro.TabIndex = 1;
            this.BarraLateralDentro.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraLateralDentro_Paint);
            // 
            // botao_checkout
            // 
            this.botao_checkout.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.botao_checkout.BackColor = System.Drawing.Color.Transparent;
            this.botao_checkout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_checkout.BorderRadius = 7;
            this.botao_checkout.ButtonText = "    CHECK-OUT";
            this.botao_checkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.botao_checkout, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral.SetDecoration(this.botao_checkout, BunifuAnimatorNS.DecorationType.None);
            this.botao_checkout.DisabledColor = System.Drawing.Color.Gray;
            this.botao_checkout.Iconcolor = System.Drawing.Color.Transparent;
            this.botao_checkout.Iconimage = ((System.Drawing.Image)(resources.GetObject("botao_checkout.Iconimage")));
            this.botao_checkout.Iconimage_right = null;
            this.botao_checkout.Iconimage_right_Selected = null;
            this.botao_checkout.Iconimage_Selected = null;
            this.botao_checkout.IconMarginLeft = 0;
            this.botao_checkout.IconMarginRight = 0;
            this.botao_checkout.IconRightVisible = true;
            this.botao_checkout.IconRightZoom = 0D;
            this.botao_checkout.IconVisible = true;
            this.botao_checkout.IconZoom = 70D;
            this.botao_checkout.IsTab = false;
            this.botao_checkout.Location = new System.Drawing.Point(4, 65);
            this.botao_checkout.Name = "botao_checkout";
            this.botao_checkout.Normalcolor = System.Drawing.Color.Transparent;
            this.botao_checkout.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.botao_checkout.OnHoverTextColor = System.Drawing.Color.White;
            this.botao_checkout.selected = false;
            this.botao_checkout.Size = new System.Drawing.Size(184, 40);
            this.botao_checkout.TabIndex = 14;
            this.botao_checkout.Text = "    CHECK-OUT";
            this.botao_checkout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botao_checkout.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.botao_checkout.TextFont = new System.Drawing.Font("OldSansBlack", 9.749999F, System.Drawing.FontStyle.Bold);
            this.botao_checkout.Click += new System.EventHandler(this.botao_checkout_Click);
            // 
            // botao_checkin
            // 
            this.botao_checkin.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.botao_checkin.BackColor = System.Drawing.Color.Transparent;
            this.botao_checkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botao_checkin.BorderRadius = 7;
            this.botao_checkin.ButtonText = "    CHECK-IN";
            this.botao_checkin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.botao_checkin, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral.SetDecoration(this.botao_checkin, BunifuAnimatorNS.DecorationType.None);
            this.botao_checkin.DisabledColor = System.Drawing.Color.Gray;
            this.botao_checkin.Iconcolor = System.Drawing.Color.Transparent;
            this.botao_checkin.Iconimage = ((System.Drawing.Image)(resources.GetObject("botao_checkin.Iconimage")));
            this.botao_checkin.Iconimage_right = null;
            this.botao_checkin.Iconimage_right_Selected = null;
            this.botao_checkin.Iconimage_Selected = null;
            this.botao_checkin.IconMarginLeft = 0;
            this.botao_checkin.IconMarginRight = 0;
            this.botao_checkin.IconRightVisible = true;
            this.botao_checkin.IconRightZoom = 0D;
            this.botao_checkin.IconVisible = true;
            this.botao_checkin.IconZoom = 70D;
            this.botao_checkin.IsTab = false;
            this.botao_checkin.Location = new System.Drawing.Point(4, 3);
            this.botao_checkin.Name = "botao_checkin";
            this.botao_checkin.Normalcolor = System.Drawing.Color.Transparent;
            this.botao_checkin.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.botao_checkin.OnHoverTextColor = System.Drawing.Color.White;
            this.botao_checkin.selected = false;
            this.botao_checkin.Size = new System.Drawing.Size(184, 42);
            this.botao_checkin.TabIndex = 13;
            this.botao_checkin.Text = "    CHECK-IN";
            this.botao_checkin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botao_checkin.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.botao_checkin.TextFont = new System.Drawing.Font("OldSansBlack", 9.749999F, System.Drawing.FontStyle.Bold);
            this.botao_checkin.Click += new System.EventHandler(this.botao_checkin_Click);
            // 
            // Botao_Clientes
            // 
            this.Botao_Clientes.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.Botao_Clientes.BackColor = System.Drawing.Color.Transparent;
            this.Botao_Clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Clientes.BorderRadius = 7;
            this.Botao_Clientes.ButtonText = "  CLIENTES";
            this.Botao_Clientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.Botao_Clientes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral.SetDecoration(this.Botao_Clientes, BunifuAnimatorNS.DecorationType.None);
            this.Botao_Clientes.DisabledColor = System.Drawing.Color.Gray;
            this.Botao_Clientes.Iconcolor = System.Drawing.Color.Transparent;
            this.Botao_Clientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("Botao_Clientes.Iconimage")));
            this.Botao_Clientes.Iconimage_right = null;
            this.Botao_Clientes.Iconimage_right_Selected = null;
            this.Botao_Clientes.Iconimage_Selected = null;
            this.Botao_Clientes.IconMarginLeft = 0;
            this.Botao_Clientes.IconMarginRight = 0;
            this.Botao_Clientes.IconRightVisible = true;
            this.Botao_Clientes.IconRightZoom = 0D;
            this.Botao_Clientes.IconVisible = true;
            this.Botao_Clientes.IconZoom = 100D;
            this.Botao_Clientes.IsTab = false;
            this.Botao_Clientes.Location = new System.Drawing.Point(12, 278);
            this.Botao_Clientes.Name = "Botao_Clientes";
            this.Botao_Clientes.Normalcolor = System.Drawing.Color.Transparent;
            this.Botao_Clientes.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.Botao_Clientes.OnHoverTextColor = System.Drawing.Color.White;
            this.Botao_Clientes.selected = false;
            this.Botao_Clientes.Size = new System.Drawing.Size(194, 49);
            this.Botao_Clientes.TabIndex = 7;
            this.Botao_Clientes.Text = "  CLIENTES";
            this.Botao_Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botao_Clientes.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.Botao_Clientes.TextFont = new System.Drawing.Font("OldSansBlack", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Clientes.Click += new System.EventHandler(this.Botao_Clientes_Click);
            // 
            // Botao_logout
            // 
            this.Botao_logout.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.Botao_logout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Botao_logout.BackColor = System.Drawing.Color.Transparent;
            this.Botao_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_logout.BorderRadius = 0;
            this.Botao_logout.ButtonText = "        LOGOUT";
            this.Botao_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.Botao_logout, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral.SetDecoration(this.Botao_logout, BunifuAnimatorNS.DecorationType.None);
            this.Botao_logout.DisabledColor = System.Drawing.Color.Gray;
            this.Botao_logout.Iconcolor = System.Drawing.Color.Transparent;
            this.Botao_logout.Iconimage = ((System.Drawing.Image)(resources.GetObject("Botao_logout.Iconimage")));
            this.Botao_logout.Iconimage_right = null;
            this.Botao_logout.Iconimage_right_Selected = null;
            this.Botao_logout.Iconimage_Selected = null;
            this.Botao_logout.IconMarginLeft = 0;
            this.Botao_logout.IconMarginRight = 0;
            this.Botao_logout.IconRightVisible = true;
            this.Botao_logout.IconRightZoom = 0D;
            this.Botao_logout.IconVisible = true;
            this.Botao_logout.IconZoom = 55D;
            this.Botao_logout.IsTab = false;
            this.Botao_logout.Location = new System.Drawing.Point(22, 523);
            this.Botao_logout.Name = "Botao_logout";
            this.Botao_logout.Normalcolor = System.Drawing.Color.Transparent;
            this.Botao_logout.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.Botao_logout.OnHoverTextColor = System.Drawing.Color.White;
            this.Botao_logout.selected = false;
            this.Botao_logout.Size = new System.Drawing.Size(184, 27);
            this.Botao_logout.TabIndex = 12;
            this.Botao_logout.Text = "        LOGOUT";
            this.Botao_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botao_logout.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.Botao_logout.TextFont = new System.Drawing.Font("OldSansBlack", 9.749999F, System.Drawing.FontStyle.Bold);
            this.Botao_logout.Click += new System.EventHandler(this.Botao_logout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("OldSansBlack", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(84, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // MenuBarrasLaterais
            // 
            this.MenuBarrasLaterais.BackColor = System.Drawing.Color.Transparent;
            this.MenuBarrasLaterais.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.MenuBarrasLaterais, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral.SetDecoration(this.MenuBarrasLaterais, BunifuAnimatorNS.DecorationType.None);
            this.MenuBarrasLaterais.Image = ((System.Drawing.Image)(resources.GetObject("MenuBarrasLaterais.Image")));
            this.MenuBarrasLaterais.Location = new System.Drawing.Point(13, 27);
            this.MenuBarrasLaterais.Name = "MenuBarrasLaterais";
            this.MenuBarrasLaterais.Size = new System.Drawing.Size(40, 35);
            this.MenuBarrasLaterais.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuBarrasLaterais.TabIndex = 4;
            this.MenuBarrasLaterais.TabStop = false;
            this.MenuBarrasLaterais.Click += new System.EventHandler(this.MenuBarrasLaterais_Click);
            // 
            // Botao_quartos
            // 
            this.Botao_quartos.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.Botao_quartos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Botao_quartos.BackColor = System.Drawing.Color.Transparent;
            this.Botao_quartos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_quartos.BorderRadius = 0;
            this.Botao_quartos.ButtonText = "    QUARTOS";
            this.Botao_quartos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.Botao_quartos, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral.SetDecoration(this.Botao_quartos, BunifuAnimatorNS.DecorationType.None);
            this.Botao_quartos.DisabledColor = System.Drawing.Color.Gray;
            this.Botao_quartos.Iconcolor = System.Drawing.Color.Transparent;
            this.Botao_quartos.Iconimage = ((System.Drawing.Image)(resources.GetObject("Botao_quartos.Iconimage")));
            this.Botao_quartos.Iconimage_right = null;
            this.Botao_quartos.Iconimage_right_Selected = null;
            this.Botao_quartos.Iconimage_Selected = null;
            this.Botao_quartos.IconMarginLeft = 0;
            this.Botao_quartos.IconMarginRight = 0;
            this.Botao_quartos.IconRightVisible = true;
            this.Botao_quartos.IconRightZoom = 0D;
            this.Botao_quartos.IconVisible = true;
            this.Botao_quartos.IconZoom = 70D;
            this.Botao_quartos.IsTab = false;
            this.Botao_quartos.Location = new System.Drawing.Point(12, 204);
            this.Botao_quartos.Name = "Botao_quartos";
            this.Botao_quartos.Normalcolor = System.Drawing.Color.Transparent;
            this.Botao_quartos.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.Botao_quartos.OnHoverTextColor = System.Drawing.Color.White;
            this.Botao_quartos.selected = false;
            this.Botao_quartos.Size = new System.Drawing.Size(195, 48);
            this.Botao_quartos.TabIndex = 5;
            this.Botao_quartos.Text = "    QUARTOS";
            this.Botao_quartos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botao_quartos.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.Botao_quartos.TextFont = new System.Drawing.Font("OldSansBlack", 9.749999F, System.Drawing.FontStyle.Bold);
            this.Botao_quartos.Click += new System.EventHandler(this.Botao_quartos_Click);
            // 
            // Botao_Reservas
            // 
            this.Botao_Reservas.Activecolor = System.Drawing.Color.LightSeaGreen;
            this.Botao_Reservas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Botao_Reservas.BackColor = System.Drawing.Color.Transparent;
            this.Botao_Reservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Botao_Reservas.BorderRadius = 0;
            this.Botao_Reservas.ButtonText = "    RESERVAS";
            this.Botao_Reservas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.Botao_Reservas, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral.SetDecoration(this.Botao_Reservas, BunifuAnimatorNS.DecorationType.None);
            this.Botao_Reservas.DisabledColor = System.Drawing.Color.Gray;
            this.Botao_Reservas.Iconcolor = System.Drawing.Color.Transparent;
            this.Botao_Reservas.Iconimage = ((System.Drawing.Image)(resources.GetObject("Botao_Reservas.Iconimage")));
            this.Botao_Reservas.Iconimage_right = null;
            this.Botao_Reservas.Iconimage_right_Selected = null;
            this.Botao_Reservas.Iconimage_Selected = null;
            this.Botao_Reservas.IconMarginLeft = 0;
            this.Botao_Reservas.IconMarginRight = 0;
            this.Botao_Reservas.IconRightVisible = true;
            this.Botao_Reservas.IconRightZoom = 0D;
            this.Botao_Reservas.IconVisible = true;
            this.Botao_Reservas.IconZoom = 70D;
            this.Botao_Reservas.IsTab = false;
            this.Botao_Reservas.Location = new System.Drawing.Point(12, 133);
            this.Botao_Reservas.Name = "Botao_Reservas";
            this.Botao_Reservas.Normalcolor = System.Drawing.Color.Transparent;
            this.Botao_Reservas.OnHovercolor = System.Drawing.Color.LightSeaGreen;
            this.Botao_Reservas.OnHoverTextColor = System.Drawing.Color.White;
            this.Botao_Reservas.selected = false;
            this.Botao_Reservas.Size = new System.Drawing.Size(195, 48);
            this.Botao_Reservas.TabIndex = 4;
            this.Botao_Reservas.Text = "    RESERVAS";
            this.Botao_Reservas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Botao_Reservas.Textcolor = System.Drawing.Color.WhiteSmoke;
            this.Botao_Reservas.TextFont = new System.Drawing.Font("OldSansBlack", 9.749999F, System.Drawing.FontStyle.Bold);
            // 
            // LinhaSidebar
            // 
            this.LinhaSidebar.BackColor = System.Drawing.Color.Transparent;
            this.AnimacaoBarraLateral.SetDecoration(this.LinhaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.LinhaSidebar, BunifuAnimatorNS.DecorationType.None);
            this.LinhaSidebar.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LinhaSidebar.LineThickness = 2;
            this.LinhaSidebar.Location = new System.Drawing.Point(12, 68);
            this.LinhaSidebar.Name = "LinhaSidebar";
            this.LinhaSidebar.Size = new System.Drawing.Size(195, 17);
            this.LinhaSidebar.TabIndex = 9;
            this.LinhaSidebar.Transparency = 255;
            this.LinhaSidebar.Vertical = false;
            // 
            // AnimacaoBarraLateral_Volta
            // 
            this.AnimacaoBarraLateral_Volta.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.AnimacaoBarraLateral_Volta.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.AnimacaoBarraLateral_Volta.DefaultAnimation = animation1;
            // 
            // BarraCentral
            // 
            this.BarraCentral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.AnimacaoBarraLateral.SetDecoration(this.BarraCentral, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.BarraCentral, BunifuAnimatorNS.DecorationType.None);
            this.BarraCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarraCentral.Location = new System.Drawing.Point(242, 68);
            this.BarraCentral.Name = "BarraCentral";
            this.BarraCentral.Size = new System.Drawing.Size(1058, 582);
            this.BarraCentral.TabIndex = 4;
            // 
            // AnimacaoBarraLateral
            // 
            this.AnimacaoBarraLateral.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.AnimacaoBarraLateral.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.AnimacaoBarraLateral.DefaultAnimation = animation2;
            // 
            // Curva_logout
            // 
            this.Curva_logout.ElipseRadius = 7;
            this.Curva_logout.TargetControl = this.Botao_logout;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // CurvaBarraLateralDentro
            // 
            this.CurvaBarraLateralDentro.ElipseRadius = 7;
            this.CurvaBarraLateralDentro.TargetControl = this.BarraLateralDentro;
            // 
            // Curva_cliente
            // 
            this.Curva_cliente.ElipseRadius = 7;
            this.Curva_cliente.TargetControl = this.Botao_Clientes;
            // 
            // Curva_reservas
            // 
            this.Curva_reservas.ElipseRadius = 7;
            this.Curva_reservas.TargetControl = this.Botao_Reservas;
            // 
            // Curva_quartos
            // 
            this.Curva_quartos.ElipseRadius = 7;
            this.Curva_quartos.TargetControl = this.Botao_quartos;
            // 
            // Curva_funcionarios
            // 
            this.Curva_funcionarios.ElipseRadius = 7;
            this.Curva_funcionarios.TargetControl = this;
            // 
            // Curva_relatorios
            // 
            this.Curva_relatorios.ElipseRadius = 7;
            this.Curva_relatorios.TargetControl = this;
            // 
            // extensao_clientes
            // 
            this.extensao_clientes.BackColor = System.Drawing.Color.Transparent;
            this.extensao_clientes.Controls.Add(this.botao_checkin);
            this.extensao_clientes.Controls.Add(this.botao_checkout);
            this.AnimacaoBarraLateral.SetDecoration(this.extensao_clientes, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral_Volta.SetDecoration(this.extensao_clientes, BunifuAnimatorNS.DecorationType.None);
            this.extensao_clientes.Location = new System.Drawing.Point(12, 333);
            this.extensao_clientes.Name = "extensao_clientes";
            this.extensao_clientes.Size = new System.Drawing.Size(197, 108);
            this.extensao_clientes.TabIndex = 15;
            this.extensao_clientes.Visible = false;
            // 
            // Menu_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 650);
            this.Controls.Add(this.BarraCentral);
            this.Controls.Add(this.BarraLateral);
            this.Controls.Add(this.BarraTitulo);
            this.AnimacaoBarraLateral.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.AnimacaoBarraLateral_Volta.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Admin";
            this.ShowIcon = false;
            this.Text = "Menu_Admin";
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BotãoMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BotãoFechar)).EndInit();
            this.BarraLateral.ResumeLayout(false);
            this.BarraLateralDentro.ResumeLayout(false);
            this.BarraLateralDentro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuBarrasLaterais)).EndInit();
            this.extensao_clientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private Bunifu.Framework.UI.BunifuFlatButton Logo;
        private System.Windows.Forms.PictureBox BotãoMinimizar;
        private System.Windows.Forms.PictureBox BotãoFechar;
        private System.Windows.Forms.Panel BarraLateral;
        private Bunifu.Framework.UI.BunifuGradientPanel BarraLateralDentro;
        private Bunifu.Framework.UI.BunifuFlatButton Botao_logout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox MenuBarrasLaterais;
        private Bunifu.Framework.UI.BunifuFlatButton Botao_quartos;
        private Bunifu.Framework.UI.BunifuFlatButton Botao_Reservas;
        private Bunifu.Framework.UI.BunifuFlatButton Botao_Clientes;
        private Bunifu.Framework.UI.BunifuSeparator LinhaSidebar;
        private BunifuAnimatorNS.BunifuTransition AnimacaoBarraLateral_Volta;
        private BunifuAnimatorNS.BunifuTransition AnimacaoBarraLateral;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Bunifu.Framework.UI.BunifuElipse Curva_logout;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse CurvaBarraLateralDentro;
        private Bunifu.Framework.UI.BunifuElipse Curva_cliente;
        private Bunifu.Framework.UI.BunifuElipse Curva_reservas;
        private Bunifu.Framework.UI.BunifuElipse Curva_quartos;
        private Bunifu.Framework.UI.BunifuElipse Curva_funcionarios;
        private Bunifu.Framework.UI.BunifuElipse Curva_relatorios;
        private System.Windows.Forms.Panel BarraCentral;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton botao_checkin;
        private Bunifu.Framework.UI.BunifuFlatButton botao_checkout;
        private System.Windows.Forms.Panel extensao_clientes;
    }
}