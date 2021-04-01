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
    public partial class Form_EditPelanggan : Form
    {
        string getIdPelanggan;
        Guna.UI.WinForms.GunaAdvenceButton btrf;

        public Form_EditPelanggan(string id, Guna.UI.WinForms.GunaAdvenceButton btrrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            getIdPelanggan = id;
            btrf = btrrefresh;
        }

        private void Form_EditPelanggan_Load(object sender, EventArgs e)
        {
            DataTable dataEdit = Db.Read("tb_member", "*", $"id = {getIdPelanggan}");
            txtNama.Text = dataEdit.Rows[0].Field<string>("nama");
            txtAlamat.Text = dataEdit.Rows[0].Field<string>("alamat");
            txtNoTelepon.Text = dataEdit.Rows[0].Field<string>("tlp");
            txtJenisKelamin.Text = dataEdit.Rows[0].Field<string>("jenis_kelamin");
            var jk = dataEdit.Rows[0].Field<string>("jenis_kelamin");
            if (jk == "L")
            {
                rbLakilaki.Checked = true;
            }
            else
            {
                rbPerempuan.Checked = true;
            }
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var nama = txtNama.Text;
                var alamat = txtAlamat.Text;
                var jk = txtJenisKelamin.Text;
                var notlp = txtNoTelepon.Text;
                if (Db.Update("tb_member", $"nama = '{nama}', alamat = '{alamat}', jenis_kelamin = '{jk}', tlp = '{notlp}'", $"id = {getIdPelanggan}"))
                {
                    MessageBox.Show("Data berhasil diubah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else MessageBox.Show($"Gagal mengubah Pelanggan. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool isFilled()
        {
            if (txtNama.Text.Length > 0 && txtAlamat.Text.Length > 0 && txtJenisKelamin.Text.Length > 0 && txtNoTelepon.Text.Length >= 0) return true;
            return false;
        }

        private void rbLakilaki_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLakilaki.Checked)
            {
                txtJenisKelamin.Text = "L";
            }
        }

        private void rbPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPerempuan.Checked)
            {
                txtJenisKelamin.Text = "P";
            }
        }

        private void txtNoTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
