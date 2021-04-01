namespace Laundry.MenuTab.FormPopup
{
    partial class Form_AddJenis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_AddJenis));
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.btnTambah = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtJenisPaket = new System.Windows.Forms.TextBox();
            this.paneltxt = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
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
            this.gunaButton1.Text = "Tambah Jenis Paket";
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
            this.btnTambah.Location = new System.Drawing.Point(278, 196);
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
            // txtJenisPaket
            // 
            this.txtJenisPaket.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJenisPaket.Location = new System.Drawing.Point(12, 124);
            this.txtJenisPaket.Name = "txtJenisPaket";
            this.txtJenisPaket.Size = new System.Drawing.Size(348, 15);
            this.txtJenisPaket.TabIndex = 32;
            // 
            // paneltxt
            // 
            this.paneltxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.paneltxt.Location = new System.Drawing.Point(12, 145);
            this.paneltxt.Name = "paneltxt";
            this.paneltxt.Size = new System.Drawing.Size(348, 1);
            this.paneltxt.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Nama";
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
            this.btnBack.TabIndex = 42;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form_AddJenis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 250);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtJenisPaket);
            this.Controls.Add(this.paneltxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.gunaButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_AddJenis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_AddUser";
            this.Load += new System.EventHandler(this.Form_AddJenis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaAdvenceButton btnTambah;
        private System.Windows.Forms.TextBox txtJenisPaket;
        private System.Windows.Forms.Panel paneltxt;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnBack;
    }
}
