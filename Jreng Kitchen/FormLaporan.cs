using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jreng_Kitchen
{
    public partial class btn_penjual : Form
    {
        string bulan = "";
        string tahun = "";
        int bulanInt = 0;

        MySqlConnection connect;
        MySqlCommand command;
        MySqlDataAdapter adapter;

        string query;

        DataTable tabelLaporan = new DataTable();
        DataTable tabelBestSeller = new DataTable();
        DataTable tabelPemesanan;
        DataTable tabelMenu;
        DataTable tabelStaff;
        

        FormSales formSales;
        FormLogin formLogin;
        FormPesanan formPesanan;
        FormHistory formHistory;
        FormProduk formProduk;

        public btn_penjual(FormLogin fLogin, FormSales fSales, FormPesanan fPesanan, FormHistory fHistory, FormProduk fProduk, MySqlConnection conn, string cbBulan, string tbTahun, int cbBulanInt, DataTable dtPemesanan, DataTable dtMenu, DataTable dtStaff)
        {
            InitializeComponent();

            formLogin = (FormLogin)fLogin;
            formSales = fSales;
            formPesanan = fPesanan;
            formHistory = fHistory;
            formProduk = fProduk;
            bulan = cbBulan;
            tahun = tbTahun;
            bulanInt = cbBulanInt;
            connect = conn;
            tabelPemesanan = dtPemesanan;
            tabelMenu = dtMenu;
            tabelStaff = dtStaff;
        }

        private void FormLaporan_Load(object sender, EventArgs e)
        {
            try
            {
                lb_bulanTahun.Text = bulan + " " + tahun;

                tabelLaporan.Columns.Add("Merchant");
                tabelLaporan.Columns.Add("Total Pendapatan");
                tabelLaporan.Columns.Add("Pajak");
                tabelLaporan.Columns.Add("Biaya Admin");

                tabelLaporan.Rows.Add();
                tabelLaporan.Rows.Add();
                tabelLaporan.Rows.Add();
                tabelLaporan.Rows.Add();

                tabelLaporan.Rows[0][0] = "Gojek";
                tabelLaporan.Rows[1][0] = "Grab";
                tabelLaporan.Rows[2][0] = "Shopee";
                tabelLaporan.Rows[3][0] = "WhatsApp";

                string bulanStr = bulanInt.ToString("D2");

                //Total Pendapatan
                query = $"SELECT TOTAL_PENDAPATAN FROM PENJUALAN_ONLINE WHERE ID_PENJUALAN = 'GO{tahun}{bulanStr}';";
                command = new MySqlCommand(query, connect);

                tabelLaporan.Rows[0][1] = command.ExecuteScalar();

                query = $"SELECT TOTAL_PENDAPATAN FROM PENJUALAN_ONLINE WHERE ID_PENJUALAN = 'GR{tahun}{bulanStr}';";
                command = new MySqlCommand(query, connect);

                tabelLaporan.Rows[1][1] = command.ExecuteScalar();

                query = $"SELECT TOTAL_PENDAPATAN FROM PENJUALAN_ONLINE WHERE ID_PENJUALAN = 'SH{tahun}{bulanStr}';";
                command = new MySqlCommand(query, connect);

                tabelLaporan.Rows[2][1] = command.ExecuteScalar();

                //Pajak
                query = $"SELECT PAJAK FROM PENJUALAN_ONLINE WHERE ID_PENJUALAN = 'GO{tahun}{bulanStr}';";
                command = new MySqlCommand(query, connect);

                tabelLaporan.Rows[0][2] = command.ExecuteScalar();

                query = $"SELECT PAJAK FROM PENJUALAN_ONLINE WHERE ID_PENJUALAN = 'GR{tahun}{bulanStr}';";
                command = new MySqlCommand(query, connect);

                tabelLaporan.Rows[1][2] = command.ExecuteScalar();

                query = $"SELECT PAJAK FROM PENJUALAN_ONLINE WHERE ID_PENJUALAN = 'SH{tahun}{bulanStr}';";
                command = new MySqlCommand(query, connect);

                tabelLaporan.Rows[2][2] = command.ExecuteScalar();

                //Biaya Admin
                query = $"SELECT BIAYA_ADMIN FROM PENJUALAN_ONLINE WHERE ID_PENJUALAN = 'GO{tahun}{bulanStr}';";
                command = new MySqlCommand(query, connect);

                tabelLaporan.Rows[0][3] = command.ExecuteScalar();

                query = $"SELECT BIAYA_ADMIN FROM PENJUALAN_ONLINE WHERE ID_PENJUALAN = 'GR{tahun}{bulanStr}';";
                command = new MySqlCommand(query, connect);

                tabelLaporan.Rows[1][3] = command.ExecuteScalar();

                query = $"SELECT BIAYA_ADMIN FROM PENJUALAN_ONLINE WHERE ID_PENJUALAN = 'SH{tahun}{bulanStr}';";
                command = new MySqlCommand(query, connect);

                tabelLaporan.Rows[2][3] = command.ExecuteScalar();

                //WhatsApp
                query = $"SELECT SUM(BIAYA_PESANAN) - SUM(BIAYA_ONGKOS_KIRIM) FROM PEMESANAN WHERE LEFT(TANGGAL_KIRIM, 7) = '{tahun}-{bulanStr}';";
                command = new MySqlCommand(query, connect);

                tabelLaporan.Rows[3][1] = command.ExecuteScalar();

                dgv_laporan.DataSource = tabelLaporan;

                dgv_laporan.ClearSelection();

                dgv_laporan.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_laporan.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                dgv_laporan.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                int maxPendapatan = 0;
                int maxPotongan = 0;

                for (int i = 0; i < tabelLaporan.Rows.Count; i++)
                {
                    int pendapatan = 0;

                    if (tabelLaporan.Rows[i][1].ToString() == "")
                    {
                        pendapatan = 0;
                    }
                    else
                    {
                        pendapatan = Convert.ToInt32(tabelLaporan.Rows[i][1]);
                    }

                    if (pendapatan > maxPendapatan)
                    {
                        maxPendapatan = pendapatan;
                        lb_hasilBestMerchant.Text = tabelLaporan.Rows[i][0].ToString() + " " + maxPendapatan.ToString();
                    }

                    int pajak = 0;
                    int biayaAdmin = 0;

                    if (tabelLaporan.Rows[i][2].ToString() == "")
                    {
                        pajak = 0;
                    }
                    else
                    {
                        pajak = Convert.ToInt32(tabelLaporan.Rows[i][2]);
                    }

                    if (tabelLaporan.Rows[i][3].ToString() == "")
                    {
                        biayaAdmin = 0;
                    }
                    else
                    {
                        biayaAdmin = Convert.ToInt32(tabelLaporan.Rows[i][3]);
                    }

                    int potongan = pajak + biayaAdmin;


                    if (potongan > maxPotongan)
                    {
                        maxPotongan = potongan;
                        lb_hasilPotonganTerbanyak.Text = tabelLaporan.Rows[i][0].ToString() + " " + maxPotongan.ToString();
                    }
                }

                query = $"SELECT fHitungTotalPenjualan({tahun}, {bulanStr});";
                command = new MySqlCommand(query, connect);
                lb_hasilAkumulasi.Text = command.ExecuteScalar().ToString();

                query = $"SELECT COUNT(ID_PEMESANAN) FROM PEMESANAN WHERE LEFT(TANGGAL_KIRIM, 7) = '{tahun}-{bulanStr}';";
                command = new MySqlCommand(query, connect);

                //MessageBox.Show(command.ExecuteScalar().ToString());
                lb_hasilPesananWA.Text = command.ExecuteScalar().ToString();

                //query = $"SELECT P.NAMA_PRODUK, SUM(DP.QTY) FROM PRODUK P JOIN DETAIL_PEMESANAN DP ON P.ID_PRODUK = DP.ID_PRODUK JOIN PEMESANAN PE ON DP.ID_PEMESANAN = PE.ID_PEMESANAN WHERE LEFT(PE.TANGGAL_KIRIM, 7) = '{tahun}-{bulanStr}' GROUP BY P.ID_PRODUK ORDER BY SUM(DP.QTY) DESC LIMIT 5;";
                query = $"CALL PBESTSELLER ('{tahun}', {bulanStr});";
                command = new MySqlCommand(query, connect);

                adapter = new MySqlDataAdapter(command);

                adapter.Fill(tabelBestSeller);

                lb_menu1.Text = tabelBestSeller.Rows[0][0].ToString() + " (" + tabelBestSeller.Rows[0][1].ToString() + ")";

                if (tabelBestSeller.Rows.Count > 1)
                {
                    lb_menu2.Text = tabelBestSeller.Rows[1][0].ToString() + " (" + tabelBestSeller.Rows[1][1].ToString() + ")";

                    if (tabelBestSeller.Rows.Count > 2)
                    {
                        lb_menu3.Text = tabelBestSeller.Rows[2][0].ToString() + " (" + tabelBestSeller.Rows[2][1].ToString() + ")";

                        if (tabelBestSeller.Rows.Count > 3)
                        {
                            lb_menu4.Text = tabelBestSeller.Rows[3][0].ToString() + " (" + tabelBestSeller.Rows[3][1].ToString() + ")";
                            lb_menu5.Text = tabelBestSeller.Rows[4][0].ToString() + " (" + tabelBestSeller.Rows[4][1].ToString() + ")";
                        }
                    }
                }

                if (tabelBestSeller.Rows.Count == 1)
                {
                    panel_menu2.Visible = false;
                    panel_menu3.Visible = false;
                    panel_menu4.Visible = false;
                    panel1.Visible = false;

                    lb_menu2.Visible = false;
                    lb_menu3.Visible = false;
                    lb_menu4.Visible = false;
                    lb_menu5.Visible = false;

                    pb_rank2.Visible = false;
                    pb_rank3.Visible = false;
                }
                else if (tabelBestSeller.Rows.Count == 2)
                {
                    panel_menu3.Visible = false;
                    panel_menu4.Visible = false;
                    panel1.Visible = false;

                    lb_menu3.Visible = false;
                    lb_menu4.Visible = false;
                    lb_menu5.Visible = false;

                    pb_rank3.Visible = false;
                }
                else if (tabelBestSeller.Rows.Count == 3)
                {
                    panel_menu4.Visible = false;
                    panel1.Visible = false;

                    lb_menu4.Visible = false;
                    lb_menu5.Visible = false;
                }
                else if (tabelBestSeller.Rows.Count == 4)
                {
                    panel1.Visible = false;

                    lb_menu5.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                formSales.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btn_beranda_Click_1(object sender, EventArgs e)
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

        private void btn_pesan_Click_1(object sender, EventArgs e)
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

        private void btn_produk_Click_1(object sender, EventArgs e)
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

        private void btn_riwayat_Click_1(object sender, EventArgs e)
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

        private void btn_penjualan_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                formSales.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void panel_bestMerchant_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 20; 

            Rectangle rect = new Rectangle(0, 0, panel_bestMerchant.Width - 1, panel_bestMerchant.Height - 1);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            panel_bestMerchant.Region = new Region(path);

            path.Dispose();
        }

        private void panel_potonganTerbanyak_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 20; 

            Rectangle rect = new Rectangle(0, 0, panel_potonganTerbanyak.Width - 1, panel_potonganTerbanyak.Height - 1);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            panel_potonganTerbanyak.Region = new Region(path);

            path.Dispose();
        }

        private void panel_akumulasi_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 20; 

            Rectangle rect = new Rectangle(0, 0, panel_akumulasi.Width - 1, panel_akumulasi.Height - 1);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            panel_akumulasi.Region = new Region(path);

            path.Dispose();
        }

        private void panel_menu1_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 30; 

            Rectangle rect = new Rectangle(0, 0, panel_menu1.Width - 1, panel_menu1.Height - 1);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            panel_menu1.Region = new Region(path);

            path.Dispose();
        }

        private void panel_menu2_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 30;

            Rectangle rect = new Rectangle(0, 0, panel_menu2.Width - 1, panel_menu2.Height - 1);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            panel_menu2.Region = new Region(path);

            path.Dispose();
        }

        private void panel_menu3_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 30; 

            Rectangle rect = new Rectangle(0, 0, panel_menu3.Width - 1, panel_menu3.Height - 1);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90);
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            panel_menu3.Region = new Region(path);

            path.Dispose();
        }

        private void panel_menu4_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 30; 

            Rectangle rect = new Rectangle(0, 0, panel_menu4.Width - 1, panel_menu4.Height - 1);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            panel_menu4.Region = new Region(path);

            path.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 30; 

            Rectangle rect = new Rectangle(0, 0, panel1.Width - 1, panel1.Height - 1);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            panel1.Region = new Region(path);

            path.Dispose();
        }

        private void panel_pesananWA_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 20; 

            Rectangle rect = new Rectangle(0, 0, panel_pesananWA.Width - 1, panel_pesananWA.Height - 1);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90);
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            panel_pesananWA.Region = new Region(path);

            path.Dispose();
        }

        private void panel_laporanPeriode_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 25;

            Rectangle rect = new Rectangle(0, 0, panel_laporanPeriode.Width - 1, panel_laporanPeriode.Height - 1);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            panel_laporanPeriode.Region = new Region(path);

            path.Dispose();
        }

        private void panel_hasilBestMerchant_Paint(object sender, PaintEventArgs e)
        {
            int cornerRadius = 20;

            Rectangle rect = new Rectangle(0, 0, panel_hasilBestMerchant.Width - 1, panel_hasilBestMerchant.Height - 1);

            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.Left, rect.Top, cornerRadius, cornerRadius, 180, 90); 
            path.AddArc(rect.Right - cornerRadius, rect.Top, cornerRadius, cornerRadius, 270, 90);
            path.AddArc(rect.Right - cornerRadius, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 0, 90); 
            path.AddArc(rect.Left, rect.Bottom - cornerRadius, cornerRadius, cornerRadius, 90, 90); 
            path.CloseFigure();

            panel_hasilBestMerchant.Region = new Region(path);

            path.Dispose();
        }
    }
}
