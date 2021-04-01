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
    public partial class UC_Pelanggan : UserControl
    {
        public UC_Pelanggan()
        {
            InitializeComponent();
        }

        private string getIdPelanggan;

        private void UC_Member_Load(object sender, EventArgs e)
        {
            readDataMember();
        }

        private void readDataMember()
        {
            string query = "SELECT * FROM tb_member";
            DataTable data = Db.Read(query);
            dataTbMember.AutoGenerateColumns = false;
            dataTbMember.DataSource = data;
        }

        private void dataTbMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataTbMember.CurrentCell.RowIndex;
            getIdPelanggan = dataTbMember.Rows[row].Cells["ColumnId"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form AddPelanggan = new Form_AddPelanggan(btnRefresh);
            AddPelanggan.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdPelanggan))
            {
                Form EditPelanggan = new Form_EditPelanggan(getIdPelanggan, btnRefresh);
                EditPelanggan.ShowDialog();
            }
            else MessageBox.Show("Silahkan pilih data terlebih dahulu!", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteDataUser()
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin Menghapus Data Ini?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_member", $"id = {getIdPelanggan}");
                MessageBox.Show("Data berhasil dihapus");
                readDataMember();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdPelanggan))
            {
                deleteDataUser();
            }
            else MessageBox.Show("Silahkan pilih data terlebih dahulu!", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            readDataMember();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT* FROM tb_member WHERE CONCAT(nama, alamat, tlp) LIKE '%{txtSearch.Text}%'";
            DataTable data = Db.Read(query);
            dataTbMember.AutoGenerateColumns = false;
            dataTbMember.DataSource = data;
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
                readDataMember();
            }
        }
    }
}
