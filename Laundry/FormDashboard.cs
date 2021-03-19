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

        private void Dashboard_Load(object sender, EventArgs e)
        {
            /*if (Session.getUserLogged().Rows.Count > 0)
            {
                if (Session.getUserLogged().Rows[0].Field<string>("level") == "kasir")
                {
                    //btnpayments.Visible = false;

                    
                }

                if (Session.getUserLogged().Rows[0].Field<string>("level") == "owner")
                {
                    //labelstudents.Visible = false;
                    
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
    }
}
