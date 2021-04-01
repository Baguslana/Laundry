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
    public partial class UC_Report : UserControl
    {
        string id_outlet;
        public UC_Report()
        {
            InitializeComponent();
        }

        private void UC_Report_Load(object sender, EventArgs e)
        {
            id_outlet = Session.getUserLogged().Rows[0].Field<int>("id_outlet").ToString();
        }

        private void btnTampilkan_Click(object sender, EventArgs e)
        {
            //DataTable data = Db.Read($"SELECT DISTINCT(tb_transaksi.kode_invoice),tb_member.nama, tb_transaksi.total_pembayaran, tb_transaksi.tgl, tb_transaksi.batas_waktu, tb_transaksi.status, tb_transaksi.dibayar, tb_user.nama FROM tb_transaksi JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id WHERE tb_transaksi.id_outlet='{id_outlet}' AND tgl_bayar BETWEEN '{dtpDari.Value.ToString("yyyy/MM/dd")}' AND '{dtpSampai.Value.ToString("yyyy/MM/dd")}' ORDER BY tgl DESC");
            DataTable data = Db.Read($"SELECT DISTINCT(tb_transaksi.kode_invoice),tb_member.nama, tb_transaksi.total_pembayaran, tb_transaksi.tgl, tb_transaksi.batas_waktu, tb_transaksi.status, tb_transaksi.dibayar, tb_user.nama FROM tb_transaksi JOIN tb_member ON tb_transaksi.id_member = tb_member.id JOIN tb_user ON tb_transaksi.id_user = tb_user.id WHERE tb_transaksi.id_outlet='{id_outlet}' AND tgl BETWEEN '{dtpDari.Value.ToString("yyyy/MM/dd")}' AND '{dtpSampai.Value.ToString("yyyy/MM/dd")}' ORDER BY tgl DESC");
            Reporting.DataSet1 laporan = new Reporting.DataSet1();
            //MessageBox.Show(data.Rows.Count.ToString());
            foreach (DataRow row in data.Rows)
            {
                laporan.Tables["DataTable1"].Rows.Add(
                    row.Field<string>("kode_invoice"),
                    row.Field<string>("nama"),
                    //Dalam kurung di ToString menentukan format tanggal
                    row.Field<DateTime>("tgl").ToString(),
                    row.Field<double>("total_pembayaran").ToString("C0"),
                    row.Field<string>("dibayar"),
                    row.Field<string>("nama1")
                    );
            }

            laporan1.SetDataSource(laporan);
            crystalReportViewer1.ReportSource = laporan1;
            crystalReportViewer1.RefreshReport();
        }
    }
}
