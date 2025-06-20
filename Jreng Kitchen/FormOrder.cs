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


namespace Jreng_Kitchen
{
    public partial class FormPesanan : Form
    {
        FormLogin formLogin;

        DataTable tabelPesanan = new DataTable();

        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;

        string query;

        public FormPesanan(FormLogin fLogin, MySqlConnection conn)
        {
            InitializeComponent();
            connect = conn;
            fLogin = formLogin;


        }
        private void FormPesanan_Load(object sender, EventArgs e)
        {
            tabelPesanan.Columns.Add("Nama Produk");
            tabelPesanan.Columns.Add("Harga Per Produk");
            tabelPesanan.Columns.Add("Qty");
            tabelPesanan.Columns.Add("Harga Produk");
        }

        int count = 0;
        int hrg_M01 = 16000;
        private void btn_addM01_Click(object sender, EventArgs e)
        {
            //query = $"SELECT ID_PRODUK, NAMA_PRODUK, HARGA_PRODUK FROM PRODUK;";
            //command = new MySqlCommand(query, connect);

            //adapter = new MySqlDataAdapter(command);
            //adapter.Fill(tabelPesanan);

            //dgv_pesanan.DataSource = tabelPesanan;

            tabelPesanan.Clear();

            count++;

            M01();
        }

        private void btn_minM01_Click(object sender, EventArgs e)
        {
            tabelPesanan.Clear();

            count--;

            M01();
        }

        private void M01()
        {
            if (count > 0)
            {
                int currHarga = hrg_M01 * count;

                tabelPesanan.Rows.Add(lb_M01.Text, lb_hrgM01.Text, count, currHarga.ToString());

                dgv_pesanan.DataSource = tabelPesanan;
            }
            else
            {
                count = 0;
            }
            
        }
    }
}
