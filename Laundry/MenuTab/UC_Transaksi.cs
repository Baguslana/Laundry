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
        public UC_Transaksi()
        {
            InitializeComponent();
        }

        private void UC_Transaksi_Load(object sender, EventArgs e)
        {
            loadDataTransaksi();
        }

        private void loadDataTransaksi()
        {
            string query = "SELECT DISTINCT(tb_transaksi.kode_invoice),tb_member.nama, tb_transaksi.total_pembayaran, tb_transaksi.tgl, tb_transaksi.batas_waktu, tb_transaksi.status, tb_transaksi.dibayar, tb_user.nama FROM tb_transaksi JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id ORDER BY tb_transaksi.tgl DESC";
            DataTable data = Db.Read(query);
            dataTbMember.AutoGenerateColumns = false;
            dataTbMember.DataSource = data;
        }
    }
}
