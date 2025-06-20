using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Jreng_Kitchen
{
    public partial class FormPassword : Form
    {
        FormSales formSales;
        FormLogin formLogin;
        FormPesanan formPesanan;
        FormHistory formHistory;
        FormProduk formProduk;

        string bulan = "";
        string tahun = "";
        int bulanInt = 0;

        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;

        DataTable tabelPemesanan;
        DataTable tabelMenu;
        DataTable tabelStaff;

        string query;

        public FormPassword(FormLogin fLogin, FormSales fSales, FormHistory fHistory, FormProduk fProduk, MySqlConnection conn, string cbBulan, string tbTahun, int cbBulanInt, DataTable dtPemesanan, FormPesanan fPesanan, DataTable dtMenu, DataTable dtStaff)
        {
            InitializeComponent();

            formLogin = (FormLogin)fLogin;
            formSales = fSales;
            formHistory = fHistory;
            formProduk = fProduk;
            bulan = cbBulan;
            tahun = tbTahun;
            bulanInt = cbBulanInt;
            connect = conn;
            tabelPemesanan = dtPemesanan;
            formPesanan = fPesanan;
            tabelMenu = dtMenu;
            tabelStaff = dtStaff;
        }

        private void btn_masuk_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_password.Text == "")
                {
                    MessageBox.Show("Password belum diisi", "Error");
                }
                else
                {
                    string key = "b14ca5898a4e4133bbce2ea2315a1916";
                    string str = "Bs592amqLnMk20d0AGVPvA==";
                    var encryptedString = AesOperation.DecryptString(key, str);

                    if (tb_password.Text == encryptedString)
                    {
                        MessageBox.Show("Berhasil masuk");

                        btn_penjual formLaporan = new btn_penjual(formLogin, formSales, formPesanan, formHistory, formProduk, connect, bulan, tahun, bulanInt, tabelPemesanan, tabelMenu, tabelStaff);
                        this.Hide();
                        formSales.Hide();

                        string bulanStr = bulanInt.ToString("D2");

                        query = $"SELECT COUNT(TOTAL_PENDAPATAN) FROM PENJUALAN_ONLINE WHERE RIGHT(ID_PENJUALAN, 6) = '{tahun}{bulanStr}';";
                        command = new MySqlCommand(query, connect);

                        if (command.ExecuteScalar().ToString() == "3")
                        {
                            formLaporan.Show();
                        }
                        else
                        {
                            MessageBox.Show($"Laporan {bulan} {tahun} tidak ditemukan", "Error");
                            MessageBox.Show("Kembali ke halaman sebelumnya");
                            formSales.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password salah. Silakan coba lagi", "Error");
                    }
                }

                tb_password.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormPassword_Load(object sender, EventArgs e)
        {
            tb_password.UseSystemPasswordChar = true;
        }

    }
}
