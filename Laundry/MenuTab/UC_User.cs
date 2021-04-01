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
    public partial class UC_User : UserControl
    {
        public UC_User()
        {
            InitializeComponent();
        }

        private string getId;

        private void UserControl1_Load(object sender, EventArgs e)
        {
            readDataUser();
        }

        private void readDataUser()
        {
            string query = "SELECT tb_user.*, tb_outlet.nama as namaOutlet FROM tb_user LEFT JOIN tb_outlet ON tb_user.id_outlet = tb_outlet.id";
            DataTable data = Db.Read(query);
            dataTbUser.AutoGenerateColumns = false;
            dataTbUser.DataSource = data;
        }

        private void dataTbUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataTbUser.CurrentCell.RowIndex;
            getId = dataTbUser.Rows[row].Cells["ColumnId"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form AddUser = new Form_AddUser(btnRefresh);
            AddUser.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getId))
            {
                Form EditUser = new Form_EditUser(getId, btnRefresh);
                EditUser.ShowDialog();
            }
            else MessageBox.Show("Silahkan pilih data terlebih dahulu!", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteDataUser()
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin Menghapus Data Ini?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_user", $"id = {getId}");
                MessageBox.Show("Data berhasil dihapus");
                readDataUser();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getId))
            {
                deleteDataUser();
            }
            else MessageBox.Show("Silahkan pilih data terlebih dahulu!", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            readDataUser();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT tb_user.*, tb_outlet.nama as namaOutlet FROM tb_user LEFT JOIN tb_outlet ON tb_user.id_outlet = tb_outlet.id WHERE CONCAT(tb_user.nama, username, level, tb_outlet.nama) LIKE '%{txtSearch.Text}%'";
            DataTable data = Db.Read(query);
            dataTbUser.AutoGenerateColumns = false;
            dataTbUser.DataSource = data;
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
                readDataUser();
            }
        }
    }
}
