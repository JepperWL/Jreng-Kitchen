using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jreng_Kitchen
{
    public partial class FormSales : Form
    {
        FormLogin formLogin;
        FormPesanan formPesanan;
        FormHistory formHistory;
        FormProduk formProduk;

        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;

        string query;

        DataTable tabelPemesanan;
        DataTable tabelDetailPemesanan = new DataTable();
        DataTable tabelMenu;
        DataTable tabelStaff;
        DataTable tabelPenjualanBulanIni = new DataTable();
        DataTable tabelIDPenjualan = new DataTable();

        public FormSales(FormLogin fLogin, MySqlConnection conn, DataTable dtPemesanan, FormPesanan fPesanan, DataTable dtMenu, DataTable dtStaff)
        {
            InitializeComponent();

            formLogin = (FormLogin)fLogin;
            connect = conn;
            tabelPemesanan = dtPemesanan;
            formPesanan = fPesanan;
            tabelMenu = dtMenu;
            tabelStaff = dtStaff;
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            try
            {
                cb_namaStaff.DataSource = tabelStaff;
                cb_namaStaff.DisplayMember = "NAMA_PEKERJA";
                cb_namaStaff.ValueMember = "ID_PEKERJA";

                cb_namaStaff.SelectedIndex = -1;

                cb_merchant.Items.Add("Gojek");
                cb_merchant.Items.Add("Grab");
                cb_merchant.Items.Add("Shopee");

                cb_merchant.SelectedIndex = -1;

                tb_totalPotongan.Enabled = false;

                tb_tahun.Text = "2024";

                cb_bulan.Items.Add("Januari");
                cb_bulan.Items.Add("Februari");
                cb_bulan.Items.Add("Maret");
                cb_bulan.Items.Add("April");
                cb_bulan.Items.Add("Mei");
                cb_bulan.Items.Add("Juni");
                cb_bulan.Items.Add("Juli");
                cb_bulan.Items.Add("Agustus");
                cb_bulan.Items.Add("September");
                cb_bulan.Items.Add("Oktober");
                cb_bulan.Items.Add("November");
                cb_bulan.Items.Add("Desember");

                cb_bulan.SelectedIndex = DateTime.Now.Month - 1;

                query = $"SELECT * FROM VPENJUALANBULANINI;";
                command = new MySqlCommand(query, connect);

                adapter = new MySqlDataAdapter(command);

                adapter.Fill(tabelPenjualanBulanIni);

                dgv_penjualan.DataSource = tabelPenjualanBulanIni;
                dgv_penjualan.ClearSelection();

                dgv_penjualan.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_penjualan.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_penjualan.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_penjualan.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_penjualan.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                query = $"SELECT ID_PENJUALAN FROM PENJUALAN_ONLINE;";
                command = new MySqlCommand(query, connect);

                adapter = new MySqlDataAdapter(command);

                adapter.Fill(tabelIDPenjualan);

                btn_konfirmasi.Enabled = false;
                btn_ubah.Enabled = false;
                btn_hapus.Enabled = false;

                cb_bulanLaporan.Items.Add("Januari");
                cb_bulanLaporan.Items.Add("Februari");
                cb_bulanLaporan.Items.Add("Maret");
                cb_bulanLaporan.Items.Add("April");
                cb_bulanLaporan.Items.Add("Mei");
                cb_bulanLaporan.Items.Add("Juni");
                cb_bulanLaporan.Items.Add("Juli");
                cb_bulanLaporan.Items.Add("Agustus");
                cb_bulanLaporan.Items.Add("September");
                cb_bulanLaporan.Items.Add("Oktober");
                cb_bulanLaporan.Items.Add("November");
                cb_bulanLaporan.Items.Add("Desember");

                tb_tahunLaporan.Text = DateTime.Now.ToString("yyyy");
                cb_bulanLaporan.SelectedIndex = DateTime.Now.Month - 1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_namaStaff.SelectedItem != null && cb_merchant.SelectedItem != null && tb_totalPendapatan.Text != "" && tb_totalPesanan.Text != "" && cb_bulan.SelectedItem != null && tb_tahun.Text != null)
                {
                    tabelIDPenjualan.Clear();

                    query = $"SELECT ID_PENJUALAN FROM PENJUALAN_ONLINE;";
                    command = new MySqlCommand(query, connect);

                    adapter = new MySqlDataAdapter(command);

                    adapter.Fill(tabelIDPenjualan);

                    string idPenjualan = cb_merchant.Text.Substring(0, 2).ToUpper() + tb_tahun.Text + (cb_bulan.SelectedIndex + 1).ToString("D2");

                    bool exist = false;

                    for (int i = 0; i < tabelIDPenjualan.Rows.Count; i++)
                    {
                        if (tabelIDPenjualan.Rows[i][0].ToString() == idPenjualan)
                        {
                            exist = true;
                            break;
                        }
                    }

                    if (!exist)
                    {
                        DateTime tglInput = dtp_tglInput.Value;

                        int potongan = 0;

                        if (tb_totalPotongan.Text == "" || tb_totalPotongan.Text == "0")
                        {
                            potongan = 0;
                        }
                        else
                        {
                            potongan = Convert.ToInt32(tb_totalPotongan.Text);
                        }

                        tabelPenjualanBulanIni.Clear();

                        query = $"INSERT INTO PENJUALAN_ONLINE VALUES('{idPenjualan}', '{cb_namaStaff.SelectedValue.ToString()}', '{tglInput.ToString("yyyy-MM-dd")}', '{cb_merchant.Text}', {Convert.ToInt32(tb_totalPendapatan.Text)}, {Convert.ToInt32(tb_totalPesanan.Text)}, {pajak}, {biayaAdmin}, {potongan}, 'F')";
                        command = new MySqlCommand(query, connect);
                        command.ExecuteNonQuery();

                        query = $"SELECT * FROM VPENJUALANBULANINI;";
                        command = new MySqlCommand(query, connect);

                        adapter = new MySqlDataAdapter(command);

                        adapter.Fill(tabelPenjualanBulanIni);

                        MessageBox.Show($"Detail pendapatan dari {cb_merchant.Text} pada {cb_bulan.Text} {tb_tahun.Text} berhasil di-input");
                    }
                    else
                    {
                        MessageBox.Show($"Detail pendapatan dari {cb_merchant.Text} pada {cb_bulan.Text} {tb_tahun.Text} gagal di-input karena sudah terdaftar sebelumnya", "Error");
                    }

                    cb_namaStaff.SelectedIndex = -1;
                    cb_merchant.SelectedIndex = -1;
                    tb_tahun.Text = DateTime.Now.ToString("yyyy");
                    cb_bulan.SelectedIndex = DateTime.Now.Month - 1;
                    tb_totalPendapatan.Clear();
                    tb_totalPesanan.Clear();
                    tb_pajak.Clear();
                    tb_biayaAdmin.Clear();
                    tb_totalPotongan.Clear();

                    dgv_penjualan.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tb_totalPendapatan_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tb_totalPesanan_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tb_pajak_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tb_pajak_TextChanged(object sender, EventArgs e)
        {
            totalPotongan();
        }

        private void tb_biayaAdmin_TextChanged(object sender, EventArgs e)
        {
            totalPotongan();
        }

        int pajak = 0;
        int biayaAdmin = 0;

        private void totalPotongan()
        {
            try
            {
                if (tb_pajak.Text.Length == 0 || tb_pajak.Text == "0")
                {
                    pajak = 0;
                }
                else
                {
                    pajak = Convert.ToInt32(tb_pajak.Text);
                }

                if (tb_biayaAdmin.Text.Length == 0 || tb_biayaAdmin.Text == "0")
                {
                    biayaAdmin = 0;
                }
                else
                {
                    biayaAdmin = Convert.ToInt32(tb_biayaAdmin.Text);
                }

                int sum = pajak + biayaAdmin;

                tb_totalPotongan.Text = sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void tb_tahun_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        string totPendapatanLama;
        string totPesananLama;
        string pajakLama;
        string biayaAdminLama;
        string totPotonganLama;

        string currentIDPenjualan;
        private void dgv_penjualan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_penjualan.CurrentRow != null)
                {
                    dtp_tglInput.Enabled = false;
                    cb_namaStaff.Enabled = false;
                    cb_merchant.Enabled = false;
                    tb_tahun.Enabled = false;
                    cb_bulan.Enabled = false;
                    tb_totalPendapatan.Enabled = false;
                    tb_totalPesanan.Enabled = false;
                    tb_pajak.Enabled = false;
                    tb_biayaAdmin.Enabled = false;
                    btn_konfirmasi.Enabled = false;
                    btn_tambah.Enabled = false;
                    btn_hapus.Enabled = true;
                    btn_ubah.Enabled = true;

                    DataGridViewRow selectedPenjualan = dgv_penjualan.CurrentRow;

                    cb_namaStaff.Text = selectedPenjualan.Cells[0].Value.ToString();
                    cb_merchant.Text = selectedPenjualan.Cells[1].Value.ToString();
                    tb_tahun.Text = DateTime.Now.ToString("yyyy");
                    cb_bulan.SelectedIndex = DateTime.Now.Month - 1;
                    tb_totalPendapatan.Text = selectedPenjualan.Cells[2].Value.ToString();
                    tb_totalPesanan.Text = selectedPenjualan.Cells[3].Value.ToString();
                    tb_pajak.Text = selectedPenjualan.Cells[4].Value.ToString();
                    tb_biayaAdmin.Text = selectedPenjualan.Cells[5].Value.ToString();
                    tb_totalPotongan.Text = selectedPenjualan.Cells[6].Value.ToString();

                    totPendapatanLama = tb_totalPendapatan.Text;
                    totPesananLama = tb_totalPesanan.Text;
                    pajakLama = tb_pajak.Text;
                    biayaAdminLama = tb_biayaAdmin.Text;
                    totPotonganLama = tb_totalPotongan.Text;

                    currentIDPenjualan = cb_merchant.Text.Substring(0, 2).ToUpper() + tb_tahun.Text + (cb_bulan.SelectedIndex + 1).ToString("D2");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_penjualan.SelectedRows.Count != 0)
                {
                    tb_totalPendapatan.Enabled = true;
                    tb_totalPesanan.Enabled = true;
                    tb_pajak.Enabled = true;
                    tb_biayaAdmin.Enabled = true;
                    btn_konfirmasi.Enabled = true;
                    btn_hapus.Enabled = true;
                    btn_ubah.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Pilih detail pendapatan yang mau di-edit terlebih dahulu", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_totalPendapatan.Text != totPendapatanLama)
                {
                    query = $"UPDATE PENJUALAN_ONLINE SET TOTAL_PENDAPATAN = {Convert.ToInt32(tb_totalPendapatan.Text)} WHERE ID_PENJUALAN = '{currentIDPenjualan}';";
                    command = new MySqlCommand(query, connect);
                    command.ExecuteNonQuery();
                }

                if (tb_totalPesanan.Text != totPesananLama)
                {
                    query = $"UPDATE PENJUALAN_ONLINE SET TOTAL_PESANAN = {Convert.ToInt32(tb_totalPesanan.Text)} WHERE ID_PENJUALAN = '{currentIDPenjualan}';";
                    command = new MySqlCommand(query, connect);
                    command.ExecuteNonQuery();
                }

                if (tb_pajak.Text != pajakLama)
                {
                    query = $"UPDATE PENJUALAN_ONLINE SET PAJAK = {pajak} WHERE ID_PENJUALAN = '{currentIDPenjualan}';";
                    command = new MySqlCommand(query, connect);
                    command.ExecuteNonQuery();
                }

                if (tb_biayaAdmin.Text != biayaAdminLama)
                {
                    query = $"UPDATE PENJUALAN_ONLINE SET BIAYA_ADMIN = {biayaAdmin} WHERE ID_PENJUALAN = '{currentIDPenjualan}';";
                    command = new MySqlCommand(query, connect);
                    command.ExecuteNonQuery();
                }

                if (tb_totalPotongan.Text != totPotonganLama)
                {
                    query = $"UPDATE PENJUALAN_ONLINE SET POTONGAN = {pajak + biayaAdmin} WHERE ID_PENJUALAN = '{currentIDPenjualan}';";
                    command = new MySqlCommand(query, connect);
                    command.ExecuteNonQuery();
                }

                dtp_tglInput.Enabled = true;
                cb_namaStaff.Enabled = true;
                cb_merchant.Enabled = true;
                tb_tahun.Enabled = true;
                cb_bulan.Enabled = true;
                tb_totalPendapatan.Enabled = true;
                tb_totalPesanan.Enabled = true;
                tb_pajak.Enabled = true;
                tb_biayaAdmin.Enabled = true;
                btn_tambah.Enabled = true;
                btn_konfirmasi.Enabled = false;
                btn_ubah.Enabled = false;
                btn_hapus.Enabled = false;

                cb_namaStaff.SelectedIndex = -1;
                cb_merchant.SelectedIndex = -1;
                tb_tahun.Text = DateTime.Now.ToString("yyyy");
                cb_bulan.SelectedIndex = DateTime.Now.Month - 1;
                tb_totalPendapatan.Clear();
                tb_totalPesanan.Clear();
                tb_pajak.Clear();
                tb_biayaAdmin.Clear();
                tb_totalPotongan.Clear();

                tabelPenjualanBulanIni.Clear();

                query = $"SELECT * FROM VPENJUALANBULANINI;";
                command = new MySqlCommand(query, connect);

                adapter = new MySqlDataAdapter(command);

                adapter.Fill(tabelPenjualanBulanIni);

                dgv_penjualan.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_penjualan.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih detail pendapatan yang mau dihapus terlebih dahulu", "Error");
                }
                else
                {
                    int indexRow = dgv_penjualan.CurrentCell.RowIndex;

                    currentIDPenjualan = cb_merchant.Text.Substring(0, 2).ToUpper() + tb_tahun.Text + (cb_bulan.SelectedIndex + 1).ToString("D2");

                    tabelMenu.Rows.RemoveAt(indexRow);

                    query = $"DELETE FROM PENJUALAN_ONLINE WHERE ID_PENJUALAN = '{currentIDPenjualan}'";
                    command = new MySqlCommand(query, connect);

                    command.ExecuteNonQuery();
                }

                tabelPenjualanBulanIni.Clear();

                query = $"SELECT * FROM VPENJUALANBULANINI;";
                command = new MySqlCommand(query, connect);

                adapter = new MySqlDataAdapter(command);

                adapter.Fill(tabelPenjualanBulanIni);

                dgv_penjualan.ClearSelection();

                dtp_tglInput.Enabled = true;
                cb_namaStaff.Enabled = true;
                cb_merchant.Enabled = true;
                tb_tahun.Enabled = true;
                cb_bulan.Enabled = true;
                tb_totalPendapatan.Enabled = true;
                tb_totalPesanan.Enabled = true;
                tb_pajak.Enabled = true;
                tb_biayaAdmin.Enabled = true;
                btn_tambah.Enabled = true;

                cb_namaStaff.SelectedIndex = -1;
                cb_merchant.SelectedIndex = -1;
                tb_tahun.Text = DateTime.Now.ToString("yyyy");
                cb_bulan.SelectedIndex = DateTime.Now.Month - 1;
                tb_totalPendapatan.Clear();
                tb_totalPesanan.Clear();
                tb_pajak.Clear();
                tb_biayaAdmin.Clear();
                tb_totalPotongan.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_lihatLaporan_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_bulanLaporan.SelectedItem != null && tb_tahunLaporan.Text != "")
                {
                    int bulanLaporan = cb_bulanLaporan.SelectedIndex + 1;

                    FormPassword formPassword = new FormPassword(formLogin, this, formHistory, formProduk, connect, cb_bulanLaporan.Text, tb_tahunLaporan.Text, bulanLaporan, tabelPemesanan, formPesanan, tabelMenu, tabelStaff);

                    formPassword.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tb_tahunLaporan_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_beranda_Click(object sender, EventArgs e)
        {
            try
            {
                formLogin.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_pesan_Click(object sender, EventArgs e)
        {
            try
            {
                FormPesanan formPesanan = new FormPesanan(formLogin, connect, tabelPemesanan, formHistory, tabelMenu, tabelStaff);
                this.Hide();

                formPesanan.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                FormProduk formProduk = new FormProduk(formLogin, connect, tabelMenu, tabelPemesanan, formHistory, tabelStaff);
                this.Hide();

                formProduk.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_riwayat_Click(object sender, EventArgs e)
        {
            try
            {
                FormHistory formHistory = new FormHistory(formLogin, connect, tabelPemesanan, formPesanan, tabelMenu, tabelStaff);
                this.Hide();

                formHistory.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void panel_laporan_Paint(object sender, PaintEventArgs e)
        {
            Pen borderPen = new Pen(Color.Black, 1); 

            int cornerRadius = 25;

            Rectangle rect = new Rectangle(0, 0, panel_laporan.Width - 1, panel_laporan.Height - 1);

            GraphicsPath path = new GraphicsPath();

            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90);
            path.CloseFigure();

            e.Graphics.DrawPath(borderPen, path);

            borderPen.Dispose();
            path.Dispose();
        }
    }
}
