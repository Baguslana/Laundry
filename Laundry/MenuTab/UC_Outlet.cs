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
    public partial class UC_Outlet : UserControl
    {
        public UC_Outlet()
        {
            InitializeComponent();
        }

        private string getIdOutlet;

        private void UC_Outlet_Load(object sender, EventArgs e)
        {
            readDataOutlet();            
        }

        private void readDataOutlet()
        {
            string query = "SELECT * FROM tb_outlet";
            DataTable data = Db.Read(query);
            dataTbOutlet.AutoGenerateColumns = false;
            dataTbOutlet.DataSource = data;
        }

        private void dataTbOutlet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataTbOutlet.CurrentCell.RowIndex;
            getIdOutlet = dataTbOutlet.Rows[row].Cells["ColumnId"].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form AddOutlet = new Form_AddOutlet(btnRefresh);
            AddOutlet.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdOutlet))
            {
                Form EditUser = new Form_EditOutlet(getIdOutlet, btnRefresh);
                EditUser.ShowDialog();
            }
            else MessageBox.Show("Silahkan pilih data terlebih dahulu!", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void deleteDataOutlet()
        {
            var confirm = MessageBox.Show("Apakah anda yakin ingin Menghapus Data Ini?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Db.Delete("tb_outlet", $"id = {getIdOutlet}");
                MessageBox.Show("Data berhasil dihapus");
                readDataOutlet();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdOutlet))
            {
                deleteDataOutlet();
            }
            else MessageBox.Show("Silahkan pilih data terlebih dahulu!", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            readDataOutlet();
        }
    }
}
