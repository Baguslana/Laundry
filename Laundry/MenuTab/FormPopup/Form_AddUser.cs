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

namespace Laundry.MenuTab
{
    public partial class Form_AddUser : Form
    {
        Guna.UI.WinForms.GunaAdvenceButton btrf;

        public Form_AddUser(Guna.UI.WinForms.GunaAdvenceButton btrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            btrf = btrefresh;
        }

        private void Form_AddUser_Load(object sender, EventArgs e)
        {
            DataTable outlet = Db.Read("tb_outlet", "id, nama");
            cmbOutlet.DisplayMember = "nama";
            cmbOutlet.ValueMember = "id";
            cmbOutlet.DataSource = outlet;
            cmbOutlet.StartIndex = -1;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (isFilled() && isUsernameValid())
            {
                var nama = txtNama.Text;
                var username = txtUsername.Text;
                var password = Sha256.Encrypt(txtPassword.Text);
                var outlet = cmbOutlet.SelectedValue.ToString();
                /*if (cbRole.SelectedIndex == 1) outlet = cbOutlet.SelectedValue.ToString();*/
                var role = cmbRole.Text;
                if (Db.Insert("tb_user", $"null, '{nama}','{username}','{password}', {outlet},'{role}'"))
                {
                    MessageBox.Show("Data Telah Ditambahkan!");
                    btrf.PerformClick();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show($"Gagal Menambah User. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Tolong isi Field yang kosong");
        }

        private bool isFilled()
        {
            if (txtNama.Text.Length > 0 && txtUsername.Text.Length > 0 && txtPassword.Text.Length > 0 && cmbRole.SelectedIndex >= 0 && cmbOutlet.SelectedIndex != 2) return true;
            return false;
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = Char.ToLower(e.KeyChar);
        }

        private bool isUsernameValid()
        {
            if (txtUsername.Text.Contains(" ")) return false;
            return true;
        }
    }
}
