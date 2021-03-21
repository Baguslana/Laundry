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

        private void txtDiskon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtPajak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtBiayaTambahan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
            (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void searchDataPaket(string keyword)
        {
            if (id_outlet > 0)
            {
                DataTable data = Db.Read("tb_paket", "*", $"id_outlet='{id_outlet}' && nama_paket LIKE '%{keyword}%'");
                generateItem(data);
            }
        }

        private void txtPaket_TextChanged(object sender, EventArgs e)
        {
            if (txtPaket.Text.Length > 0) searchDataPaket(txtPaket.Text);
            else loadItems();
        }

        private void dataTableEntriTransaksi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColumnAction.Index)
            {
                string item = dataTableEntriTransaksi.Rows[e.RowIndex].Cells["ColumnPaket"].Value.ToString();
                var confirm = MessageBox.Show($"Apakah anda yakin ingin menghapus '{item}' dari keranjang?", "KONFIRMASI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    dataTableEntriTransaksi.Rows.Remove(dataTableEntriTransaksi.Rows[e.RowIndex]);
                }
            }
        }

        private void hitung()
        {
            total = 0;
            // total cucian(Rupiah)
            foreach (DataGridViewRow row in dataTableEntriTransaksi.Rows)
            {
                total = total + Convert.ToInt32(row.Cells["ColumnHarga"].Value);
            }

            // diskon (Persen)
            if (txtDiskon.Text.Length > 0)
            {
                diskon = total * (Convert.ToDouble(txtDiskon.Text) / 100);
            }
            else diskon = 0;

            // pajak (Persen)
            if (txtPajak.Text.Length > 0)
            {
                pajak = total * (Convert.ToDouble(txtPajak.Text) / 100);
            }
            else pajak = 0;

            // biaya tambahan (Rupiah)
            if (txtBiayaTambahan.Text.Length > 0) biayaTambahan = Convert.ToDouble(txtBiayaTambahan.Text);
            else biayaTambahan = 0;

            //total tagihan
            totalTagihan = (total + biayaTambahan + pajak) - diskon;

            labelHargaCucian.Text = total.ToString("C0");
            labelDiskon.Text = diskon.ToString("C0");
            labelPajak.Text = pajak.ToString("C0");
            labelBiayaTambahan.Text = biayaTambahan.ToString("C0");
            labelTotal.Text = totalTagihan.ToString("C0");
        }

        private void dataTableEntriTransaksi_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dataTableEntriTransaksi.Rows.Count > 0)
            {
                txtDiskon.Enabled = true;
                txtPajak.Enabled = true;
                txtBiayaTambahan.Enabled = true;
            }

            hitung();
        }

        private void dataTableEntriTransaksi_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (dataTableEntriTransaksi.Rows.Count <= 0)
            {
                txtDiskon.Enabled = false;
                txtPajak.Enabled = false;
                txtBiayaTambahan.Enabled = false;
            }

            hitung();
        }

        private void txtDiskon_TextChanged(object sender, EventArgs e)
        {
            hitung();
        }

        private void txtPajak_TextChanged(object sender, EventArgs e)
        {
            hitung();
        }

        private void txtBiayaTambahan_TextChanged(object sender, EventArgs e)
        {
            hitung();
        }

        private bool isFilled()
        {
            return true;
        }

        private bool isValid()
        {
            return true;
        }

        private void resetTransaksi()
        {
            txtPaket.ResetText();
            txtKeterangan.ResetText();
            gunaDateTimePicker1.Value = DateTime.Now.AddDays(3);
            txtIdPelanggan.ResetText();
            txtPelanggan.ResetText();
            txtDiskon.ResetText();
            txtPajak.ResetText();
            txtBiayaTambahan.ResetText();
            gunaWinSwitch1.Checked = false;
            dataTableEntriTransaksi.Rows.Clear();
            labelHargaCucian.Text = "0";
            labelDiskon.Text = "0";
            labelPajak.Text = "0";
            labelBiayaTambahan.Text = "0";
            labelTotal.Text = "0";

            if (Session.getUserLogged().Rows[0].Field<string>("role") == "Admin") cmbOutlet.SelectedIndex = -1;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            /* if (isFilled() && isValid())
            {
                int next_id;
                DataTable result = Db.Read("SELECT id FROM tb_transaksi ORDER BY id DESC LIMIT 1");
                if (result.Rows.Count > 0) next_id = result.Rows[0].Field<int>("id") + 1;
                else next_id = 1;

                if (Db.ExecuteQuery($"ALTER TABLE tb_transaksi AUTO_INCREMENT = {next_id}"))
                {
                    string invoice = $"INV{id_outlet}{id_user}{DateTime.Now.ToString("yyMMddHHmm")}";
                    string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    diskon = Convert.ToDouble((diskon / tbKeranjang.Rows.Count).ToString().Replace(",", "."));
                    pajak = Convert.ToDouble((pajak / tbKeranjang.Rows.Count).ToString().Replace(",", "."));
                    biayaTambahan = Convert.ToDouble((biayaTambahan / tbKeranjang.Rows.Count).ToString().Replace(",", "."));
                    string tgl_bayar = "null";
                    string dibayar = "belum";

                    if (SwitchBayarLangsung.Checked)
                    {
                        tgl_bayar = $"'{now}'";
                        dibayar = "lunas";
                    }

                    foreach (DataGridViewRow row in tbKeranjang.Rows)
                    {
                        string id_paket = row.Cells["ColumnId"].Value.ToString();
                        string qty = row.Cells["ColumnQTY"].Value.ToString().Replace(",", ".");
                        double total = Convert.ToDouble(row.Cells["ColumnHarga"].Value) + pajak + biayaTambahan - diskon;
                        if (Db.ExecuteQuery(
                            $"CALL transaksi({next_id},{id_outlet},'{invoice}', {txtIdPelanggan.Text}, '{now}', '{txtBatasWaktu.Value.ToString("yyyy/MM/dd")}', {tgl_bayar}, '{biayaTambahan}', '{diskon}', '{pajak}', '{total}', 'baru', '{dibayar}', {id_user}, {id_paket}, '{qty}', '{txtKeterangan.Text}')"
                            )) next_id++;
                        else MessageBox.Show($"ERROR : {Error.error_msg}");
                        txtKeterangan.Text = $"CALL transaksi({next_id},{id_outlet},'{invoice}', {txtIdPelanggan.Text}, '{now}', '{txtBatasWaktu.Value.ToString("yyyy/MM/dd")}', '{tgl_bayar}', '{biayaTambahan}', '{diskon}', '{pajak}', '{total}', 'baru', '{dibayar}', {id_user}, {id_paket}, '{qty}', '{txtKeterangan.Text}')";
                    }

                    //resetTransaksi();
                }*/

            if (isFilled() && isValid())
            {
                int next_id;
                DataTable result = Db.Read("SELECT id FROM tb_transaksi ORDER BY id DESC LIMIT 1");
                if (result.Rows.Count > 0) next_id = result.Rows[0].Field<int>("id") + 1;
                else next_id = 1;

                if (Db.ExecuteQuery($"ALTER TABLE tb_transaksi AUTO_INCREMENT = {next_id}"))
                {
                    string invoice = $"INV{id_outlet}{id_user}{DateTime.Now.ToString("yyMMddHHmm")}";
                    string now = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    diskon = Convert.ToDouble((diskon / dataTableEntriTransaksi.Rows.Count).ToString().Replace(",", "."));
                    pajak = Convert.ToDouble((pajak / dataTableEntriTransaksi.Rows.Count).ToString().Replace(",", "."));
                    biayaTambahan = Convert.ToDouble((biayaTambahan / dataTableEntriTransaksi.Rows.Count).ToString().Replace(",", "."));
                    string tgl_bayar = "null";
                    string dibayar = "belum_dibayar";

                    if (gunaWinSwitch1.Checked)
                    {
                        tgl_bayar = $"'{now}'";
                        dibayar = "dibayar";
                    }

                    foreach (DataGridViewRow row in dataTableEntriTransaksi.Rows)
                    {
                        string id_paket = row.Cells["ColumnId"].Value.ToString();
                        string qty = row.Cells["ColumnQTY"].Value.ToString().Replace(",", ".");
                        double total = Convert.ToDouble(row.Cells["ColumnHarga"].Value) + pajak + biayaTambahan - diskon;
                        if (Db.ExecuteQuery(
                            $"CALL transaksi({next_id}, {id_outlet}, '{invoice}', {txtIdPelanggan.Text}, '{now}', '{gunaDateTimePicker1.Value.ToString("yyyy/MM/dd")}', {tgl_bayar}, '{biayaTambahan}', '{diskon}', '{pajak}', '{total}', 'baru', '{dibayar}', {id_user}, {id_paket}, '{qty}', '{txtKeterangan.Text}')"
                            )) next_id++;
                        else MessageBox.Show($"ERROR : {Error.error_msg}");
                    }

                    resetTransaksi();
                    MessageBox.Show("Transaksi Telah Ditambahkan", "PEMBERITAHUAN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
