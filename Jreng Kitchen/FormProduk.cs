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
    public partial class FormProduk : Form
    {
        FormLogin formLogin;
        FormHistory formHistory;
        FormPesanan formPesanan;

        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;

        string query;

        DataTable tabelMenu;
        DataTable tabelPemesanan;
        DataTable tabelStaff;
        DataTable tabelSemuaMenu;

        public FormProduk(FormLogin fLogin, MySqlConnection conn, DataTable dtMenu, DataTable dtPemesanan, FormHistory fHistory, DataTable dtStaff)
        {
            InitializeComponent();

            formLogin = (FormLogin)fLogin;
            connect = conn;
            tabelMenu = dtMenu;
            tabelPemesanan = dtPemesanan;
            formHistory = fHistory;
            tabelStaff = dtStaff;
        }

        private void FormProduk_Load(object sender, EventArgs e)
        {
            btn_konfirmasi.Enabled = false;
            btn_ubah.Enabled = false;
            btn_hapus.Enabled = false;
        }
        private void isiUlangTabelMenu()
        {
            tabelMenu.Clear();
            query = $"SELECT * FROM VDAFTARPRODUKAVAIL";
            //query = $"SELECT ID_PRODUK AS 'ID Produk', NAMA_PRODUK AS 'Nama Produk', HARGA_PRODUK AS 'Harga Produk' FROM PRODUK WHERE STATUS_DEL = 'F';";
            command = new MySqlCommand(query, connect);

            adapter = new MySqlDataAdapter(command);
            adapter.Fill(tabelMenu);

            tabelSemuaMenu = new DataTable();
            tabelSemuaMenu.Clear();
            query = $"SELECT ID_PRODUK AS 'ID Produk', NAMA_PRODUK AS 'Nama Produk', HARGA_PRODUK AS 'Harga Produk' FROM PRODUK;";
            command = new MySqlCommand(query, connect);

            adapter = new MySqlDataAdapter(command);
            adapter.Fill(tabelSemuaMenu);
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            try
            {
                bool exist = false;

                if (tb_namaMenu.Text != "" && tb_hargaMenu.Text != "")
                {
                    for (int i = 0; i < tabelMenu.Rows.Count; i++)
                    {
                        if (tabelMenu.Rows[i][1].ToString().ToLower() == tb_namaMenu.Text.ToLower())
                        {
                            exist = true;
                            break;
                        }
                    }

                    if (exist)
                    {
                        MessageBox.Show("Produk gagal di-input karena produk sudah terdaftar sebelumnya", "Error");
                    }
                    else
                    {
                        isiUlangTabelMenu();
                        DataTable produkLama = new DataTable();
                        query = $"SELECT ID_PRODUK AS 'ID Produk', NAMA_PRODUK AS 'Nama Produk', HARGA_PRODUK AS 'Harga Produk' FROM PRODUK WHERE STATUS_DEL = 'T' AND NAMA_PRODUK = '{tb_namaMenu.Text}';";
                        command = new MySqlCommand(query, connect);
                        adapter = new MySqlDataAdapter(command);
                        adapter.Fill(produkLama);
                        bool produkAda = false;
                        for (int i = 0;i < tabelSemuaMenu.Rows.Count;i++)
                        {
                            if (tabelSemuaMenu.Rows[i][1].ToString().ToUpper() == tb_namaMenu.Text.ToUpper())
                            {
                                produkAda = true;
                                break;
                            }
                        }

                        if (produkAda)
                        {
                            query = $"UPDATE PRODUK SET STATUS_DEL = 'F' WHERE NAMA_PRODUK = '{tb_namaMenu.Text}' AND STATUS_DEL = 'T';";
                            command = new MySqlCommand(query, connect);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Produk berhasil dikembalikan");
                        }
                        else
                        {
                            query = $"INSERT INTO PRODUK VALUES (null, '{tb_namaMenu.Text}', '{tb_hargaMenu.Text}', 'F');";
                            command = new MySqlCommand(query, connect);

                            command.ExecuteNonQuery();

                            MessageBox.Show("Produk berhasil di-input");
                        }
                    }
                    isiUlangTabelMenu();
                }

                tb_namaMenu.Clear();
                tb_hargaMenu.Clear();
                dgv_menu.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tb_hargaMenu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_menu.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih produk yang mau dihapus terlebih dahulu", "Error");
                }
                else
                {
                    tb_hargaMenu.Clear();
                    tb_namaMenu.Clear();
                    tb_namaMenu.Enabled = true;
                    tb_hargaMenu.Enabled = true;
                    int indexRow = dgv_menu.CurrentCell.RowIndex;

                    string idMenuKlik = tabelMenu.Rows[indexRow][0].ToString();

                    tabelMenu.Rows.RemoveAt(indexRow);

                    query = $"UPDATE PRODUK SET STATUS_DEL = 'T' WHERE ID_PRODUK = '{idMenuKlik}'";
                    command = new MySqlCommand(query, connect);

                    command.ExecuteNonQuery();
                }

                dgv_menu.ClearSelection();
                btn_tambah.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        string hargaLama = "";

        private void dgv_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow selectedMenu = dgv_menu.CurrentRow;

                tb_namaMenu.Enabled = false;
                tb_hargaMenu.Enabled = false;

                tb_namaMenu.Text = selectedMenu.Cells[1].Value.ToString();
                tb_hargaMenu.Text = selectedMenu.Cells[2].Value.ToString();

                hargaLama = selectedMenu.Cells[2].Value.ToString();

                btn_tambah.Enabled = false;
                btn_ubah.Enabled = true;
                btn_hapus.Enabled = true;
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
                if (dgv_menu.SelectedRows.Count != 0)
                {
                    tb_hargaMenu.Enabled = true;
                    btn_konfirmasi.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Pilih menu yang mau di-edit terlebih dahulu", "Error");
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
                if (tb_hargaMenu.Text != hargaLama)
                {
                    query = $"UPDATE PRODUK SET HARGA_PRODUK = {tb_hargaMenu.Text} WHERE NAMA_PRODUK = '{tb_namaMenu.Text}';";
                    command = new MySqlCommand(query, connect);
                    command.ExecuteNonQuery();

                    MessageBox.Show($"Harga {tb_namaMenu.Text} berhasil diubah");
                }
                else
                {
                    MessageBox.Show($"Harga {tb_namaMenu.Text} tidak diubah");
                }

                isiUlangTabelMenu();

                btn_tambah.Enabled = true;
                tb_namaMenu.Clear();
                tb_hargaMenu.Clear();
                dgv_menu.ClearSelection();
                tb_namaMenu.Enabled = true;
                btn_konfirmasi.Enabled = false;
                btn_ubah.Enabled = false;
                btn_hapus.Enabled = false;
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
                tabelMenu.Clear();

                if (tb_search.Text == "")
                {
                    tb_hargaMenu.Clear();
                    tb_namaMenu.Clear();
                    tb_namaMenu.Enabled = true;
                    tb_hargaMenu.Enabled = true;
                    btn_tambah.Enabled = true;
                    isiUlangTabelMenu();
                }
                else
                {
                    tb_hargaMenu.Clear();
                    tb_namaMenu.Clear();
                    tb_namaMenu.Enabled = true;
                    tb_hargaMenu.Enabled = true;
                    btn_tambah.Enabled = true;
                    query = $"SELECT ID_PRODUK AS 'ID Produk', NAMA_PRODUK AS 'Nama Produk', HARGA_PRODUK AS 'Harga Produk' FROM PRODUK WHERE STATUS_DEL = 'F' AND (ID_PRODUK LIKE '%{tb_search.Text}%' OR NAMA_PRODUK LIKE '%{tb_search.Text}%');";
                    command = new MySqlCommand(query, connect);
                    adapter = new MySqlDataAdapter(command);
                    adapter.Fill(tabelMenu);
                }

                dgv_menu.DataSource = tabelMenu;
                dgv_menu.ClearSelection();

                dgv_menu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
