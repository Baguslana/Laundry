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
    public partial class UC_EntriTransaksi : UserControl
    {
        int id_outlet;
        int id_user;

        double total = 0;
        double diskon = 0;
        double pajak = 0;
        double biayaTambahan = 0;
        double totalTagihan = 0;

        public UC_EntriTransaksi()
        {
            InitializeComponent();
        }

        private void UC_EntriTransaksi_Load(object sender, EventArgs e)
        {
            gunaDateTimePicker1.Value = DateTime.Now.AddDays(3);

            //binding combobox outlet
            cmbOutlet.DataSource = Db.Read("tb_outlet", "id, nama");
            cmbOutlet.DisplayMember = "nama";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.SelectedIndex = -1;

            if (Session.getUserLogged().Rows[0].Field<string>("role") != "admin")
            {
                lblPilihOutlet.Hide();
                cmbOutlet.Hide();
                id_outlet = Session.getUserLogged().Rows[0].Field<int>("id_outlet");
            }

            id_user = Session.getUserLogged().Rows[0].Field<int>("id");
            //lblNama.Text = Session.getUserLogged().Rows[0].Field<string>("nama");
            loadItems();
        }

        public void generateItem(DataTable dt)
        {
            flPaket.Controls.Clear();
            foreach (DataRow row in dt.Rows)
            {
                var item = new Guna.UI.WinForms.GunaTileButton
                {
                    Name = row.Field<int>("id").ToString(),
                    BaseColor = Color.FromArgb((47), (85), (184)),
                    OnHoverBaseColor = Color.FromArgb((47), (85), (160)),
                    OnPressedDepth = 0,
                    Image = Program.LoadImage(row.Field<string>("icon")),
                    ImageSize = new Size(48, 48),
                    TextImageOffsetY = 10,
                    Width = 128,
                    Height = 100,
                    Text = row.Field<string>("nama_paket"),
                    Font = new Font(new FontFamily("Calibri"), 9)
                    //Radius = 8

                };
                item.Click += new EventHandler(functionItems);
                flPaket.Controls.Add(item);
            }
        }

        public void loadItems()
        {
            if (id_outlet > 0)
            {
                DataTable data = Db.Read("tb_paket", "*", $"id_outlet='{id_outlet}'");
                generateItem(data);
            }
        }

        private void cmbOutlet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbOutlet.SelectedIndex >= 0)
            {
                try
                {
                    id_outlet = Convert.ToInt32(cmbOutlet.SelectedValue.ToString());
                }
                catch
                { }
                loadItems();

            }
        }

        public void functionItems(Object sender, EventArgs e)
        {
            var item = (sender as Guna.UI.WinForms.GunaTileButton);
            new FormAddQuantity(item.Name, dataTableEntriTransaksi).ShowDialog();
        }

        private void btnCariPelanggan_Click(object sender, EventArgs e)
        {
            Form cariMember = new Form_Pelanggan(txtIdPelanggan, txtPelanggan);
            cariMember.ShowDialog();
        }
    }
}
