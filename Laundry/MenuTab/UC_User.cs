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
            string query = "SELECT * FROM tb_user";
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
            Form AddUser = new Form_AddUser();
            AddUser.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /*Form EditUser = new Form_EditUser();
            EditUser.ShowDialog();*/
        }

        private void deleteDataUser()
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin Menghapus Data Ini?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_user", $"id = {getId}");
                readDataUser();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteDataUser();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            readDataUser();
        }  
    }
}
