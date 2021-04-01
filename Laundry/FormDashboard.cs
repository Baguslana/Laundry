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
using Laundry.MenuTab;

namespace Laundry
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(Session.getUserLogged().Rows[0].Field<string>("level"));
            /*if (Session.getUserLogged().Rows.Count > 0)
            {
                if (Session.getUserLogged().Rows[0].Field<string>("level") != "admin")
                {
                    btnOutlet.Visible = false;
                    btnPaket.Hide();
                    btnPengguna.Hide();
                }

                if (Session.getUserLogged().Rows[0].Field<string>("level") == "owner")
                {
                    btnMember.Hide();
                    btnOutlet.Hide();
                    btnPaket.Hide();
                    btnPengguna.Hide();
                    btnEntriTransaksi.Hide();
                    btnDataTransaksi.Hide();
                }
            }*/
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            PanelMenu.Controls.Clear();
            UserControl pelanggan = new UC_Pelanggan();
            pelanggan.Dock = DockStyle.Fill;
            PanelMenu.Controls.Add(pelanggan);
        }

        private void btnPengguna_Click(object sender, EventArgs e)
        {
            PanelMenu.Controls.Clear();
            UserControl pengguna = new UC_User();
            pengguna.Dock = DockStyle.Fill;
            PanelMenu.Controls.Add(pengguna);
        }

        private void btnOutlet_Click(object sender, EventArgs e)
        {
            PanelMenu.Controls.Clear();
            UserControl outlet = new UC_Outlet();
            outlet.Dock = DockStyle.Fill;
            PanelMenu.Controls.Add(outlet);
        }

        private void btnPaket_Click(object sender, EventArgs e)
        {
            PanelMenu.Controls.Clear();
            UserControl paket = new UC_Paket();
            paket.Dock = DockStyle.Fill;
            PanelMenu.Controls.Add(paket);
        }

        private void btnEntriTransaksi_Click(object sender, EventArgs e)
        {
            PanelMenu.Controls.Clear();
            UserControl entri = new UC_EntriTransaksi();
            entri.Dock = DockStyle.Fill;
            PanelMenu.Controls.Add(entri);
        }

        private void btnDataTransaksi_Click(object sender, EventArgs e)
        {
            PanelMenu.Controls.Clear();
            UserControl data = new UC_Transaksi();
            data.Dock = DockStyle.Fill;
            PanelMenu.Controls.Add(data);
        }

        private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Anda yakin ingin logout?", "KONFORMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Auth.Logout();
                this.Hide();
                Form login = new FormLogin();
                login.Show();
            }
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            PanelMenu.Controls.Clear();
            UserControl report = new UC_Report();
            report.Dock = DockStyle.Fill;
            PanelMenu.Controls.Add(report);
        }
    }
}
