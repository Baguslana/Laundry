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
    public partial class Form_AddQty : Form
    {
        Guna.UI.WinForms.GunaDataGridView tbTransaksi;
        string idPaket;
        string nama;
        int harga;

        public Form_AddQty(string id, Guna.UI.WinForms.GunaDataGridView tb)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            tbTransaksi = tb;
            idPaket = id;
        }

        private void Form_AddQty_Load(object sender, EventArgs e)
        {
            DataTable data = Db.Read("tb_paket", "nama_paket, harga", $"id='{idPaket}'");
            if (data.Rows.Count > 0)
            {
                nama = data.Rows[0].Field<string>("nama_paket");
                harga = data.Rows[0].Field<int>("harga");
            }
            else
            {
                MessageBox.Show("Terjadi Kesalahan", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtQuantity.Focus();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text.Length > 0 && txtQuantity.Text != "0")
            {
                double total = Convert.ToDouble(txtQuantity.Text) * harga;
                tbTransaksi.Rows.Add(idPaket, nama, txtQuantity.Text, total);
                this.Hide();
            }
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
