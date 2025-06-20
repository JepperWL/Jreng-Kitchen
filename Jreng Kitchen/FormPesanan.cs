using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Jreng_Kitchen
{
    public partial class FormPesanan : Form
    {
        FormLogin formLogin;
        FormHistory formHistory;

        DataTable tabelPesanan = new DataTable();
        DataTable tabelStaff;
        DataTable tabelCustomer = new DataTable();
        DataTable tabelPemesanan;
        DataTable tabelMenu;

        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;

        string query;

        public FormPesanan(FormLogin fLogin, MySqlConnection conn, DataTable dtPemesanan, FormHistory fHistory, DataTable dtMenu, DataTable dtStaff)
        {
            InitializeComponent();
            connect = conn;
            formLogin = (FormLogin)fLogin;
            tabelPemesanan = dtPemesanan;
            formHistory = fHistory;
            tabelMenu = dtMenu;
            tabelStaff = dtStaff;
        }
        private void FormPesanan_Load(object sender, EventArgs e)
        {
            try
            {
                tabelPesanan.Columns.Add("Nama Produk");
                tabelPesanan.Columns.Add("Harga Per Produk");
                tabelPesanan.Columns.Add("Qty");
                tabelPesanan.Columns.Add("Harga Produk");

                cb_namaStaff.DataSource = tabelStaff;
                cb_namaStaff.DisplayMember = "NAMA_PEKERJA";
                cb_namaStaff.ValueMember = "ID_PEKERJA";

                query = $"SELECT ID_CUSTOMER, NAMA_CUSTOMER, NO_TELEPON_CUSTOMER, ALAMAT_CUSTOMER FROM CUSTOMER;";
                command = new MySqlCommand(query, connect);

                adapter = new MySqlDataAdapter(command);
                adapter.Fill(tabelCustomer);

                cb_statusLunas.Items.Add("Lunas");
                cb_statusLunas.Items.Add("Belum Lunas");

                cb_namaStaff.SelectedIndex = -1;
                cb_statusLunas.SelectedIndex = -1;

                cb_namaMenu.DataSource = tabelMenu;
                cb_namaMenu.DisplayMember = "Nama Produk";
                cb_namaMenu.ValueMember = "Harga Produk";

                cb_namaMenu.SelectedIndex = -1;

                cb_metodePembayaran.Items.Add("Transfer");
                cb_metodePembayaran.Items.Add("Cash");

                cb_metodePembayaran.SelectedIndex = -1;

                dgv_menu.DataSource = tabelMenu;
                dgv_menu.ClearSelection();

                dgv_menu.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        int ongkosKirim = 0;

        private void total()
        {
            try
            {
                int ongkir = 0;

                if (tb_ongkir.Text.Length == 0)
                {
                    ongkir = 0;
                }
                else
                {
                    ongkir = Convert.ToInt32(tb_ongkir.Text);
                }

                int sum = 0;

                for (int i = 0; i < tabelPesanan.Rows.Count; i++)
                {
                    string totalPrice = tabelPesanan.Rows[i][3].ToString();

                    if (totalPrice.StartsWith("Rp"))
                    {
                        totalPrice = totalPrice.Substring(2); 
                    }

                    sum += Convert.ToInt32(totalPrice);
                }

                ongkosKirim = ongkir;
                sum += ongkir;


                lb_totalPesanan.Text = "Rp" + sum.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_continue_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_namaCustomer.Text != "" && tb_noTelp.Text != "" && cb_namaStaff.SelectedItem != null && cb_statusLunas.SelectedItem != null && tabelPesanan.Rows.Count > 0 && cb_metodePembayaran.SelectedItem != null)
                {
                    int index = 0;

                    string idCustomer = tb_namaCustomer.Text.Substring(0, 2).ToUpper() + tb_noTelp.Text;

                    bool customerAda = false;

                    bool ada = false;

                    if (tb_alamat.Text == null)
                    {
                        tb_alamat.Text = "";
                    }
                    for (int i = 0; i < tabelCustomer.Rows.Count; i++)
                    {
                        if (tabelCustomer.Rows[i][1].ToString() != tb_namaCustomer.Text && tabelCustomer.Rows[i][2].ToString() == tb_noTelp.Text)
                        {
                            MessageBox.Show("Nomor telepon telah terdaftar dengan nama yang berbeda", "Error");
                            tb_noTelp.Text = "";
                            tb_namaCustomer.Text = "";
                            tb_alamat.Text = "";

                            ada = true;
                            break;
                        }
                    }

                    if (!ada)
                    {
                        for (int i = 0; i < tabelCustomer.Rows.Count; i++)
                        {
                            if (tabelCustomer.Rows[i][0].ToString() == idCustomer && tabelCustomer.Rows[i][1].ToString() == tb_namaCustomer.Text && tabelCustomer.Rows[i][2].ToString() == tb_noTelp.Text)
                            {
                                index = i;
                                customerAda = true;
                                break;
                            }

                        }

                        if (!customerAda)
                        {
                            query = $"INSERT INTO CUSTOMER VALUES ('{idCustomer}', '{tb_namaCustomer.Text}', '{tb_noTelp.Text}', '{tb_alamat.Text}', 'F');";
                            command = new MySqlCommand(query, connect);
                            command.ExecuteNonQuery();
                        }
                        else
                        {
                            if (tabelCustomer.Rows[index][3].ToString() == tb_alamat.Text)
                            {

                            }
                            else
                            {
                                query = $"UPDATE CUSTOMER SET ALAMAT_CUSTOMER = '{tb_alamat.Text}' WHERE ID_CUSTOMER = '{idCustomer}';";
                                command = new MySqlCommand(query, connect);
                                command.ExecuteNonQuery();
                            }
                        }

                        // ID pemesanan
                        string year = (DateTime.Now.Year % 100).ToString("D2");
                        string month = DateTime.Now.Month.ToString("D2");
                        string day = DateTime.Now.Day.ToString("D2");

                        string idPemesanan = year + month + day + idCustomer;
                   
                        // tanggal PO
                        DateTime tglPO = dtp_tglPO.Value;

                        // tanggal kirim
                        string tglKirim = year + '-' + month + '-' + day;

                        for (int i = 0; i < tabelPemesanan.Rows.Count; i++)
                        {
                            if (tabelPemesanan.Rows[i][0].ToString() == idPemesanan)
                            {
                                query = $"DELETE FROM DETAIL_PEMESANAN WHERE ID_PEMESANAN = '{idPemesanan}';";
                                command = new MySqlCommand(query, connect);
                                command.ExecuteNonQuery();

                                query = $"DELETE FROM PEMESANAN WHERE ID_PEMESANAN = '{idPemesanan}';";
                                command = new MySqlCommand(query, connect);
                                command.ExecuteNonQuery();
                            }
                        }

                        bool lunas = false;

                        if (cb_statusLunas.SelectedItem.ToString() == "Lunas")
                        {
                            lunas = true;
                        }
                        else if (cb_statusLunas.SelectedItem.ToString() == "Belum Lunas")
                        {
                            lunas = false;
                        }

                        //baru
                        query = $"INSERT INTO PEMESANAN VALUES ('null', '{idCustomer}', '{cb_namaStaff.SelectedValue.ToString()}', '{tglPO.ToString("yyyy-MM-dd")}', '{DateTime.Now.ToString("yyyy-MM-dd")}', {Convert.ToInt32(ongkosKirim)}, {Convert.ToInt32(lb_totalPesanan.Text.Substring(2))}, '{tb_alamat.Text}', '{cb_metodePembayaran.Text}', {lunas}, 'F');";
                        command = new MySqlCommand(query, connect);
                        command.ExecuteNonQuery();

                        DataTable idPesanan = new DataTable();
                        query = $"select id_pemesanan from PEMESANAN where id_customer = '{idCustomer}' and biaya_pesanan = {Convert.ToInt32(lb_totalPesanan.Text.Substring(2))};";
                        command = new MySqlCommand(query, connect);
                        adapter = new MySqlDataAdapter(command);
                        adapter.Fill(idPesanan);

                        for (int i = 0; i < tabelPesanan.Rows.Count; i++)
                        {
                            for (int j = 0; j < tabelMenu.Rows.Count; j++)
                            {
                                if (tabelMenu.Rows[j][1].ToString() == tabelPesanan.Rows[i][0].ToString())
                                {
                                    string idMenu = tabelMenu.Rows[j][0].ToString();
                                    int hrgMenu = Convert.ToInt32(tabelMenu.Rows[j][2]);
                                    int qtyMenu = Convert.ToInt32(tabelPesanan.Rows[i][2]);
                                    string idDetailPemesanan = idPemesanan + "-" + idMenu;

                                    query = $"INSERT INTO DETAIL_PEMESANAN (ID_DETAIL_PEMESANAN, ID_PEMESANAN, ID_PRODUK, QTY, HARGA_PCS) VALUES ('null', '{idPesanan.Rows[0][0]}', '{idMenu}', {qtyMenu}, {hrgMenu});";
                                    command = new MySqlCommand(query, connect);
                                    command.ExecuteNonQuery();
                                }
                            }
                        }
                    }

                    MessageBox.Show("Pemesanan berhasil di-input");

                    tb_namaCustomer.Clear();
                    tb_noTelp.Clear();
                    tb_alamat.Clear();
                    cb_namaStaff.SelectedIndex = -1;
                    cb_statusLunas.SelectedIndex = -1;
                    tabelPesanan.Clear();
                    lb_totalPesanan.Text = "Total ";
                    tb_ongkir.Clear();
                    cb_metodePembayaran.SelectedIndex = -1;
                }
                else
                {
                    MessageBox.Show("Silakan lengkapi data");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tb_ongkir_TextChanged(object sender, EventArgs e)
        {
            try
            {
                total();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tb_noTelp_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tb_ongkir_KeyPress(object sender, KeyPressEventArgs e)
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
                if (dgv_pesanan.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Pilih produk yang mau dihapus terlebih dahulu", "Error");
                }
                else
                {
                    int indexRow = dgv_pesanan.CurrentCell.RowIndex;

                    tabelPesanan.Rows.RemoveAt(indexRow);
                }

                dgv_pesanan.ClearSelection();
                total();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tb_noTelp_TextChanged(object sender, EventArgs e)
        {
            try
            {
                isiAlamat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }           
        }

        private void tb_namaCustomer_TextChanged(object sender, EventArgs e)
        {
            //isiAlamat();
        }

        private void isiAlamat()
        {
            try
            {
                bool cek = false;
                string alamat = "";
                string namaCustomer = "";

                for (int i = 0; i < tabelCustomer.Rows.Count; i++)
                {
                    if (tabelCustomer.Rows[i][2].ToString() == tb_noTelp.Text)
                    {
                        namaCustomer = tabelCustomer.Rows[i][1].ToString();
                        alamat = tabelCustomer.Rows[i][3].ToString();
                        cek = true;
                        break;
                    }
                }

                if (cek)
                {
                    tb_namaCustomer.Text = namaCustomer;
                    tb_alamat.Text = alamat;
                }
                else
                {
                    if (tb_namaCustomer.Text != "" || tb_alamat.Text != "")
                    {
                    }
                    else
                    {
                        tb_alamat.Text = "";
                        tb_namaCustomer.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
          
        }

        private void cb_namaMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_namaMenu.SelectedIndex != -1)
                {
                    lb_angkaHrg.Text = "Rp" + cb_namaMenu.SelectedValue.ToString();

                    btn_plus.Enabled = true;
                    btn_minus.Enabled = true;
                    tb_qty.Enabled = true;

                    for (int i = 0; i < tabelPesanan.Rows.Count; i++)
                    {
                        if (tabelPesanan.Rows[i][0].ToString() == cb_namaMenu.Text)
                        {
                            tb_qty.Text = tabelPesanan.Rows[i][2].ToString();
                            count = Convert.ToInt32(tb_qty.Text);
                            break;
                        }
                    }

                }
                else
                {
                    lb_angkaHrg.Text = "";
                    btn_plus.Enabled = false;
                    btn_minus.Enabled = false;
                    tb_qty.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        int count = 0;
        private void btn_plus_Click(object sender, EventArgs e)
        {
            try
            {
                count++;

                tb_qty.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            try
            {
                if (count > 0)
                {
                    count--;
                }

                tb_qty.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tb_qty_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (tb_qty.Text != "")
                {
                    count = Convert.ToInt32(tb_qty.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_namaMenu.SelectedIndex != -1)
                {
                    if (tb_qty.Text != "")
                    {
                        bool exist = false;

                        count = Convert.ToInt32(tb_qty.Text);

                        for (int i = 0; i < tabelPesanan.Rows.Count; i++)
                        {
                            if (tabelPesanan.Rows[i][0].ToString() == cb_namaMenu.Text)
                            {
                                exist = true;
                              
                                if (tb_qty.Text == "0")
                                {
                                    tabelPesanan.Rows.RemoveAt(i);
                                }
                                else
                                {
                                    tabelPesanan.Rows[i][2] = tb_qty.Text;
                                    tabelPesanan.Rows[i][3] = Convert.ToInt32(tabelPesanan.Rows[i][2]) * Convert.ToInt32(tabelPesanan.Rows[i][1]);
                                }

                                break;
                            }
                        }

                        if (!exist)
                        {
                            if (tb_qty.Text != "0")
                            {
                                tabelPesanan.Rows.Add(cb_namaMenu.Text, Convert.ToInt32(cb_namaMenu.SelectedValue.ToString()), Convert.ToInt32(tb_qty.Text), Convert.ToInt32(cb_namaMenu.SelectedValue.ToString()) * Convert.ToInt32(tb_qty.Text));
                            }
                        }

                        total();
                    }
                    else
                    {
                        MessageBox.Show("Quantity tidak valid", "Error");
                    }
                }
                else
                {
                    MessageBox.Show("Pilih menu terlebih dahulu", "Error");
                }

                dgv_pesanan.DataSource = tabelPesanan;
                tb_qty.Clear();
                count = 0;
                cb_namaMenu.SelectedIndex = -1;
                dgv_pesanan.ClearSelection();
                dgv_menu.ClearSelection();

                dgv_pesanan.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_pesanan.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_pesanan.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void tb_qty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void cb_namaStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dgv_pesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_pesanan.CurrentRow != null)
                {
                    DataGridViewRow selectedProduk = dgv_pesanan.CurrentRow;

                    cb_namaMenu.Text = selectedProduk.Cells[0].Value.ToString();

                    tb_qty.Enabled = true;
                    btn_plus.Enabled = true;
                    btn_minus.Enabled = true;

                    tb_qty.Text = selectedProduk.Cells[2].Value.ToString();


                    //dgv_pesanan.ClearSelection();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgv_menu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_menu.CurrentRow != null)
                {
                    DataGridViewRow selectedMenu = dgv_menu.CurrentRow;

                    cb_namaMenu.Text = selectedMenu.Cells[1].Value.ToString();

                    for (int i = 0; i < tabelPesanan.Rows.Count; i++)
                    {
                        if (tabelPesanan.Rows[0][i].ToString() == cb_namaMenu.Text)
                        {
                            tb_qty.Text = tabelPesanan.Rows[2][i].ToString();

                            break;
                        }
                        else
                        {
                            tb_qty.Text = "";

                            tb_qty.Enabled = true;
                            btn_plus.Enabled = true;
                            btn_minus.Enabled = true;
                        }
                    }
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

        private void btn_riwayat_Click(object sender, EventArgs e)
        {
            try
            {
                FormHistory formHistory = new FormHistory(formLogin, connect, tabelPemesanan, this, tabelMenu, tabelStaff);
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
                FormSales formSales = new FormSales(formLogin, connect, tabelPemesanan, this, tabelMenu, tabelStaff);
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
