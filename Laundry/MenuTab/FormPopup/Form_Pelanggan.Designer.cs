namespace Laundry.MenuTab.FormPopup
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Pelanggan));
            this.panelsamping = new System.Windows.Forms.Panel();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.dataTbPelanggan = new Guna.UI.WinForms.GunaDataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnPilih = new Guna.UI.WinForms.GunaAdvenceButton();
            this.txtCariPelanggan = new Guna.UI.WinForms.GunaLineTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new Guna.UI.WinForms.GunaAdvenceButton();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
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
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataTbPelanggan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTbPelanggan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTbPelanggan.BackgroundColor = System.Drawing.Color.White;
            this.dataTbPelanggan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataTbPelanggan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataTbPelanggan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataTbPelanggan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataTbPelanggan.ColumnHeadersHeight = 27;
            this.dataTbPelanggan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataTbPelanggan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnPelanggan});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataTbPelanggan.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.btnRefresh.Size = new System.Drawing.Size(13, 42);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPilih
            // 
            this.btnPilih.AnimationHoverSpeed = 0.07F;
            this.btnPilih.AnimationSpeed = 0.03F;
            this.btnPilih.BackColor = System.Drawing.Color.Transparent;
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
            this.btnPilih.Image = ((System.Drawing.Image)(resources.GetObject("btnPilih.Image")));
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
            this.btnPilih.Radius = 5;
            this.btnPilih.Size = new System.Drawing.Size(120, 42);
            this.btnPilih.TabIndex = 37;
            this.btnPilih.Text = "Pilih";
            this.btnPilih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.CheckedBorderColor = System.Drawing.Color.Black;
            this.btnAdd.CheckedForeColor = System.Drawing.Color.White;
            this.btnAdd.CheckedImage = null;
            this.btnAdd.CheckedLineColor = System.Drawing.Color.DimGray;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.Location = new System.Drawing.Point(31, 472);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnHoverLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(58)))), ((int)(((byte)(170)))));
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 5;
            this.btnAdd.Size = new System.Drawing.Size(121, 42);
            this.btnAdd.TabIndex = 40;
            this.btnAdd.Text = "Tambah";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnBack.TabIndex = 41;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form_Pelanggan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(410, 530);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAdd);
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
        private Guna.UI.WinForms.GunaAdvenceButton btnAdd;
        private Guna.UI.WinForms.GunaButton btnBack;
    }
}
