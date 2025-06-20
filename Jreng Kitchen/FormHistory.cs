using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jreng_Kitchen
{
    public partial class FormHistory : Form
    {
        FormLogin formLogin;
        FormPesanan formPesanan;
        FormHistory formHistory;

        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;

        string query;

        DataTable tabelPemesanan;
        DataTable tabelDetailPemesanan = new DataTable();
        DataTable tabelMenu;
        DataTable tabelStaff;

        public FormHistory(FormLogin fLogin, MySqlConnection conn, DataTable dtPemesanan, FormPesanan fPesanan, DataTable dtMenu, DataTable dtStaff)
        {
            InitializeComponent();

            formLogin = (FormLogin)fLogin;
            connect = conn;
            tabelPemesanan = dtPemesanan;
            formPesanan = fPesanan;
            tabelMenu = dtMenu;
            tabelStaff = dtStaff;
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {  
            try
            {
                tb_alamat.Enabled = false;
                tb_biayaOngkir.Enabled = false;
                tb_idPemesanan.Enabled = false;
                tb_noTelp.Enabled = false;
                cb_statusLunas.Enabled = false;
                btn_konfirmasi.Enabled = false;
                cb_metodePembayaran.Enabled = false;
                btn_ubah.Enabled = false;

                cb_statusLunas.Items.Add("Lunas");
                cb_statusLunas.Items.Add("Belum Lunas");

                cb_statusLunas.SelectedIndex = -1;

                cb_metodePembayaran.Items.Add("Transfer");
                cb_metodePembayaran.Items.Add("Cash");

                cb_metodePembayaran.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        string alamatLama = "";
        string statusLunas = "";

        private void dgv_history_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tabelDetailPemesanan.Clear();

                if (dgv_history.CurrentRow != null)
                {
                    btn_ubah.Enabled = true;

                    DataGridViewRow selectedIDPemesanan = dgv_history.CurrentRow;

                    tb_idPemesanan.Text = selectedIDPemesanan.Cells[0].Value.ToString();

                    //query = $"SELECT P.NAMA_PRODUK AS 'Nama Produk', DP.QTY AS 'Qty', DP.HARGA_PCS AS 'Harga Per Produk', SUM(DP.HARGA_PCS * DP.QTY) AS 'Harga Produk' FROM DETAIL_PEMESANAN DP JOIN PRODUK P ON DP.ID_PRODUK = P.ID_PRODUK WHERE ID_PEMESANAN = '{selectedIDPemesanan.Cells[0].Value.ToString()}' GROUP BY 1, 2, 3;";
                    query = $"CALL PDETAILPEMESANAN ('{selectedIDPemesanan.Cells[0].Value.ToString()}')";
                    command = new MySqlCommand(query, connect);

                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabelDetailPemesanan);

                    query = $"SELECT STATUS_LUNAS FROM PEMESANAN WHERE ID_PEMESANAN = '{selectedIDPemesanan.Cells[0].Value.ToString()}'";
                    command = new MySqlCommand(query, connect);

                    if (command.ExecuteScalar().ToString() == "True")
                    {
                        cb_statusLunas.SelectedItem = "Lunas";
                    }
                    else
                    {
                        cb_statusLunas.SelectedItem = "Belum Lunas";
                    }

                    statusLunas = cb_statusLunas.SelectedItem.ToString();

                    query = $"SELECT C.NO_TELEPON_CUSTOMER FROM CUSTOMER C JOIN PEMESANAN P ON P.ID_CUSTOMER = C.ID_CUSTOMER WHERE P.ID_PEMESANAN = '{selectedIDPemesanan.Cells[0].Value.ToString()}';";
                    command = new MySqlCommand(query, connect);

                    tb_noTelp.Text = command.ExecuteScalar().ToString();

                    query = $"SELECT ALAMAT_TRANSAKSI FROM PEMESANAN WHERE ID_PEMESANAN = '{selectedIDPemesanan.Cells[0].Value.ToString()}';";
                    command = new MySqlCommand(query, connect);

                    tb_alamat.Text = command.ExecuteScalar().ToString();
                    alamatLama = tb_alamat.Text;

                    query = $"SELECT BIAYA_ONGKOS_KIRIM FROM PEMESANAN WHERE ID_PEMESANAN = '{selectedIDPemesanan.Cells[0].Value.ToString()}';";
                    command = new MySqlCommand(query, connect);

                    if (command.ExecuteScalar().ToString() == "0")
                    {
                        tb_biayaOngkir.Text = "";
                    }
                    else
                    {
                        tb_biayaOngkir.Text = command.ExecuteScalar().ToString();
                    }

                    query = $"SELECT METODE_PEMBAYARAN FROM PEMESANAN WHERE ID_PEMESANAN = '{selectedIDPemesanan.Cells[0].Value.ToString()}';";
                    command = new MySqlCommand(query, connect);

                    if (command.ExecuteScalar().ToString() == "Transfer")
                    {
                        cb_metodePembayaran.SelectedItem = "Transfer";
                    }
                    else if (command.ExecuteScalar().ToString() == "Cash")
                    {
                        cb_metodePembayaran.SelectedItem = "Cash";
                    }

                    dgv_detailHistory.DataSource = tabelDetailPemesanan;
                    dgv_detailHistory.ClearSelection();

                    dgv_detailHistory.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv_detailHistory.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    dgv_detailHistory.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
                if (dgv_history.SelectedRows.Count != 0)
                {
                    tb_alamat.Enabled = true;
                    cb_statusLunas.Enabled = true;
                    btn_konfirmasi.Enabled = true;
                    btn_ubah.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Pilih pemesanan yang mau di-edit terlebih dahulu", "Error");
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
                bool lunas = false;

                if (cb_statusLunas.SelectedItem.ToString() == "Lunas")
                {
                    lunas = true;
                }
                else if (cb_statusLunas.SelectedItem.ToString() == "Belum Lunas")
                {
                    lunas = false;
                }

                if (tb_alamat.Text != alamatLama)
                {
                    query = $"UPDATE PEMESANAN SET ALAMAT_TRANSAKSI = '{tb_alamat.Text}' WHERE ID_PEMESANAN = '{tb_idPemesanan.Text}';";
                    command = new MySqlCommand(query, connect);
                    command.ExecuteNonQuery();
                }

                if (cb_statusLunas.SelectedItem.ToString() != statusLunas)
                {
                    query = $"UPDATE PEMESANAN SET STATUS_LUNAS = {lunas} WHERE ID_PEMESANAN = '{tb_idPemesanan.Text}';";
                    command = new MySqlCommand(query, connect);
                    command.ExecuteNonQuery();
                }

                tb_alamat.Enabled = false;
                cb_statusLunas.Enabled = false;
                btn_konfirmasi.Enabled = false;
                
                dgv_history.ClearSelection();
                tabelDetailPemesanan.Clear();

                tb_alamat.Clear();
                tb_biayaOngkir.Clear();
                tb_idPemesanan.Clear();
                tb_noTelp.Clear();
                cb_statusLunas.SelectedIndex = -1;
                cb_metodePembayaran.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                tabelPemesanan.Clear();
                tabelDetailPemesanan.Clear();

                tb_alamat.Clear();
                tb_biayaOngkir.Clear();
                tb_idPemesanan.Clear();
                tb_noTelp.Clear();
                cb_statusLunas.SelectedIndex = -1;
                cb_metodePembayaran.SelectedIndex = -1;

                if (tb_cari.Text == "")
                {
                    if (chb_lunas.Checked == true && chb_belumLunas.Checked == true || chb_lunas.Checked == false && chb_belumLunas.Checked == false)
                    {
                        query = $"SELECT * FROM VDAFTARPEMESANAN;";
                        command = new MySqlCommand(query, connect);

                        adapter = new MySqlDataAdapter(command);
                        adapter.Fill(tabelPemesanan);
                    }
                    else if (chb_lunas.Checked == true && chb_belumLunas.Checked == false)
                    {
                        query = $"SELECT PS.ID_PEMESANAN AS 'ID Pemesanan', C.NAMA_CUSTOMER AS 'Nama Customer', P.NAMA_PEKERJA AS 'Nama Staff', PS.TANGGAL_PO AS 'Tanggal PO', PS.TANGGAL_KIRIM AS 'Tanggal Kirim', PS.BIAYA_PESANAN AS 'Total' FROM PEMESANAN PS JOIN CUSTOMER C ON PS.ID_CUSTOMER = C.ID_CUSTOMER JOIN PEKERJA P ON PS.ID_PEKERJA = P.ID_PEKERJA WHERE PS.STATUS_LUNAS = 1;";
                        command = new MySqlCommand(query, connect);

                        adapter = new MySqlDataAdapter(command);
                        adapter.Fill(tabelPemesanan);
                    }
                    else if (chb_lunas.Checked == false && chb_belumLunas.Checked == true)
                    {
                        query = $"SELECT PS.ID_PEMESANAN AS 'ID Pemesanan', C.NAMA_CUSTOMER AS 'Nama Customer', P.NAMA_PEKERJA AS 'Nama Staff', PS.TANGGAL_PO AS 'Tanggal PO', PS.TANGGAL_KIRIM AS 'Tanggal Kirim', PS.BIAYA_PESANAN AS 'Total' FROM PEMESANAN PS JOIN CUSTOMER C ON PS.ID_CUSTOMER = C.ID_CUSTOMER JOIN PEKERJA P ON PS.ID_PEKERJA = P.ID_PEKERJA WHERE PS.STATUS_LUNAS = 0;";
                        command = new MySqlCommand(query, connect);

                        adapter = new MySqlDataAdapter(command);
                        adapter.Fill(tabelPemesanan);
                    }
                }
                else
                {
                    if (chb_lunas.Checked == true && chb_belumLunas.Checked == true || chb_lunas.Checked == false && chb_belumLunas.Checked == false)
                    {
                        query = $"SELECT PS.ID_PEMESANAN AS 'ID Pemesanan', C.NAMA_CUSTOMER AS 'Nama Customer', P.NAMA_PEKERJA AS 'Nama Staff', PS.TANGGAL_PO AS 'Tanggal PO', PS.TANGGAL_KIRIM AS 'Tanggal Kirim', PS.BIAYA_PESANAN AS 'Total' FROM PEMESANAN PS JOIN CUSTOMER C ON PS.ID_CUSTOMER = C.ID_CUSTOMER JOIN PEKERJA P ON PS.ID_PEKERJA = P.ID_PEKERJA WHERE C.NAMA_CUSTOMER LIKE '%{tb_cari.Text}%' OR PS.ID_PEMESANAN LIKE '%{tb_cari.Text}%';";
                        command = new MySqlCommand(query, connect);
                        adapter = new MySqlDataAdapter(command);
                        adapter.Fill(tabelPemesanan);
                    }
                    else if (chb_lunas.Checked == true && chb_belumLunas.Checked == false)
                    {
                        query = $"SELECT PS.ID_PEMESANAN AS 'ID Pemesanan', C.NAMA_CUSTOMER AS 'Nama Customer', P.NAMA_PEKERJA AS 'Nama Staff', PS.TANGGAL_PO AS 'Tanggal PO', PS.TANGGAL_KIRIM AS 'Tanggal Kirim', PS.BIAYA_PESANAN AS 'Total' FROM PEMESANAN PS JOIN CUSTOMER C ON PS.ID_CUSTOMER = C.ID_CUSTOMER JOIN PEKERJA P ON PS.ID_PEKERJA = P.ID_PEKERJA WHERE (C.NAMA_CUSTOMER LIKE '%{tb_cari.Text}%' OR PS.ID_PEMESANAN LIKE '%{tb_cari.Text}%') AND PS.STATUS_LUNAS = 1;";
                        command = new MySqlCommand(query, connect);
                        adapter = new MySqlDataAdapter(command);
                        adapter.Fill(tabelPemesanan);
                    }
                    else if (chb_lunas.Checked == false && chb_belumLunas.Checked == true)
                    {
                        query = $"SELECT PS.ID_PEMESANAN AS 'ID Pemesanan', C.NAMA_CUSTOMER AS 'Nama Customer', P.NAMA_PEKERJA AS 'Nama Staff', PS.TANGGAL_PO AS 'Tanggal PO', PS.TANGGAL_KIRIM AS 'Tanggal Kirim', PS.BIAYA_PESANAN AS 'Total' FROM PEMESANAN PS JOIN CUSTOMER C ON PS.ID_CUSTOMER = C.ID_CUSTOMER JOIN PEKERJA P ON PS.ID_PEKERJA = P.ID_PEKERJA WHERE (C.NAMA_CUSTOMER LIKE '%{tb_cari.Text}%' OR PS.ID_PEMESANAN LIKE '%{tb_cari.Text}%') AND PS.STATUS_LUNAS = 0;";
                        command = new MySqlCommand(query, connect);
                        adapter = new MySqlDataAdapter(command);
                        adapter.Fill(tabelPemesanan);
                    }
                }

                dgv_history.DataSource = tabelPemesanan;

                dgv_history.ClearSelection();

                dgv_history.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

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

        private void btn_produk_Click(object sender, EventArgs e)
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

        private void btn_penjualan_Click(object sender, EventArgs e)
        {
            try
            {
                FormSales formSales = new FormSales(formLogin, connect, tabelPemesanan, formPesanan, tabelMenu, tabelStaff);
                this.Hide();

                formSales.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
