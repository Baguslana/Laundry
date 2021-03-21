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
    public partial class Form_Pelanggan : Form
    {
        public string getIdMember;
        public string namaMember;
        public int row;
        Guna.UI.WinForms.GunaTextBox txtId;
        Guna.UI.WinForms.GunaTextBox txtCari;

        public Form_Pelanggan(Guna.UI.WinForms.GunaTextBox id, Guna.UI.WinForms.GunaTextBox cari)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            txtCari = cari;
            txtId = id;
        }

        private void Form_Pelanggan_Load(object sender, EventArgs e)
        {
            readDataPelanggan();
        }

        private void readDataPelanggan()
        {
            string query = "SELECT * FROM tb_member";
            DataTable data = Db.Read(query);
            dataTbPelanggan.AutoGenerateColumns = false;
            dataTbPelanggan.DataSource = data;
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            if (row >= 0)
            {
                txtId.Text = dataTbPelanggan.Rows[row].Cells["ColumnId"].Value.ToString();
                txtCari.Text = dataTbPelanggan.Rows[row].Cells["ColumnNama"].Value.ToString();
                this.Hide();
            }
            else MessageBox.Show("Anda Harus Pilih Pelanggan Terlebih Dahulu!", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataTbPelanggan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int row = dataTbCariMember.CurrentCell.RowIndex;
            getIdMember = dataTbCariMember.Rows[row].Cells["ColumnId"].Value.ToString();
            namaMember = dataTbCariMember.Rows[row].Cells["ColumnNama"].Value.ToString();*/
            if (e.RowIndex >= 0) row = e.RowIndex;
        }

        private void dataTbPelanggan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (row >= 0)
            {
                txtId.Text = dataTbPelanggan.Rows[row].Cells["ColumnId"].Value.ToString();
                txtCari.Text = dataTbPelanggan.Rows[row].Cells["ColumnNama"].Value.ToString();
                this.Hide();
            }
            else MessageBox.Show("Anda Harus Pilih Pelanggan Terlebih Dahulu!", "PERHATIAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchDataPelanggan()
        {
            string query = "SELECT * FROM tb_member WHERE tb_member.nama LIKE '%" + txtCariPelanggan.Text + "%' ";

            DataTable data = Db.Read(query);
            dataTbPelanggan.AutoGenerateColumns = false;
            dataTbPelanggan.DataSource = data;
        }

        private void txtCariPelanggan_TextChanged(object sender, EventArgs e)
        {
            searchDataPelanggan();
        }
    }
}
