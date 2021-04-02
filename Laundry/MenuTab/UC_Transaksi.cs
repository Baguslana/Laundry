using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luthor.lib;
using System.Windows.Forms;

namespace Laundry.MenuTab
{
    public partial class UC_Transaksi : UserControl
    {
        string id_outlet;

        public UC_Transaksi()
        {
            InitializeComponent();
        }

        private void UC_Transaksi_Load(object sender, EventArgs e)
        {
            // binding status(combobox)
            ColumnStatusCucian.Items.Clear();
            ColumnStatusCucian.Items.AddRange(new string[] { "baru", "proses", "selesai", "diambil" });
            ColumnStatusCucian.DisplayMember = "status";
            ColumnStatusCucian.ValueMember = "status";
            ColumnStatusCucian.DataPropertyName = "status";

            // binding pembayaran(combobox)
            ColumnStatusPembayaran.Items.Clear();
            ColumnStatusPembayaran.Items.AddRange(new string[] { "dibayar", "belum" });
            ColumnStatusPembayaran.DisplayMember = "dibayar";
            ColumnStatusPembayaran.ValueMember = "dibayar";
            ColumnStatusPembayaran.DataPropertyName = "dibayar";

            cmbOutlet.DataSource = Db.Read("tb_outlet WHERE id != 10", "id, nama");
            cmbOutlet.DisplayMember = "nama";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;

            if (Session.getUserLogged().Rows[0].Field<string>("level") != "admin")
            {
                cmbOutlet.SelectedValue = Session.getUserLogged().Rows[0].Field<int>("id_outlet").ToString();
                cmbOutlet.Enabled = false;
                id_outlet = Session.getUserLogged().Rows[0].Field<int>("id_outlet").ToString();
            }
            loadDataTransaksi();
        }

        private void loadDataTransaksi()
        {
            string query = "SELECT DISTINCT(tb_transaksi.kode_invoice),tb_member.nama, tb_transaksi.total_pembayaran, tb_transaksi.tgl, tb_transaksi.batas_waktu, tb_transaksi.status, " +
                $"tb_transaksi.dibayar, tb_user.nama FROM tb_transaksi JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id WHERE tb_transaksi.id_outlet='{cmbOutlet.SelectedValue}' ORDER BY tb_transaksi.tgl DESC";
            DataTable data = Db.Read(query);
            dataTbTransaksi.AutoGenerateColumns = false;
            dataTbTransaksi.DataSource = data;
        }

        private void dataTbMember_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string invoice = dataTbTransaksi.Rows[e.RowIndex].Cells["ColumnInvoice"].Value.ToString();
            string status = dataTbTransaksi.Rows[e.RowIndex].Cells["ColumnStatusCucian"].Value.ToString();
            string dibayar = dataTbTransaksi.Rows[e.RowIndex].Cells["ColumnStatusPembayaran"].Value.ToString();
            string tgl_bayar = "null";
            if (dibayar == "lunas") tgl_bayar = $"NOW()";
            if (!Db.Update("tb_transaksi", $"status='{status}', dibayar='{dibayar}', tgl_bayar = {tgl_bayar}", $"kode_invoice = '{invoice}'"))
                MessageBox.Show($"Gagal mengubah data transaksi.\n\nERROR: {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void cmbOutlet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOutlet.SelectedIndex >= 0) loadDataTransaksi();
        }
    }
}
