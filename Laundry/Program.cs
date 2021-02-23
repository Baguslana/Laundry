using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Luthor.lib;
using System.Windows.Forms;

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
            Connection.setConnection("localhost", "laundry", "root", "");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //            Application.Run(new FormLogin());
            if (Connection.Ping()) Application.Run(new FormLogin());
            else MessageBox.Show("Tidak terhubung dengan database. Silahkan hubungi teknisi", "DATABASES CONNECTION ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
