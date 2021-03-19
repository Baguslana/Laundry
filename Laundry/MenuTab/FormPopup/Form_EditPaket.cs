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
    public partial class Form_EditPaket : Form
    {
        string getIdPaket;
        Guna.UI.WinForms.GunaAdvenceButton btrf;
        public string gambar = "null";

        public Form_EditPaket(string id, Guna.UI.WinForms.GunaAdvenceButton btrrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            getIdPaket = id;
            btrf = btrrefresh;
        }

        private void Form_EditPaket_Load(object sender, EventArgs e)
        {
            DataTable dataEdit = Db.Read("tb_paket", "*", $"id = {getIdPaket}");
            txtNamaPaket.Text = dataEdit.Rows[0].Field<string>("nama");
            txtHarga.Text = dataEdit.Rows[0].Field<string>("harga");

            //Outlet
            cmbOutlet.DataSource = Db.Read("tb_outlet", "*");
            cmbOutlet.DisplayMember = "nama";
            cmbOutlet.ValueMember = "id";

            //Jenis Paket
            cmbJenisPaket.DataSource = Db.Read("tb_jenis", "*");
            cmbJenisPaket.DisplayMember = "jenis";
            cmbJenisPaket.ValueMember = "id";

            cmbOutlet.SelectedValue = dataEdit.Rows[0].Field<int>("id_outlet");
            cmbJenisPaket.SelectedValue = dataEdit.Rows[0].Field<int>("id_jenis");
            string g = dataEdit.Rows[0].Field<string>("icon");
            if (!string.IsNullOrEmpty(g))
            {
                gambar = $"'{dataEdit.Rows[0].Field<string>("icon")}'";
                picIcon.Image = Program.LoadImage(gambar.Replace("'", ""));
            }
            else gambar = "null";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var namapaket = txtNamaPaket.Text;
                var harga = txtHarga.Text;
                var jenispaket = cmbJenisPaket.Text;
                var outlet = cmbOutlet.SelectedValue.ToString();
                if (Db.Update("tb_paket", $"nama_paket = '{namapaket}', harga = '{harga}', id_jenis = '{jenispaket}', id_outlet = '{outlet}', icon = '{gambar}'", $"id = {getIdPaket}"))
                {
                    MessageBox.Show("Data berhasil diubah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else MessageBox.Show($"Gagal mengubah User. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isFilled()
        {
            if (txtNamaPaket.Text.Length > 0 && txtHarga.Text.Length > 0 && cmbJenisPaket.SelectedIndex >= 0 && cmbOutlet.SelectedIndex >= 0) return true;
            return false;
        }
    }
}
