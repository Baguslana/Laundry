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
        public Form_Pelanggan()
        {
            InitializeComponent();
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

        }

        private void dataTbPelanggan_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
