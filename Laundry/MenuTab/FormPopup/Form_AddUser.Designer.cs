namespace Laundry.MenuTab
{
    partial class Form_AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddUser));
            this.panelsamping = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelantaratxt = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRole = new Guna.UI.WinForms.GunaComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.paneltxt = new System.Windows.Forms.Panel();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbOutlet = new Guna.UI.WinForms.GunaComboBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btnTambah = new Guna.UI.WinForms.GunaAdvenceButton();
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
            this.label1.Location = new System.Drawing.Point(34, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nama";
            // 
            // panelantaratxt
            // 
            this.panelantaratxt.Location = new System.Drawing.Point(31, 344);
            this.panelantaratxt.Name = "panelantaratxt";
            this.panelantaratxt.Size = new System.Drawing.Size(68, 10);
            this.panelantaratxt.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Password";
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.Transparent;
            this.cmbRole.BaseColor = System.Drawing.Color.White;
            this.cmbRole.BorderColor = System.Drawing.Color.Silver;
            this.cmbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRole.ForeColor = System.Drawing.Color.Black;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Location = new System.Drawing.Point(31, 307);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbRole.Size = new System.Drawing.Size(220, 31);
            this.cmbRole.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Role";
            // 
            // paneltxt
            // 
            this.paneltxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paneltxt.Location = new System.Drawing.Point(31, 141);
            this.paneltxt.Name = "paneltxt";
            this.paneltxt.Size = new System.Drawing.Size(348, 1);
            this.paneltxt.TabIndex = 13;
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNama.Location = new System.Drawing.Point(31, 120);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(348, 15);
            this.txtNama.TabIndex = 14;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Location = new System.Drawing.Point(31, 185);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(348, 15);
            this.txtUsername.TabIndex = 15;
            this.txtUsername.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsername_KeyPress);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Location = new System.Drawing.Point(31, 246);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(348, 15);
            this.txtPassword.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(31, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 1);
            this.panel2.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(31, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 1);
            this.panel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 357);
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
            this.cmbOutlet.Location = new System.Drawing.Point(31, 377);
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
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(0, 0);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(410, 73);
            this.gunaButton1.TabIndex = 19;
            this.gunaButton1.Text = "Tambah User";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTambah
            // 
            this.btnTambah.AnimationHoverSpeed = 0.07F;
            this.btnTambah.AnimationSpeed = 0.03F;
            this.btnTambah.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTambah.BorderColor = System.Drawing.Color.Black;
            this.btnTambah.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnTambah.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnTambah.CheckedForeColor = System.Drawing.Color.White;
            this.btnTambah.CheckedImage = ((System.Drawing.Image)(resources.GetObject("btnTambah.CheckedImage")));
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
            this.btnTambah.Size = new System.Drawing.Size(120, 42);
            this.btnTambah.TabIndex = 20;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // Form_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 530);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.cmbOutlet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.paneltxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelantaratxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelsamping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_AddUser";
            this.Load += new System.EventHandler(this.Form_AddUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelsamping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelantaratxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaComboBox cmbRole;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel paneltxt;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaComboBox cmbOutlet;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaAdvenceButton btnTambah;
    }
}