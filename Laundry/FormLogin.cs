using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Luthor.lib;
using Luthor.lib.Encryption;
using System.Windows.Forms;

namespace Laundry
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0)
            {
                if (Auth.Login(txtUsername.Text, Sha256.Encrypt(txtPassword.Text), "tb_user"))
                {
                    Db.Insert("login_log", $"null, NOW(), {Session.getUserLogged().Rows[0].Field<int>("id")}");
                    Form Dashboard = new FormDashboard();
                    this.Hide();
                    Dashboard.Show();
                }
                else
                {
                    /*MessageBox.Show("Username atau password salah", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPassword.Focus();*/

                    if (Auth.Login($"SELECT * FROM tb_user WHERE username='{txtUsername.Text}'"))
                    {
                        MessageBox.Show("Password salah!");
                        txtPassword.ResetText();
                        txtPassword.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Username tidak terdaftar!");
                        resetTextBox();
                    }
                }
            }
            /*else if (txtUsername.Text.Length == 0 && txtPassword.Text.Length == 0) MessageBox.Show("Masukan username dan password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (txtUsername.Text.Length == 0)
            {
                MessageBox.Show("Masukan username", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
            else if (txtPassword.Text.Length == 0)
            {
                MessageBox.Show("Masukan password", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                txtPassword.ResetText();
            }*/
        }

        private void resetTextBox()
        {
            txtUsername.ResetText();
            txtPassword.ResetText();
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToLower(e.KeyChar);
        }
    }
}
