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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Transaksi));
            this.dataTbTransaksi = new Guna.UI.WinForms.GunaDataGridView();
            this.ColumnInvoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTanggalEntri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatusCucian = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnStatusPembayaran = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnDetail = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cmbOutlet = new Guna.UI.WinForms.GunaComboBox();
            this.gunaAdvenceButton1 = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTbTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataTbTransaksi
            // 
            this.dataTbTransaksi.AllowUserToAddRows = false;
            this.dataTbTransaksi.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dataTbTransaksi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataTbTransaksi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTbTransaksi.BackgroundColor = System.Drawing.Color.White;
            this.dataTbTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTbTransaksi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTbTransaksi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTbTransaksi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataTbTransaksi.ColumnHeadersHeight = 27;
            this.dataTbTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTbTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnInvoice,
            this.ColumnPelanggan,
            this.ColumnTanggalEntri,
            this.ColumnStatusCucian,
            this.ColumnStatusPembayaran,
            this.ColumnDetail});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTbTransaksi.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataTbTransaksi.EnableHeadersVisualStyles = false;
            this.dataTbTransaksi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbTransaksi.Location = new System.Drawing.Point(19, 113);
            this.dataTbTransaksi.Name = "dataTbTransaksi";
            this.dataTbTransaksi.RowHeadersVisible = false;
            this.dataTbTransaksi.RowHeadersWidth = 51;
            this.dataTbTransaksi.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataTbTransaksi.RowTemplate.Height = 24;
            this.dataTbTransaksi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTbTransaksi.Size = new System.Drawing.Size(984, 539);
            this.dataTbTransaksi.TabIndex = 4;
            this.dataTbTransaksi.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dataTbTransaksi.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTbTransaksi.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataTbTransaksi.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataTbTransaksi.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataTbTransaksi.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataTbTransaksi.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataTbTransaksi.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbTransaksi.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataTbTransaksi.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataTbTransaksi.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTbTransaksi.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataTbTransaksi.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTbTransaksi.ThemeStyle.HeaderStyle.Height = 27;
            this.dataTbTransaksi.ThemeStyle.ReadOnly = false;
            this.dataTbTransaksi.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataTbTransaksi.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTbTransaksi.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dataTbTransaksi.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTbTransaksi.ThemeStyle.RowsStyle.Height = 24;
            this.dataTbTransaksi.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataTbTransaksi.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataTbTransaksi.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTbMember_CellEndEdit);
            // 
            // ColumnInvoice
            // 
            this.ColumnInvoice.DataPropertyName = "kode_invoice";
            this.ColumnInvoice.HeaderText = "Kode Invoice";
            this.ColumnInvoice.MinimumWidth = 6;
            this.ColumnInvoice.Name = "ColumnInvoice";
            // 
            // ColumnPelanggan
            // 
            this.ColumnPelanggan.DataPropertyName = "nama";
            this.ColumnPelanggan.HeaderText = "Pelanggan";
            this.ColumnPelanggan.MinimumWidth = 6;
            this.ColumnPelanggan.Name = "ColumnPelanggan";
            // 
            // ColumnTanggalEntri
            // 
            this.ColumnTanggalEntri.DataPropertyName = "tgl";
            this.ColumnTanggalEntri.HeaderText = "Tanggal Entri";
            this.ColumnTanggalEntri.MinimumWidth = 6;
            this.ColumnTanggalEntri.Name = "ColumnTanggalEntri";
            // 
            // ColumnStatusCucian
            // 
            this.ColumnStatusCucian.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnStatusCucian.HeaderText = "Status Cucian";
            this.ColumnStatusCucian.MinimumWidth = 6;
            this.ColumnStatusCucian.Name = "ColumnStatusCucian";
            this.ColumnStatusCucian.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnStatusCucian.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnStatusPembayaran
            // 
            this.ColumnStatusPembayaran.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnStatusPembayaran.HeaderText = "Status Bayar";
            this.ColumnStatusPembayaran.MinimumWidth = 6;
            this.ColumnStatusPembayaran.Name = "ColumnStatusPembayaran";
            this.ColumnStatusPembayaran.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnStatusPembayaran.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ColumnDetail
            // 
            this.ColumnDetail.ActiveLinkColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColumnDetail.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColumnDetail.HeaderText = "Detail";
            this.ColumnDetail.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.ColumnDetail.LinkColor = System.Drawing.Color.Blue;
            this.ColumnDetail.MinimumWidth = 6;
            this.ColumnDetail.Name = "ColumnDetail";
            this.ColumnDetail.Text = "Lihat";
            this.ColumnDetail.UseColumnTextForLinkValue = true;
            this.ColumnDetail.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaLabel3.Location = new System.Drawing.Point(15, 44);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(50, 20);
            this.gunaLabel3.TabIndex = 28;
            this.gunaLabel3.Text = "Outlet";
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
            this.cmbOutlet.Location = new System.Drawing.Point(19, 67);
            this.cmbOutlet.Name = "cmbOutlet";
            this.cmbOutlet.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbOutlet.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbOutlet.Size = new System.Drawing.Size(170, 31);
            this.cmbOutlet.TabIndex = 27;
            this.cmbOutlet.SelectedIndexChanged += new System.EventHandler(this.cmbOutlet_SelectedIndexChanged);
            // 
            // gunaAdvenceButton1
            // 
            this.gunaAdvenceButton1.AnimationHoverSpeed = 0.07F;
            this.gunaAdvenceButton1.AnimationSpeed = 0.03F;
            this.gunaAdvenceButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaAdvenceButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray;
            this.gunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.CheckedImage = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.CheckedImage")));
            this.gunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.DimGray;
            this.gunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaAdvenceButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaAdvenceButton1.ForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaAdvenceButton1.Image")));
            this.gunaAdvenceButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaAdvenceButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaAdvenceButton1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.Location = new System.Drawing.Point(964, 62);
            this.gunaAdvenceButton1.Name = "gunaAdvenceButton1";
            this.gunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaAdvenceButton1.OnHoverImage = null;
            this.gunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.gunaAdvenceButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaAdvenceButton1.Radius = 5;
            this.gunaAdvenceButton1.Size = new System.Drawing.Size(33, 30);
            this.gunaAdvenceButton1.TabIndex = 30;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.Color.Black;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.ForeColor = System.Drawing.Color.Gray;
            this.txtSearch.Location = new System.Drawing.Point(757, 56);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 7;
            this.txtSearch.Size = new System.Drawing.Size(246, 42);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.Text = "Search . . .";
            // 
            // UC_Transaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaAdvenceButton1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.cmbOutlet);
            this.Controls.Add(this.dataTbTransaksi);
            this.Name = "UC_Transaksi";
            this.Size = new System.Drawing.Size(1022, 673);
            this.Load += new System.EventHandler(this.UC_Transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataTbTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dataTbTransaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTanggalEntri;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnStatusCucian;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnStatusPembayaran;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnDetail;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaComboBox cmbOutlet;
        private Guna.UI.WinForms.GunaAdvenceButton gunaAdvenceButton1;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
    }
}
