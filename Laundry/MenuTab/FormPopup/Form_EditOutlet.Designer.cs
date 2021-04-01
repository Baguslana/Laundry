namespace Laundry.MenuTab.FormPopup
{
    partial class Form_EditOutlet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_EditOutlet));
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtNoTelepon = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.paneltxt = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelantaratxt = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelsamping = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.Gold;
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
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.Gold;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(410, 73);
            this.gunaButton1.TabIndex = 36;
            this.gunaButton1.Text = "Edit Outlet";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Location = new System.Drawing.Point(31, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 1);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(31, 206);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 1);
            this.panel2.TabIndex = 30;
            // 
            // txtNoTelepon
            // 
            this.txtNoTelepon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNoTelepon.Location = new System.Drawing.Point(31, 246);
            this.txtNoTelepon.Name = "txtNoTelepon";
            this.txtNoTelepon.Size = new System.Drawing.Size(348, 15);
            this.txtNoTelepon.TabIndex = 33;
            this.txtNoTelepon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNoTelepon_KeyPress);
            // 
            // txtAlamat
            // 
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAlamat.Location = new System.Drawing.Point(31, 185);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(348, 15);
            this.txtAlamat.TabIndex = 32;
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNama.Location = new System.Drawing.Point(31, 120);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(348, 15);
            this.txtNama.TabIndex = 29;
            // 
            // paneltxt
            // 
            this.paneltxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paneltxt.Location = new System.Drawing.Point(31, 141);
            this.paneltxt.Name = "paneltxt";
            this.paneltxt.Size = new System.Drawing.Size(348, 1);
            this.paneltxt.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Alamat";
            // 
            // panelantaratxt
            // 
            this.panelantaratxt.Location = new System.Drawing.Point(48, 213);
            this.panelantaratxt.Name = "panelantaratxt";
            this.panelantaratxt.Size = new System.Drawing.Size(68, 10);
            this.panelantaratxt.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Nama";
            // 
            // panelsamping
            // 
            this.panelsamping.Location = new System.Drawing.Point(385, 112);
            this.panelsamping.Name = "panelsamping";
            this.panelsamping.Size = new System.Drawing.Size(13, 100);
            this.panelsamping.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "No Telepon";
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor = System.Drawing.Color.Gold;
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnEdit.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnEdit.CheckedForeColor = System.Drawing.Color.White;
            this.btnEdit.CheckedImage = null;
            this.btnEdit.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEdit.Location = new System.Drawing.Point(259, 451);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 5;
            this.btnEdit.Size = new System.Drawing.Size(120, 42);
            this.btnEdit.TabIndex = 37;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BaseColor = System.Drawing.Color.Gold;
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
            this.btnBack.TabIndex = 39;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form_EditOutlet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 530);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNoTelepon);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.paneltxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelantaratxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelsamping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_EditOutlet";
            this.Text = "Form_EditUser";
            this.Load += new System.EventHandler(this.Form_EditOutlet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtNoTelepon;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Panel paneltxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelantaratxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelsamping;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaAdvenceButton btnEdit;
        private Guna.UI.WinForms.GunaButton btnBack;
    }
}