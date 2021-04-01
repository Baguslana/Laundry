using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luthor.lib;
using System.Windows.Forms;

namespace Laundry.MenuTab.FormPopup
{
    public partial class Form_AddPaket : Form
    {
        Guna.UI.WinForms.GunaAdvenceButton btrf;
        public string gambar = "null";

        public Form_AddPaket(Guna.UI.WinForms.GunaAdvenceButton btrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            btrf = btrefresh;
        }

        private void Form_AddPaket_Load(object sender, EventArgs e)
        {
            cmbOutlet.DisplayMember = "nama";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama");
            cmbOutlet.StartIndex = -1;

            cmbJenisPaket.DisplayMember = "jenis";
            cmbJenisPaket.ValueMember = "id";
            cmbJenisPaket.DataSource = Db.Read("tb_jenis", "id, jenis");
            cmbJenisPaket.StartIndex = -1;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var namaPaket = txtNamaPaket.Text;
                var harga = txtHarga.Text;
                var outlet = cmbOutlet.SelectedValue.ToString();
                var jenis = cmbJenisPaket.SelectedValue;
                if (Db.Insert("tb_paket", $"null, '{outlet}', '{jenis}', '{namaPaket}', '{harga}', {gambar}"))
                {
                    MessageBox.Show("Data Telah Ditambahkan!");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah Paket. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else MessageBox.Show("Tolong isi Field yang kosong!");
        }

        private bool isFilled()
        {
            if (txtNamaPaket.Text.Length > 0 && txtHarga.Text.Length > 0 && cmbJenisPaket.SelectedIndex >= 0 && cmbOutlet.SelectedIndex >= 0) return true;
            return false;
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnIcon_Click(object sender, EventArgs e)
        {
            OpenFileDialog browse = new OpenFileDialog();
            browse.Title = "Cari Gambar";
            browse.Filter = "File Gambar (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            if (browse.ShowDialog() == DialogResult.OK)
            {
                picIcon.Image = Image.FromFile(browse.FileName);
                gambar = $"'{Convert.ToBase64String(System.IO.File.ReadAllBytes(browse.FileName))}'";
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
