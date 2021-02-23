using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace Laundry
{
    public partial class Masuk : Form
    {
        int loadingSpeed = 6;
        float initialPercentage = 0;

        Form ds = new FormDashboard();

        public Masuk()
        {
            InitializeComponent();
        }

        private void Masuk_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*initialPercentage += loadingSpeed;
            float percentage = initialPercentage / pictureBox2.Height * 100;

            label3.Text = (int)percentage + " %";

            panel2.Location = new Point(panel2.Location.X, panel2.Location.Y + loadingSpeed);
            if (panel2.Location.Y > pictureBox1.Location.Y + pictureBox1.Height)
            {
                label3.Text = "100 %";
                this.timer1.Stop();

                ds.Show();
                this.Hide();
            } */
        }
    }
}
