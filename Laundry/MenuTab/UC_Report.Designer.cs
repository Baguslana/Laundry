namespace Laundry.MenuTab
{
    partial class UC_Report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTambah = new Guna.UI.WinForms.GunaAdvenceButton();
            this.dtpSampai = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dtpDari = new Guna.UI.WinForms.GunaDateTimePicker();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.laporan1 = new Laundry.Reporting.Laporan();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTambah);
            this.panel1.Controls.Add(this.dtpSampai);
            this.panel1.Controls.Add(this.gunaLabel2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.dtpDari);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 104);
            this.panel1.TabIndex = 1;
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
            this.btnTambah.CheckedImage = null;
            this.btnTambah.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnTambah.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTambah.FocusedColor = System.Drawing.Color.Empty;
            this.btnTambah.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnTambah.ForeColor = System.Drawing.Color.White;
            this.btnTambah.Image = null;
            this.btnTambah.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTambah.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTambah.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTambah.Location = new System.Drawing.Point(838, 43);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTambah.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTambah.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTambah.OnHoverImage = null;
            this.btnTambah.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnTambah.OnPressedColor = System.Drawing.Color.Black;
            this.btnTambah.Size = new System.Drawing.Size(120, 42);
            this.btnTambah.TabIndex = 24;
            this.btnTambah.Text = "Tampilkan";
            this.btnTambah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnTambah.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // dtpSampai
            // 
            this.dtpSampai.BaseColor = System.Drawing.Color.White;
            this.dtpSampai.BorderColor = System.Drawing.Color.Silver;
            this.dtpSampai.CustomFormat = null;
            this.dtpSampai.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpSampai.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpSampai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpSampai.ForeColor = System.Drawing.Color.Black;
            this.dtpSampai.Location = new System.Drawing.Point(322, 50);
            this.dtpSampai.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpSampai.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpSampai.Name = "dtpSampai";
            this.dtpSampai.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpSampai.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpSampai.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpSampai.OnPressedColor = System.Drawing.Color.Black;
            this.dtpSampai.Size = new System.Drawing.Size(223, 30);
            this.dtpSampai.TabIndex = 3;
            this.dtpSampai.Text = "Senin, 29 Maret 2021";
            this.dtpSampai.Value = new System.DateTime(2021, 3, 29, 21, 17, 30, 915);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel2.Location = new System.Drawing.Point(318, 27);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(25, 20);
            this.gunaLabel2.TabIndex = 2;
            this.gunaLabel2.Text = "To";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel1.Location = new System.Drawing.Point(15, 27);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(43, 20);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "From";
            // 
            // dtpDari
            // 
            this.dtpDari.BaseColor = System.Drawing.Color.White;
            this.dtpDari.BorderColor = System.Drawing.Color.Silver;
            this.dtpDari.CustomFormat = null;
            this.dtpDari.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDari.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDari.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpDari.ForeColor = System.Drawing.Color.Black;
            this.dtpDari.Location = new System.Drawing.Point(19, 50);
            this.dtpDari.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDari.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDari.Name = "dtpDari";
            this.dtpDari.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDari.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDari.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDari.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDari.Size = new System.Drawing.Size(223, 30);
            this.dtpDari.TabIndex = 0;
            this.dtpDari.Text = "Jumat, 26 Maret 2021";
            this.dtpDari.Value = new System.DateTime(2021, 3, 26, 0, 0, 0, 0);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 104);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1022, 569);
            this.crystalReportViewer1.TabIndex = 2;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // UC_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Report";
            this.Size = new System.Drawing.Size(1022, 673);
            this.Load += new System.EventHandler(this.UC_Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Reporting.Laporan laporan1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpSampai;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpDari;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Guna.UI.WinForms.GunaAdvenceButton btnTambah;
    }
}
