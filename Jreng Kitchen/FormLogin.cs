using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Server;
using MySql.Data.MySqlClient;

namespace Jreng_Kitchen
{
    public partial class FormLogin : Form
    {
        FormPesanan formPesanan;
        FormHistory formHistory;
        FormSales formSales;

        DataTable dataPemesanan = new DataTable();
        DataTable dataMenu = new DataTable();
        DataTable dataStaff = new DataTable();
        public FormLogin()
        {
            InitializeComponent();

            timer.Interval = 3000;
            timer.Start();

            this.BackgroundImage = null;
         
            lb_ddmmyyyy.Visible = false;
            lb_hhmm.Visible = false;
            btn_penjualan.Visible = false;
            btn_pesan.Visible = false;
            btn_riwayat.Visible = false;
            btn_pesan.Visible = false;
            btn_produk.Visible = false;
            panel_datetime.Visible = false;
            panel_jmlPesanan.Visible = false;
            panel_pesananBerjalan.Visible = false;
        }


        public MySqlConnection MySqlConnection;
        public string activeUser;
        
        MySqlCommand command = new MySqlCommand();
        MySqlDataAdapter adapter = new MySqlDataAdapter();

        string query;
        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection = new MySqlConnection("server = localhost; uid = root; pwd = ; database = alp_jrengkitchen");
                MySqlConnection.Open();

                CultureInfo culture = new CultureInfo("id-ID");

                lb_ddmmyyyy.Text = DateTime.Now.ToString($"dddd, dd/MM/yyyy", culture);

                lb_hhmm.Text = DateTime.Now.ToString("HH:mm");

                query = $"SELECT * FROM VDAFTARPEMESANAN";
                //query = $"SELECT PS.ID_PEMESANAN AS 'ID Pemesanan', C.NAMA_CUSTOMER AS 'Nama Customer', P.NAMA_PEKERJA AS 'Nama Staff', PS.TANGGAL_PO AS 'Tanggal PO', PS.TANGGAL_KIRIM AS 'Tanggal Kirim', PS.BIAYA_PESANAN AS 'Total' FROM PEMESANAN PS JOIN CUSTOMER C ON PS.ID_CUSTOMER = C.ID_CUSTOMER JOIN PEKERJA P ON PS.ID_PEKERJA = P.ID_PEKERJA;";
                command = new MySqlCommand(query, MySqlConnection);

                adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataPemesanan);
                
                query = $"SELECT * FROM VDAFTARPRODUKAVAIL";
                //query = $"SELECT ID_PRODUK AS 'ID Produk', NAMA_PRODUK AS 'Nama Produk', HARGA_PRODUK AS 'Harga Produk' FROM PRODUK WHERE STATUS_DEL = 'F';";
                command = new MySqlCommand(query, MySqlConnection);

                adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataMenu);

                query = $"SELECT ID_PEKERJA, NAMA_PEKERJA, NO_TELEPON_PEKERJA FROM PEKERJA;";
                command = new MySqlCommand(query, MySqlConnection);

                adapter = new MySqlDataAdapter(command);
                adapter.Fill(dataStaff);

                query = $"SELECT * FROM VTOTALPESANANWA";
                //query = $"SELECT COUNT(ID_PEMESANAN) FROM PEMESANAN WHERE LEFT(TANGGAL_KIRIM, 7) = '{DateTime.Now.ToString("yyyy")}-{DateTime.Now.Month}';";
                command = new MySqlCommand(query, MySqlConnection);

                lb_jml.Text = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                timer.Stop();

                this.BackgroundImage = Properties.Resources.Home_Page;

                pb_logo.Visible = false;
                lb_ddmmyyyy.Visible = true;
                lb_hhmm.Visible = true;
                btn_penjualan.Visible = true;
                btn_pesan.Visible = true;
                btn_riwayat.Visible = true;
                btn_pesan.Visible = true;
                btn_produk.Visible = true;
                panel_datetime.Visible = true;
                panel_jmlPesanan.Visible = true;
                panel_pesananBerjalan.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            } 
        }

        private void btn_pesanan_Click(object sender, EventArgs e)
        {
            try
            {
                FormPesanan formPesanan = new FormPesanan(this, MySqlConnection, dataPemesanan, formHistory, dataMenu, dataStaff);
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
                FormProduk formProduk = new FormProduk(this, MySqlConnection, dataMenu, dataPemesanan, formHistory, dataStaff);
                this.Hide();

                formProduk.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_history_Click(object sender, EventArgs e)
        {
            try
            {
                FormHistory formHistory = new FormHistory(this, MySqlConnection, dataPemesanan, formPesanan, dataMenu, dataStaff);
                this.Hide();

                formHistory.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_sales_Click(object sender, EventArgs e)
        {
            try
            {
                FormSales formSales = new FormSales(this, MySqlConnection, dataPemesanan, formPesanan, dataMenu, dataStaff);
                this.Hide();

                formSales.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            // form ini
        }

        private void panel_pesananBerjalan_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 20; 

            Rectangle rect = new Rectangle(0, 0, panel_pesananBerjalan.Width - 1, panel_pesananBerjalan.Height - 1);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            panel_pesananBerjalan.Region = new Region(path);

            path.Dispose();
        }

        private void panel_jmlPesanan_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 20; 

            Rectangle rect = new Rectangle(0, 0, panel_jmlPesanan.Width - 1, panel_jmlPesanan.Height - 1);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            panel_jmlPesanan.Region = new Region(path);

            path.Dispose();
        }

        private void panel_datetime_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 20; 

            Rectangle rect = new Rectangle(0, 0, panel_datetime.Width - 1, panel_datetime.Height - 1);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            panel_datetime.Region = new Region(path);

            path.Dispose();
        }
    }
}
