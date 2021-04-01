namespace Laundry
{
    partial class FormDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gunaAdvenceButton8 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMember = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnOutlet = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPaket = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPengguna = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnEntriTransaksi = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnDataTransaksi = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnLaporan = new Guna.UI.WinForms.GunaAdvenceButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PanelMenu = new Guna.UI.WinForms.GunaPanel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 673);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.gunaAdvenceButton8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 590);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 83);
            this.panel4.TabIndex = 8;
            // 
            // gunaAdvenceButton8
            // 
            this.gunaAdvenceButton8.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton8.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton8.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton8.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton8.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton8.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton8.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton8.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton8.CheckedImage")));
            this.gunaAdvenceButton8.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton8.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton8.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton8.ForeColor = System.Drawing.Color.White;
             this.gunaAdvenceButton8.Image = null;
            this.gunaAdvenceButton8.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton8.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton8.Location = new System.Drawing.Point(149, 21);
            this.gunaAdvenceButton8.Name = "gunaAdvenceButton8";
            this.gunaAdvenceButton8.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton8.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton8.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton8.OnHoverImage = null;
            this.gunaAdvenceButton8.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton8.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton8.Size = new System.Drawing.Size(85, 50);
            this.gunaAdvenceButton8.TabIndex = 7;
            this.gunaAdvenceButton8.Text = "Exit";
            this.gunaAdvenceButton8.Click += new System.EventHandler(this.gunaAdvenceButton8_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.flowLayoutPanel1.Controls.Add(this.btnMember);
            this.flowLayoutPanel1.Controls.Add(this.btnOutlet);
            this.flowLayoutPanel1.Controls.Add(this.btnPaket);
            this.flowLayoutPanel1.Controls.Add(this.btnPengguna);
            this.flowLayoutPanel1.Controls.Add(this.btnEntriTransaksi);
            this.flowLayoutPanel1.Controls.Add(this.btnDataTransaksi);
            this.flowLayoutPanel1.Controls.Add(this.btnLaporan);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 129);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 544);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // btnMember
            // 
            this.btnMember.AnimationHoverSpeed = 0.07F;
            this.btnMember.AnimationSpeed = 0.03F;
            this.btnMember.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnMember.BorderColor = System.Drawing.Color.Black;
            this.btnMember.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnMember.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnMember.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnMember.CheckedForeColor = System.Drawing.Color.White;
            this.btnMember.CheckedImage = null;
            this.btnMember.CheckedLineColor = System.Drawing.Color.White;
            this.btnMember.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMember.FocusedColor = System.Drawing.Color.Empty;
            this.btnMember.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMember.ForeColor = System.Drawing.Color.White;
            this.btnMember.Image = null;
            this.btnMember.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMember.LineColor = System.Drawing.Color.Transparent;
            this.btnMember.LineLeft = 5;
            this.btnMember.Location = new System.Drawing.Point(3, 3);
            this.btnMember.Name = "btnMember";
            this.btnMember.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMember.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMember.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMember.OnHoverImage = null;
            this.btnMember.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnMember.OnPressedColor = System.Drawing.Color.Black;
            this.btnMember.Size = new System.Drawing.Size(237, 42);
            this.btnMember.TabIndex = 11;
            this.btnMember.Text = "Registrasi";
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnOutlet
            // 
            this.btnOutlet.AnimationHoverSpeed = 0.07F;
            this.btnOutlet.AnimationSpeed = 0.03F;
            this.btnOutlet.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnOutlet.BorderColor = System.Drawing.Color.Black;
            this.btnOutlet.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnOutlet.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnOutlet.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnOutlet.CheckedForeColor = System.Drawing.Color.White;
            this.btnOutlet.CheckedImage = null;
            this.btnOutlet.CheckedLineColor = System.Drawing.Color.White;
            this.btnOutlet.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOutlet.FocusedColor = System.Drawing.Color.Empty;
            this.btnOutlet.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOutlet.ForeColor = System.Drawing.Color.White;
            this.btnOutlet.Image = null;
            this.btnOutlet.ImageSize = new System.Drawing.Size(20, 20);
            this.btnOutlet.LineColor = System.Drawing.Color.Transparent;
            this.btnOutlet.LineLeft = 5;
            this.btnOutlet.Location = new System.Drawing.Point(3, 51);
            this.btnOutlet.Name = "btnOutlet";
            this.btnOutlet.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnOutlet.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOutlet.OnHoverForeColor = System.Drawing.Color.White;
            this.btnOutlet.OnHoverImage = null;
            this.btnOutlet.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnOutlet.OnPressedColor = System.Drawing.Color.Black;
            this.btnOutlet.Size = new System.Drawing.Size(237, 42);
            this.btnOutlet.TabIndex = 12;
            this.btnOutlet.Text = "Outlet";
            this.btnOutlet.Click += new System.EventHandler(this.btnOutlet_Click);
            // 
            // btnPaket
            // 
            this.btnPaket.AnimationHoverSpeed = 0.07F;
            this.btnPaket.AnimationSpeed = 0.03F;
            this.btnPaket.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPaket.BorderColor = System.Drawing.Color.Black;
            this.btnPaket.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnPaket.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPaket.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnPaket.CheckedForeColor = System.Drawing.Color.White;
            this.btnPaket.CheckedImage = null;
            this.btnPaket.CheckedLineColor = System.Drawing.Color.White;
            this.btnPaket.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPaket.FocusedColor = System.Drawing.Color.Empty;
            this.btnPaket.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPaket.ForeColor = System.Drawing.Color.White;
            this.btnPaket.Image = null;
            this.btnPaket.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPaket.LineColor = System.Drawing.Color.Transparent;
            this.btnPaket.LineLeft = 5;
            this.btnPaket.Location = new System.Drawing.Point(3, 99);
            this.btnPaket.Name = "btnPaket";
            this.btnPaket.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPaket.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPaket.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPaket.OnHoverImage = null;
            this.btnPaket.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnPaket.OnPressedColor = System.Drawing.Color.Black;
            this.btnPaket.Size = new System.Drawing.Size(237, 42);
            this.btnPaket.TabIndex = 13;
            this.btnPaket.Text = "Paket";
            this.btnPaket.Click += new System.EventHandler(this.btnPaket_Click);
            // 
            // btnPengguna
            // 
            this.btnPengguna.AnimationHoverSpeed = 0.07F;
            this.btnPengguna.AnimationSpeed = 0.03F;
            this.btnPengguna.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPengguna.BorderColor = System.Drawing.Color.Black;
            this.btnPengguna.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnPengguna.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPengguna.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnPengguna.CheckedForeColor = System.Drawing.Color.White;
            this.btnPengguna.CheckedImage = null;
            this.btnPengguna.CheckedLineColor = System.Drawing.Color.White;
            this.btnPengguna.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPengguna.FocusedColor = System.Drawing.Color.Empty;
            this.btnPengguna.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPengguna.ForeColor = System.Drawing.Color.White;
            this.btnPengguna.Image = null;
            this.btnPengguna.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPengguna.LineColor = System.Drawing.Color.Transparent;
            this.btnPengguna.LineLeft = 5;
            this.btnPengguna.Location = new System.Drawing.Point(3, 147);
            this.btnPengguna.Name = "btnPengguna";
            this.btnPengguna.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPengguna.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPengguna.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPengguna.OnHoverImage = null;
            this.btnPengguna.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnPengguna.OnPressedColor = System.Drawing.Color.Black;
            this.btnPengguna.Size = new System.Drawing.Size(237, 42);
            this.btnPengguna.TabIndex = 9;
            this.btnPengguna.Text = "Pengguna";
            this.btnPengguna.Click += new System.EventHandler(this.btnPengguna_Click);
            // 
            // btnEntriTransaksi
            // 
            this.btnEntriTransaksi.AnimationHoverSpeed = 0.07F;
            this.btnEntriTransaksi.AnimationSpeed = 0.03F;
            this.btnEntriTransaksi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEntriTransaksi.BorderColor = System.Drawing.Color.Black;
            this.btnEntriTransaksi.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnEntriTransaksi.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnEntriTransaksi.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnEntriTransaksi.CheckedForeColor = System.Drawing.Color.White;
            this.btnEntriTransaksi.CheckedImage = null;
            this.btnEntriTransaksi.CheckedLineColor = System.Drawing.Color.White;
            this.btnEntriTransaksi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEntriTransaksi.FocusedColor = System.Drawing.Color.Empty;
            this.btnEntriTransaksi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEntriTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnEntriTransaksi.Image = null;
            this.btnEntriTransaksi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEntriTransaksi.LineColor = System.Drawing.Color.Transparent;
            this.btnEntriTransaksi.LineLeft = 5;
            this.btnEntriTransaksi.Location = new System.Drawing.Point(3, 195);
            this.btnEntriTransaksi.Name = "btnEntriTransaksi";
            this.btnEntriTransaksi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEntriTransaksi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEntriTransaksi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEntriTransaksi.OnHoverImage = null;
            this.btnEntriTransaksi.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnEntriTransaksi.OnPressedColor = System.Drawing.Color.Black;
            this.btnEntriTransaksi.Size = new System.Drawing.Size(237, 42);
            this.btnEntriTransaksi.TabIndex = 10;
            this.btnEntriTransaksi.Text = "Entri Transaksi";
            this.btnEntriTransaksi.Click += new System.EventHandler(this.btnEntriTransaksi_Click);
            // 
            // btnDataTransaksi
            // 
            this.btnDataTransaksi.AnimationHoverSpeed = 0.07F;
            this.btnDataTransaksi.AnimationSpeed = 0.03F;
            this.btnDataTransaksi.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnDataTransaksi.BorderColor = System.Drawing.Color.Black;
            this.btnDataTransaksi.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnDataTransaksi.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnDataTransaksi.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnDataTransaksi.CheckedForeColor = System.Drawing.Color.White;
            this.btnDataTransaksi.CheckedImage = null;
            this.btnDataTransaksi.CheckedLineColor = System.Drawing.Color.White;
            this.btnDataTransaksi.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDataTransaksi.FocusedColor = System.Drawing.Color.Empty;
            this.btnDataTransaksi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDataTransaksi.ForeColor = System.Drawing.Color.White;
            this.btnDataTransaksi.Image = null;
            this.btnDataTransaksi.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDataTransaksi.LineColor = System.Drawing.Color.Transparent;
            this.btnDataTransaksi.LineLeft = 5;
            this.btnDataTransaksi.Location = new System.Drawing.Point(3, 243);
            this.btnDataTransaksi.Name = "btnDataTransaksi";
            this.btnDataTransaksi.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnDataTransaksi.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDataTransaksi.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDataTransaksi.OnHoverImage = null;
            this.btnDataTransaksi.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnDataTransaksi.OnPressedColor = System.Drawing.Color.Black;
            this.btnDataTransaksi.Size = new System.Drawing.Size(237, 42);
            this.btnDataTransaksi.TabIndex = 16;
            this.btnDataTransaksi.Text = "Data Transaksi";
            this.btnDataTransaksi.Click += new System.EventHandler(this.btnDataTransaksi_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.AnimationHoverSpeed = 0.07F;
            this.btnLaporan.AnimationSpeed = 0.03F;
            this.btnLaporan.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLaporan.BorderColor = System.Drawing.Color.Black;
            this.btnLaporan.ButtonType = Guna.UI.WinForms.AdvenceButtonType.RadioButton;
            this.btnLaporan.CheckedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnLaporan.CheckedBorderColor = System.Drawing.Color.Transparent;
            this.btnLaporan.CheckedForeColor = System.Drawing.Color.White;
            this.btnLaporan.CheckedImage = null;
            this.btnLaporan.CheckedLineColor = System.Drawing.Color.White;
            this.btnLaporan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLaporan.FocusedColor = System.Drawing.Color.Empty;
            this.btnLaporan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLaporan.ForeColor = System.Drawing.Color.White;
            this.btnLaporan.Image = null;
            this.btnLaporan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLaporan.LineColor = System.Drawing.Color.Transparent;
            this.btnLaporan.LineLeft = 5;
            this.btnLaporan.Location = new System.Drawing.Point(3, 291);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLaporan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLaporan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLaporan.OnHoverImage = null;
            this.btnLaporan.OnHoverLineColor = System.Drawing.Color.Transparent;
            this.btnLaporan.OnPressedColor = System.Drawing.Color.Black;
            this.btnLaporan.Size = new System.Drawing.Size(237, 42);
            this.btnLaporan.TabIndex = 15;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(98, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laundry";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaPictureBox1.Image")));
            this.gunaPictureBox1.Location = new System.Drawing.Point(12, 12);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(80, 80);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 0;
            this.gunaPictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 129);
            this.panel3.TabIndex = 8;
            // 
            // PanelMenu
            // 
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMenu.Location = new System.Drawing.Point(240, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(1022, 673);
            this.PanelMenu.TabIndex = 1;
            // 
            // FormDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main menu";
            this.Load += new System.EventHandler(this.FormDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton8;
        private Guna.UI.WinForms.GunaAdvenceButton btnPengguna;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private Guna.UI.WinForms.GunaPanel PanelMenu;
        private Guna.UI.WinForms.GunaAdvenceButton btnMember;
        private Guna.UI.WinForms.GunaAdvenceButton btnOutlet;
        private Guna.UI.WinForms.GunaAdvenceButton btnPaket;
        private Guna.UI.WinForms.GunaAdvenceButton btnEntriTransaksi;
        private Guna.UI.WinForms.GunaAdvenceButton btnLaporan;
        private Guna.UI.WinForms.GunaAdvenceButton btnDataTransaksi;
    }
}

