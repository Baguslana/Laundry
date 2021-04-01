namespace Laundry.MenuTab.FormPopup
{
    partial class Form_AddPaket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddPaket));
            this.panelsamping = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelantaratxt = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbJenisPaket = new Guna.UI.WinForms.GunaComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paneltxt = new System.Windows.Forms.Panel();
            this.txtNamaPaket = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOutlet = new Guna.UI.WinForms.GunaComboBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btnTambah = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnIcon = new Guna.UI.WinForms.GunaButton();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.picIcon = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsamping
            // 
            this.panelsamping.Location = new System.Drawing.Point(385, 112);
            this.panelsamping.Name = "panelsamping";
            this.panelsamping.Size = new System.Drawing.Size(13, 100);
            this.panelsamping.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama Paket";
            // 
            // panelantaratxt
            // 
            this.panelantaratxt.Location = new System.Drawing.Point(60, 280);
            this.panelantaratxt.Name = "panelantaratxt";
            this.panelantaratxt.Size = new System.Drawing.Size(68, 10);
            this.panelantaratxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Harga";
            // 
            // cmbJenisPaket
            // 
            this.cmbJenisPaket.BackColor = System.Drawing.Color.Transparent;
            this.cmbJenisPaket.BaseColor = System.Drawing.Color.White;
            this.cmbJenisPaket.BorderColor = System.Drawing.Color.Silver;
            this.cmbJenisPaket.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbJenisPaket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJenisPaket.FocusedColor = System.Drawing.Color.Empty;
            this.cmbJenisPaket.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbJenisPaket.ForeColor = System.Drawing.Color.Black;
            this.cmbJenisPaket.FormattingEnabled = true;
            this.cmbJenisPaket.Location = new System.Drawing.Point(31, 182);
            this.cmbJenisPaket.Name = "cmbJenisPaket";
            this.cmbJenisPaket.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbJenisPaket.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbJenisPaket.Size = new System.Drawing.Size(220, 31);
            this.cmbJenisPaket.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Jenis Paket";
            // 
            // paneltxt
            // 
            this.paneltxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paneltxt.Location = new System.Drawing.Point(31, 273);
            this.paneltxt.Name = "paneltxt";
            this.paneltxt.Size = new System.Drawing.Size(348, 1);
            this.paneltxt.TabIndex = 13;
            // 
            // txtNamaPaket
            // 
            this.txtNamaPaket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamaPaket.Location = new System.Drawing.Point(31, 252);
            this.txtNamaPaket.Name = "txtNamaPaket";
            this.txtNamaPaket.Size = new System.Drawing.Size(348, 15);
            this.txtNamaPaket.TabIndex = 14;
            // 
            // txtHarga
            // 
            this.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHarga.Location = new System.Drawing.Point(31, 317);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(348, 15);
            this.txtHarga.TabIndex = 15;
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarga_KeyPress);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(31, 338);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 1);
            this.panel2.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Outlet";
            // 
            // cmbOutlet
            // 
            this.cmbOutlet.BackColor = System.Drawing.Color.Transparent;
            this.cmbOutlet.BaseColor = System.Drawing.Color.White;
            this.cmbOutlet.BorderColor = System.Drawing.Color.Silver;
            this.cmbOutlet.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbOutlet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOutlet.FocusedColor = System.Drawing.Color.Empty;
            this.cmbOutlet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbOutlet.ForeColor = System.Drawing.Color.Black;
            this.cmbOutlet.FormattingEnabled = true;
            this.cmbOutlet.Location = new System.Drawing.Point(31, 112);
            this.cmbOutlet.Name = "cmbOutlet";
            this.cmbOutlet.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbOutlet.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbOutlet.Size = new System.Drawing.Size(220, 31);
            this.cmbOutlet.TabIndex = 18;
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(0, 0);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(410, 73);
            this.gunaButton1.TabIndex = 19;
            this.gunaButton1.Text = "Tambah Paket";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTambah
            // 
            this.btnTambah.AnimationHoverSpeed = 0.07F;
            this.btnTambah.AnimationSpeed = 0.03F;
            this.btnTambah.BackColor = System.Drawing.Color.Transparent;
            this.btnTambah.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTambah.BorderColor = System.Drawing.Color.Black;
            this.btnTambah.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnTambah.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTambah.CheckedForeColor = System.Drawing.Color.White;
            this.btnTambah.CheckedImage = null;
            this.btnTambah.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTambah.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTambah.FocusedColor = System.Drawing.Color.Empty;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Image = ((System.Drawing.Image)(resources.GetObject("btnTambah.Image")));
            this.btnTambah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTambah.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTambah.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTambah.Location = new System.Drawing.Point(259, 451);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTambah.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTambah.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTambah.OnHoverImage = null;
            this.btnTambah.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTambah.OnPressedColor = System.Drawing.Color.Black;
            this.btnTambah.Radius = 5;
            this.btnTambah.Size = new System.Drawing.Size(120, 42);
            this.btnTambah.TabIndex = 20;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnIcon
            // 
            this.btnIcon.AnimationHoverSpeed = 0.07F;
            this.btnIcon.AnimationSpeed = 0.03F;
            this.btnIcon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnIcon.BorderColor = System.Drawing.Color.Black;
            this.btnIcon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIcon.FocusedColor = System.Drawing.Color.Empty;
            this.btnIcon.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnIcon.ForeColor = System.Drawing.Color.White;
            this.btnIcon.Image = null;
            this.btnIcon.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIcon.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIcon.Location = new System.Drawing.Point(37, 356);
            this.btnIcon.Name = "btnIcon";
            this.btnIcon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnIcon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIcon.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIcon.OnHoverImage = null;
            this.btnIcon.OnPressedColor = System.Drawing.Color.Black;
            this.btnIcon.Size = new System.Drawing.Size(50, 50);
            this.btnIcon.TabIndex = 21;
            this.btnIcon.Text = "Select";
            this.btnIcon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIcon.Click += new System.EventHandler(this.btnIcon_Click);
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnBack.BorderColor = System.Drawing.Color.Black;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.Location = new System.Drawing.Point(0, 0);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(40, 40);
            this.btnBack.TabIndex = 23;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picIcon
            // 
            this.picIcon.BaseColor = System.Drawing.Color.White;
            this.picIcon.Location = new System.Drawing.Point(107, 356);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(50, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 22;
            this.picIcon.TabStop = false;
            // 
            // Form_AddPaket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 530);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.btnIcon);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.cmbOutlet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtHarga);
            this.Controls.Add(this.txtNamaPaket);
            this.Controls.Add(this.paneltxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbJenisPaket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelantaratxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelsamping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddPaket";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_AddUser";
            this.Load += new System.EventHandler(this.Form_AddPaket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelsamping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelantaratxt;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox cmbJenisPaket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel paneltxt;
        private System.Windows.Forms.TextBox txtNamaPaket;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaComboBox cmbOutlet;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaAdvenceButton btnTambah;
        private Guna.UI.WinForms.GunaButton btnIcon;
        private Guna.UI.WinForms.GunaPictureBox picIcon;
        private Guna.UI.WinForms.GunaButton btnBack;
    }
}
      