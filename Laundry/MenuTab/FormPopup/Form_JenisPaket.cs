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
    public partial class Form_JenisPaket : Form
    {
        public Form_JenisPaket()
        {
            InitializeComponent();
        }

        private void Form_JenisPaket_Load(object sender, EventArgs e)
        {
            readDataJenisPaket();
        }

        private void readDataJenisPaket()
        {
            string query = "SELECT * FROM tb_jenis";
            DataTable data = Db.Read(query);
            dataTbJenisPaket.AutoGenerateColumns = false;
            dataTbJenisPaket.DataSource = data;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtJenisPaket.Text.Length > 0)
            {
                var namaPaket = txtJenisPaket.Text;
                if (Db.Insert("tb_jenis", $"null, '{namaPaket}'"))
                {
                    MessageBox.Show("Data Telah Ditambahkan!");
                    readDataJenisPaket();
                    txtJenisPaket.ResetText();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah Jenis Paket. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else MessageBox.Show("Tolong isi Field yang kosong!");
        }

        private void dataTbPaket_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            var confirm = MessageBox.Show($"Apakah anda yakin ingin menghapus jenis '{dataTbJenisPaket.Rows[e.Row.Index].Cells["ColumnJenisPaket"].Value.ToString()}' ?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes) Db.Delete("tb_jenis", $"id='{dataTbJenisPaket.Rows[e.Row.Index].Cells["ColumnId"].Value.ToString()}'");
            else e.Cancel = true;
        }

        private void dataTbPaket_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataTbJenisPaket.Rows[e.RowIndex];
                var id = row.Cells["ColumnId"].Value;
                var nama = row.Cells["ColumnJenisPaket"].Value;


                if (!Db.Update("tb_jenis", $"jenis = '{nama}'", $"id='{id}'"))
                    MessageBox.Show($"Gagal mengubah data jenis '{nama}' \n\nERROR MESSAGE : \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            readDataJenisPaket();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
