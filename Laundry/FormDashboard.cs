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
                    *//*btnpayments.Visible = false;

                    labelofficer.Visible = false;
                    btnofficer.Visible = false;*//*
                }

                if (Session.getUserLogged().Rows[0].Field<string>("level") == "owner")
                {
                    *//*labelstudents.Visible = false;
                    btnstudents.Visible = false;
                    btnclass.Visible = false;

                    btnpay.Text = "Riwayat Pembayaran";
                    btnpayments.Visible = false;

                    labelofficer.Visible = false;
                    btnofficer.Visible = false;*//*
                }
            }*/
        }

        private void Btn_Pengguna_Click(object sender, EventArgs e)
        {
            PanelMenu.Controls.Clear();
            UserControl pengguna = new UC_User();
            pengguna.Dock = DockStyle.Fill;
            PanelMenu.Controls.Add(pengguna);
        }
    }
}
