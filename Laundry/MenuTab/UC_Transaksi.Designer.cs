namespace Laundry.MenuTab
{
    partial class UC_Transaksi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataTbMember = new Guna.UI.WinForms.GunaDataGridView();
            this.ColumnInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTanggalEntri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatusCucian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatusPembayaran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataTbMember)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(990, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(29, 100);
            this.panel1.TabIndex = 3;
            // 
            // dataTbMember
            // 
            this.dataTbMember.AllowUserToAddRows = false;
            this.dataTbMember.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataTbMember.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTbMember.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTbMember.BackgroundColor = System.Drawing.Color.White;
            this.dataTbMember.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTbMember.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTbMember.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTbMember.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTbMember.ColumnHeadersHeight = 27;
            this.dataTbMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTbMember.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnInvoice,
            this.ColumnPelanggan,
            this.ColumnTanggalEntri,
            this.ColumnStatusCucian,
            this.ColumnStatusPembayaran});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTbMember.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataTbMember.EnableHeadersVisualStyles = false;
            this.dataTbMember.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbMember.Location = new System.Drawing.Point(38, 58);
            this.dataTbMember.Name = "dataTbMember";
            this.dataTbMember.ReadOnly = true;
            this.dataTbMember.RowHeadersVisible = false;
            this.dataTbMember.RowHeadersWidth = 51;
            this.dataTbMember.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataTbMember.RowTemplate.Height = 24;
            this.dataTbMember.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTbMember.Size = new System.Drawing.Size(946, 577);
            this.dataTbMember.TabIndex = 4;
            this.dataTbMember.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataTbMember.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTbMember.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTbMember.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTbMember.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataTbMember.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTbMember.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataTbMember.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbMember.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataTbMember.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataTbMember.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTbMember.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTbMember.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTbMember.ThemeStyle.HeaderStyle.Height = 27;
            this.dataTbMember.ThemeStyle.ReadOnly = true;
            this.dataTbMember.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTbMember.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTbMember.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTbMember.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTbMember.ThemeStyle.RowsStyle.Height = 24;
            this.dataTbMember.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbMember.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ColumnInvoice
            // 
            this.ColumnInvoice.DataPropertyName = "kode_invoice";
            this.ColumnInvoice.HeaderText = "Kode Invoice";
            this.ColumnInvoice.MinimumWidth = 6;
            this.ColumnInvoice.Name = "ColumnInvoice";
            this.ColumnInvoice.ReadOnly = true;
            // 
            // ColumnPelanggan
            // 
            this.ColumnPelanggan.DataPropertyName = "nama";
            this.ColumnPelanggan.HeaderText = "Pelanggan";
            this.ColumnPelanggan.MinimumWidth = 6;
            this.ColumnPelanggan.Name = "ColumnPelanggan";
            this.ColumnPelanggan.ReadOnly = true;
            // 
            // ColumnTanggalEntri
            // 
            this.ColumnTanggalEntri.DataPropertyName = "tgl";
            this.ColumnTanggalEntri.HeaderText = "Tanggal Entri";
            this.ColumnTanggalEntri.MinimumWidth = 6;
            this.ColumnTanggalEntri.Name = "ColumnTanggalEntri";
            this.ColumnTanggalEntri.ReadOnly = true;
            // 
            // ColumnStatusCucian
            // 
            this.ColumnStatusCucian.DataPropertyName = "status";
            this.ColumnStatusCucian.HeaderText = "Status Cucian";
            this.ColumnStatusCucian.MinimumWidth = 6;
            this.ColumnStatusCucian.Name = "ColumnStatusCucian";
            this.ColumnStatusCucian.ReadOnly = true;
            // 
            // ColumnStatusPembayaran
            // 
            this.ColumnStatusPembayaran.DataPropertyName = "dibayar";
            this.ColumnStatusPembayaran.HeaderText = "Status Pembayaran";
            this.ColumnStatusPembayaran.MinimumWidth = 6;
            this.ColumnStatusPembayaran.Name = "ColumnStatusPembayaran";
            this.ColumnStatusPembayaran.ReadOnly = true;
            // 
            // UC_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataTbMember);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Transaksi";
            this.Size = new System.Drawing.Size(1022, 673);
            this.Load += new System.EventHandler(this.UC_Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTbMember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDataGridView dataTbMember;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTanggalEntri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatusCucian;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatusPembayaran;
    }
}
