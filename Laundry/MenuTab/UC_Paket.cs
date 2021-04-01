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
using Laundry.MenuTab.FormPopup;

namespace Laundry.MenuTab
{
    public partial class UC_Paket : UserControl
    {
        public UC_Paket()
        {
            InitializeComponent();
        }

        private string getIdPaket;

        private void UC_Paket_Load(object sender, EventArgs e)
        {
            readDataPaket();
        }

        private void readDataPaket()
        {
            string query = "SELECT * FROM tb_paket LEFT JOIN tb_jenis ON tb_paket.id_jenis = tb_jenis.id LEFT JOIN tb_outlet ON tb_paket.id_outlet = tb_outlet.id ORDER BY tb_outlet.id DESC";
            DataTable data = Db.Read(query);
            dataTbPaket.AutoGenerateColumns = false;
            dataTbPaket.DataSource = data;
        }

        private void dataTbPaket_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataTbPaket.CurrentCell.RowIndex;
            getIdPaket = dataTbPaket.Rows[row].Cells["ColumnId"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /*Form AddPaket = new Form_AddPaket(btnRefresh);
            AddPaket.ShowDialog();*/

            new Form_AddPaket(btnRefresh).ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdPaket))
            {
                /*Form EditPaket = new Form_EditPaket(getIdPaket, btnRefresh);
                EditPaket.ShowDialog();*/

                new Form_EditPaket(getIdPaket, btnRefresh).ShowDialog();
            }
            else MessageBox.Show("Silahkan pilih data terlebih dahulu!", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteDataPaket()
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin Menghapus Data Ini?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_paket", $"id = {getIdPaket}");
                MessageBox.Show("Data berhasil dihapus");
                readDataPaket();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdPaket))
            {
                deleteDataPaket();
            }
            else MessageBox.Show("Silahkan pilih data terlebih dahulu!", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            readDataPaket();
        }

        private void btnJenisPaket_Click(object sender, EventArgs e)
        {
            new Form_JenisPaket().ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT * FROM tb_paket LEFT JOIN tb_jenis ON tb_paket.id_jenis = tb_jenis.id LEFT JOIN tb_outlet ON tb_paket.id_outlet = tb_outlet.id WHERE tb_paket.nama_paket LIKE '%" + txtSearch.Text + "%'" +
                           "OR tb_paket.harga LIKE '%" + txtSearch.Text + "%' OR tb_outlet.nama LIKE '%" + txtSearch.Text + "%' OR tb_jenis.jenis LIKE '%" + txtSearch.Text + "%'";
            DataTable data = Db.Read(query);
            dataTbPaket.AutoGenerateColumns = false;
            dataTbPaket.DataSource = data;
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            txtSearch.ResetText();
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Length >= 0)
            {
                txtSearch.ForeColor = Color.Black;
            }

            if (txtSearch.Text.Length <= 0)
            {
                txtSearch.Text = "Search . . .";
                txtSearch.ForeColor = Color.Gray;
                readDataPaket();
            }
        }
    }
}
