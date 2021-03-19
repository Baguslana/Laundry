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

        }

        private void readDataPaket()
        {
            string query = "SELECT * FROM tb_paket";
            DataTable data = Db.Read(query);
            dataTbPaket.AutoGenerateColumns = false;
            dataTbPaket.DataSource = data;
        }

        private void dataTbPaket_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form AddPaket = new Form_AddPaket(btnRefresh);
            AddPaket.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(getIdPaket))
            {
                Form EditPaket = new Form_EditPaket(getIdPaket, btnRefresh);
                EditPaket.ShowDialog();
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
    }
}
