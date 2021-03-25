using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Luthor.lib;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.IO;

namespace Laundry
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Connection.setConnection("localhost", "dblaundry", "root", "");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormLogin());
            if (Connection.Ping()) Application.Run(new FormDashboard());
            else MessageBox.Show("Tidak terhubung dengan database. Silahkan hubungi teknisi", "DATABASES CONNECTION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static Image LoadImage(string base64)
        {
            if (base64 != null)
            {
                byte[] bytes = Convert.FromBase64String(base64);

                Image image;
                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    image = Image.FromStream(ms);
                }

                return image;
            }
            else
            {
                return null;
            }
        }
    }
}
