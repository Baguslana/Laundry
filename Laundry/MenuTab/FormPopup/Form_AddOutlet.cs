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
    public partial class Form_AddOutlet : Form
    {
        Guna.UI.WinForms.GunaAdvenceButton btrf;

        public Form_AddOutlet(Guna.UI.WinForms.GunaAdvenceButton btrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            btrf = btrefresh;
        }

        private void Form_AddOutlet_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var nama = txtNama.Text;
                var alamat = txtAlamat.Text;
                var notlp = txtNoTelepon.Text;
                if (Db.Insert("tb_outlet", $"null, '{nama}','{alamat}','{notlp}'"))
                {
                    MessageBox.Show("Data Telah Ditambahkan!");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah User. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Tolong isi Field yang kosong");
        }

        private bool isFilled()
        {
            if (txtNama.Text.Length > 0 && txtAlamat.Text.Length > 0 && txtNoTelepon.Text.Length != 2) return true;
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
