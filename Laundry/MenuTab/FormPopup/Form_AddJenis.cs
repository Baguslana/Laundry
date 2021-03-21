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
    public partial class Form_AddJenis : Form
    {
        Guna.UI.WinForms.GunaAdvenceButton btrf;

        public Form_AddJenis(Guna.UI.WinForms.GunaAdvenceButton btrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            btrf = btrefresh;
        }

        private void Form_AddJenis_Load(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var namaPaket = txtJenisPaket.Text;
                if (Db.Insert("tb_paket", $"null, '{namaPaket}'"))
                {
                    MessageBox.Show("Data Telah Ditambahkan!");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah Jenis Paket. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else MessageBox.Show("Tolong isi Field yang kosong!");
        }

        private bool isFilled()
        {
            if (txtJenisPaket.Text.Length > 0 ) return true;
            return false;
        }
    }
}
