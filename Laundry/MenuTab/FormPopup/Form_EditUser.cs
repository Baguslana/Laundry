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
using Luthor.lib.Encryption;

namespace Laundry.MenuTab
{
    public partial class Form_EditUser : Form
    {
        string getId;
        Guna.UI.WinForms.GunaAdvenceButton btrf;
        string CurrentPass;

        public Form_EditUser(string id, Guna.UI.WinForms.GunaAdvenceButton btrrefresh)
        {
            InitializeComponent();
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            getId = id;
            btrf = btrrefresh;
        }

        private void Form_EditUser_Load(object sender, EventArgs e)
        {
            DataTable dataEdit = Db.Read("tb_user", "*", $"id = {getId}");
            txtNama.Text = dataEdit.Rows[0].Field<string>("nama");
            txtUsername.Text = dataEdit.Rows[0].Field<string>("username");
            CurrentPass = dataEdit.Rows[0].Field<string>("password");
            //txtPassword.Text = dataEdit.Rows[0].Field<string>("passwrod");
            cmbRole.SelectedIndex = cmbRole.FindStringExact(dataEdit.Rows[0].Field<string>("level"));
            cmbOutlet.DataSource = Db.Read("tb_outlet", "*");
            cmbOutlet.DisplayMember = "nama";
            cmbOutlet.ValueMember = "id";
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            if (isFilled())
            {
                var nama = txtNama.Text;
                var username = txtUsername.Text;
                var password = "";
                if (txtPassword.Text.Length > 0) Sha256.Encrypt(txtPassword.Text);
                else password = CurrentPass;
                var role = cmbRole.Text;
                var outlet = cmbOutlet.SelectedValue.ToString();
                if (Db.Update("tb_user", $"nama = '{nama}', username = '{username}', password = '{password}', id_outlet = {outlet}, level = '{role}'", $"id = {getId}"))
                {
                    MessageBox.Show("Data berhasil diubah");
                    btrf.PerformClick();
                    this.Hide();
                }
                else MessageBox.Show($"Gagal mengubah User. \n\n ERROR MESSAGE: \n {Error.error_msg}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
        }

        private bool isFilled()
        {
            if (txtNama.Text.Length > 0 && txtUsername.Text.Length > 0 && cmbRole.SelectedIndex >= 0 && cmbOutlet.SelectedIndex >= 0) return true;
            return false;
        }
    }
}
