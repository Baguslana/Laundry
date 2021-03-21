﻿namespace Laundry.MenuTab.FormPopup
{
    partial class Form_Pelanggan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelsamping = new System.Windows.Forms.Panel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.dataTbPelanggan = new Guna.UI.WinForms.GunaDataGridView();
            this.btnRefresh = new Guna.UI.WinForms.GunaAdvenceButton();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPilih = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtCariPelanggan = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTbPelanggan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelsamping
            // 
            this.panelsamping.Location = new System.Drawing.Point(12, 300);
            this.panelsamping.Name = "panelsamping";
            this.panelsamping.Size = new System.Drawing.Size(13, 100);
            this.panelsamping.TabIndex = 1;
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
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(410, 73);
            this.gunaButton1.TabIndex = 19;
            this.gunaButton1.Text = "Tabel Pelanggan";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataTbPelanggan
            // 
            this.dataTbPelanggan.AllowUserToAddRows = false;
            this.dataTbPelanggan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataTbPelanggan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataTbPelanggan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTbPelanggan.BackgroundColor = System.Drawing.Color.White;
            this.dataTbPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTbPelanggan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTbPelanggan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTbPelanggan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataTbPelanggan.ColumnHeadersHeight = 27;
            this.dataTbPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTbPelanggan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnPelanggan});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTbPelanggan.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataTbPelanggan.EnableHeadersVisualStyles = false;
            this.dataTbPelanggan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbPelanggan.Location = new System.Drawing.Point(31, 152);
            this.dataTbPelanggan.Name = "dataTbPelanggan";
            this.dataTbPelanggan.ReadOnly = true;
            this.dataTbPelanggan.RowHeadersVisible = false;
            this.dataTbPelanggan.RowHeadersWidth = 51;
            this.dataTbPelanggan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataTbPelanggan.RowTemplate.Height = 24;
            this.dataTbPelanggan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTbPelanggan.Size = new System.Drawing.Size(348, 314);
            this.dataTbPelanggan.TabIndex = 21;
            this.dataTbPelanggan.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataTbPelanggan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTbPelanggan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTbPelanggan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTbPelanggan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataTbPelanggan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTbPelanggan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataTbPelanggan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbPelanggan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataTbPelanggan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataTbPelanggan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTbPelanggan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTbPelanggan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTbPelanggan.ThemeStyle.HeaderStyle.Height = 27;
            this.dataTbPelanggan.ThemeStyle.ReadOnly = true;
            this.dataTbPelanggan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTbPelanggan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTbPelanggan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTbPelanggan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTbPelanggan.ThemeStyle.RowsStyle.Height = 24;
            this.dataTbPelanggan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbPelanggan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTbPelanggan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTbPelanggan_CellClick);
            this.dataTbPelanggan.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTbPelanggan_CellDoubleClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.AnimationHoverSpeed = 0.07F;
            this.btnRefresh.AnimationSpeed = 0.03F;
            this.btnRefresh.BaseColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.BorderColor = System.Drawing.Color.Black;
            this.btnRefresh.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnRefresh.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.CheckedForeColor = System.Drawing.Color.White;
            this.btnRefresh.CheckedImage = null;
            this.btnRefresh.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRefresh.FocusedColor = System.Drawing.Color.Empty;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = null;
            this.btnRefresh.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRefresh.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRefresh.Location = new System.Drawing.Point(12, 472);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnRefresh.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRefresh.OnHoverForeColor = System.Drawing.Color.White;
            this.btnRefresh.OnHoverImage = null;
            this.btnRefresh.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnRefresh.OnPressedColor = System.Drawing.Color.Black;
            this.btnRefresh.Size = new System.Drawing.Size(121, 42);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Visible = false;
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "id";
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.MinimumWidth = 6;
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnPelanggan
            // 
            this.ColumnPelanggan.DataPropertyName = "nama";
            this.ColumnPelanggan.HeaderText = "Nama Pelanggan";
            this.ColumnPelanggan.MinimumWidth = 6;
            this.ColumnPelanggan.Name = "ColumnPelanggan";
            this.ColumnPelanggan.ReadOnly = true;
            // 
            // btnPilih
            // 
            this.btnPilih.AnimationHoverSpeed = 0.07F;
            this.btnPilih.AnimationSpeed = 0.03F;
            this.btnPilih.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnPilih.BorderColor = System.Drawing.Color.Black;
            this.btnPilih.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnPilih.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnPilih.CheckedForeColor = System.Drawing.Color.White;
            this.btnPilih.CheckedImage = null;
            this.btnPilih.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnPilih.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPilih.FocusedColor = System.Drawing.Color.Empty;
            this.btnPilih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPilih.ForeColor = System.Drawing.Color.White;
            this.btnPilih.Image = null;
            this.btnPilih.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPilih.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPilih.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPilih.Location = new System.Drawing.Point(259, 472);
            this.btnPilih.Name = "btnPilih";
            this.btnPilih.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnPilih.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPilih.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPilih.OnHoverImage = null;
            this.btnPilih.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnPilih.OnPressedColor = System.Drawing.Color.Black;
            this.btnPilih.Size = new System.Drawing.Size(120, 42);
            this.btnPilih.TabIndex = 37;
            this.btnPilih.Text = "Pilih";
            this.btnPilih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPilih.Visible = false;
            this.btnPilih.Click += new System.EventHandler(this.btnPilih_Click);
            // 
            // txtCariPelanggan
            // 
            this.txtCariPelanggan.BackColor = System.Drawing.Color.White;
            this.txtCariPelanggan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCariPelanggan.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCariPelanggan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCariPelanggan.LineColor = System.Drawing.Color.Gainsboro;
            this.txtCariPelanggan.Location = new System.Drawing.Point(31, 106);
            this.txtCariPelanggan.Name = "txtCariPelanggan";
            this.txtCariPelanggan.PasswordChar = '\0';
            this.txtCariPelanggan.Size = new System.Drawing.Size(348, 30);
            this.txtCariPelanggan.TabIndex = 38;
            this.txtCariPelanggan.TextChanged += new System.EventHandler(this.txtCariPelanggan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Cari";
            // 
            // Form_Pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 530);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCariPelanggan);
            this.Controls.Add(this.btnPilih);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dataTbPelanggan);
            this.Controls.Add(this.gunaButton1);
            this.Controls.Add(this.panelsamping);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Pelanggan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_AddUser";
            this.Load += new System.EventHandler(this.Form_Pelanggan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTbPelanggan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelsamping;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaDataGridView dataTbPelanggan;
        private Guna.UI.WinForms.GunaAdvenceButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPelanggan;
        private Guna.UI.WinForms.GunaAdvenceButton btnPilih;
        private Guna.UI.WinForms.GunaLineTextBox txtCariPelanggan;
        private System.Windows.Forms.Label label1;
    }
}
