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
    public partial class Form_EditOutlet : Form
    {
        string getIdOutlet;
        Guna.UI.WinForms.GunaAdvenceButton btrf;

        public Form_EditOutlet(string id, Guna.UI.WinForms.GunaAdvenceButton btrrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            getIdOutlet = id;
            btrf = btrrefresh;
        }

        private void Form_EditOutlet_Load(object sender, EventArgs e)
        {
            DataTable dataEdit = Db.Read("tb_outlet", "*", $"id = {getIdOutlet}");
            txtNama.Text = dataEdit.Rows[0].Field<string>("nama");
            txtAlamat.Text = dataEdit.Rows[0].Field<string>("alamat");
            txtNoTelepon.Text = dataEdit.Rows[0].Field<string>("tlp");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var nama = txtNama.Text;
                var alamat = txtAlamat.Text;
                var notlp = txtNoTelepon.Text;
                if (Db.Update("tb_outlet", $"nama = '{nama}', alamat = '{alamat}', tlp = '{notlp}'", $"id = {getIdOutlet}"))
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
            if (txtNama.Text.Length > 0 && txtAlamat.Text.Length > 0 && txtNoTelepon.Text.Length >= 0) return true;
            return false;
        }

        private void txtNoTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
