namespace Jreng_Kitchen
{
    partial class FormSales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_pendapatanMerchant = new System.Windows.Forms.Label();
            this.lb_namaStaff = new System.Windows.Forms.Label();
            this.lb_merchant = new System.Windows.Forms.Label();
            this.lb_totalPendapatan = new System.Windows.Forms.Label();
            this.lb_totalPesanan = new System.Windows.Forms.Label();
            this.lb_pajak = new System.Windows.Forms.Label();
            this.lb_biayaAdmin = new System.Windows.Forms.Label();
            this.lb_totalPotongan = new System.Windows.Forms.Label();
            this.tb_totalPendapatan = new System.Windows.Forms.TextBox();
            this.tb_totalPesanan = new System.Windows.Forms.TextBox();
            this.tb_pajak = new System.Windows.Forms.TextBox();
            this.tb_biayaAdmin = new System.Windows.Forms.TextBox();
            this.tb_totalPotongan = new System.Windows.Forms.TextBox();
            this.cb_merchant = new System.Windows.Forms.ComboBox();
            this.cb_namaStaff = new System.Windows.Forms.ComboBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_konfirmasi = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.btn_lihatLaporan = new System.Windows.Forms.Button();
            this.lb_bulanTahun = new System.Windows.Forms.Label();
            this.cb_bulan = new System.Windows.Forms.ComboBox();
            this.tb_tahun = new System.Windows.Forms.TextBox();
            this.dtp_tglInput = new System.Windows.Forms.DateTimePicker();
            this.lb_tglInput = new System.Windows.Forms.Label();
            this.dgv_penjualan = new System.Windows.Forms.DataGridView();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.tb_tahunLaporan = new System.Windows.Forms.TextBox();
            this.cb_bulanLaporan = new System.Windows.Forms.ComboBox();
            this.lb_tahun = new System.Windows.Forms.Label();
            this.lb_bulan = new System.Windows.Forms.Label();
            this.lb_atau = new System.Windows.Forms.Label();
            this.panel_laporan = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_beranda = new System.Windows.Forms.Button();
            this.btn_penjualan = new System.Windows.Forms.Button();
            this.btn_riwayat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_pesan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_penjualan)).BeginInit();
            this.panel_laporan.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_pendapatanMerchant
            // 
            this.lb_pendapatanMerchant.AutoSize = true;
            this.lb_pendapatanMerchant.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pendapatanMerchant.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.lb_pendapatanMerchant.Location = new System.Drawing.Point(286, 41);
            this.lb_pendapatanMerchant.Name = "lb_pendapatanMerchant";
            this.lb_pendapatanMerchant.Size = new System.Drawing.Size(544, 32);
            this.lb_pendapatanMerchant.TabIndex = 0;
            this.lb_pendapatanMerchant.Text = "Masukkan Detail Pendapatan Per Merchant";
            // 
            // lb_namaStaff
            // 
            this.lb_namaStaff.AutoSize = true;
            this.lb_namaStaff.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_namaStaff.Location = new System.Drawing.Point(287, 170);
            this.lb_namaStaff.Name = "lb_namaStaff";
            this.lb_namaStaff.Size = new System.Drawing.Size(117, 25);
            this.lb_namaStaff.TabIndex = 1;
            this.lb_namaStaff.Text = "Nama Staff  ";
            // 
            // lb_merchant
            // 
            this.lb_merchant.AutoSize = true;
            this.lb_merchant.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_merchant.Location = new System.Drawing.Point(287, 220);
            this.lb_merchant.Name = "lb_merchant";
            this.lb_merchant.Size = new System.Drawing.Size(108, 25);
            this.lb_merchant.TabIndex = 2;
            this.lb_merchant.Text = "Merchant  ";
            // 
            // lb_totalPendapatan
            // 
            this.lb_totalPendapatan.AutoSize = true;
            this.lb_totalPendapatan.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalPendapatan.Location = new System.Drawing.Point(285, 320);
            this.lb_totalPendapatan.Name = "lb_totalPendapatan";
            this.lb_totalPendapatan.Size = new System.Drawing.Size(168, 25);
            this.lb_totalPendapatan.TabIndex = 3;
            this.lb_totalPendapatan.Text = "Total Pendapatan";
            // 
            // lb_totalPesanan
            // 
            this.lb_totalPesanan.AutoSize = true;
            this.lb_totalPesanan.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalPesanan.Location = new System.Drawing.Point(287, 370);
            this.lb_totalPesanan.Name = "lb_totalPesanan";
            this.lb_totalPesanan.Size = new System.Drawing.Size(136, 25);
            this.lb_totalPesanan.TabIndex = 4;
            this.lb_totalPesanan.Text = "Total Pesanan";
            // 
            // lb_pajak
            // 
            this.lb_pajak.AutoSize = true;
            this.lb_pajak.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pajak.Location = new System.Drawing.Point(287, 420);
            this.lb_pajak.Name = "lb_pajak";
            this.lb_pajak.Size = new System.Drawing.Size(61, 25);
            this.lb_pajak.TabIndex = 5;
            this.lb_pajak.Text = "Pajak";
            // 
            // lb_biayaAdmin
            // 
            this.lb_biayaAdmin.AutoSize = true;
            this.lb_biayaAdmin.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_biayaAdmin.Location = new System.Drawing.Point(793, 320);
            this.lb_biayaAdmin.Name = "lb_biayaAdmin";
            this.lb_biayaAdmin.Size = new System.Drawing.Size(132, 25);
            this.lb_biayaAdmin.TabIndex = 6;
            this.lb_biayaAdmin.Text = "Biaya Admin ";
            // 
            // lb_totalPotongan
            // 
            this.lb_totalPotongan.AutoSize = true;
            this.lb_totalPotongan.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalPotongan.Location = new System.Drawing.Point(793, 370);
            this.lb_totalPotongan.Name = "lb_totalPotongan";
            this.lb_totalPotongan.Size = new System.Drawing.Size(146, 25);
            this.lb_totalPotongan.TabIndex = 7;
            this.lb_totalPotongan.Text = "Total Potongan";
            // 
            // tb_totalPendapatan
            // 
            this.tb_totalPendapatan.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalPendapatan.Location = new System.Drawing.Point(470, 317);
            this.tb_totalPendapatan.MaxLength = 9;
            this.tb_totalPendapatan.Name = "tb_totalPendapatan";
            this.tb_totalPendapatan.Size = new System.Drawing.Size(282, 32);
            this.tb_totalPendapatan.TabIndex = 8;
            this.tb_totalPendapatan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_totalPendapatan_KeyPress);
            // 
            // tb_totalPesanan
            // 
            this.tb_totalPesanan.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalPesanan.Location = new System.Drawing.Point(472, 367);
            this.tb_totalPesanan.MaxLength = 4;
            this.tb_totalPesanan.Name = "tb_totalPesanan";
            this.tb_totalPesanan.Size = new System.Drawing.Size(282, 32);
            this.tb_totalPesanan.TabIndex = 9;
            this.tb_totalPesanan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_totalPesanan_KeyPress);
            // 
            // tb_pajak
            // 
            this.tb_pajak.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pajak.Location = new System.Drawing.Point(470, 417);
            this.tb_pajak.MaxLength = 9;
            this.tb_pajak.Name = "tb_pajak";
            this.tb_pajak.Size = new System.Drawing.Size(282, 32);
            this.tb_pajak.TabIndex = 10;
            this.tb_pajak.TextChanged += new System.EventHandler(this.tb_pajak_TextChanged);
            this.tb_pajak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pajak_KeyPress);
            // 
            // tb_biayaAdmin
            // 
            this.tb_biayaAdmin.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_biayaAdmin.Location = new System.Drawing.Point(959, 317);
            this.tb_biayaAdmin.MaxLength = 9;
            this.tb_biayaAdmin.Name = "tb_biayaAdmin";
            this.tb_biayaAdmin.Size = new System.Drawing.Size(239, 32);
            this.tb_biayaAdmin.TabIndex = 11;
            this.tb_biayaAdmin.TextChanged += new System.EventHandler(this.tb_biayaAdmin_TextChanged);
            // 
            // tb_totalPotongan
            // 
            this.tb_totalPotongan.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_totalPotongan.Location = new System.Drawing.Point(959, 367);
            this.tb_totalPotongan.MaxLength = 9;
            this.tb_totalPotongan.Name = "tb_totalPotongan";
            this.tb_totalPotongan.Size = new System.Drawing.Size(239, 32);
            this.tb_totalPotongan.TabIndex = 12;
            // 
            // cb_merchant
            // 
            this.cb_merchant.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_merchant.FormattingEnabled = true;
            this.cb_merchant.Location = new System.Drawing.Point(472, 217);
            this.cb_merchant.Name = "cb_merchant";
            this.cb_merchant.Size = new System.Drawing.Size(282, 33);
            this.cb_merchant.TabIndex = 13;
            // 
            // cb_namaStaff
            // 
            this.cb_namaStaff.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_namaStaff.FormattingEnabled = true;
            this.cb_namaStaff.Location = new System.Drawing.Point(472, 167);
            this.cb_namaStaff.Name = "cb_namaStaff";
            this.cb_namaStaff.Size = new System.Drawing.Size(282, 33);
            this.cb_namaStaff.TabIndex = 14;
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_tambah.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.Location = new System.Drawing.Point(1176, 449);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(123, 43);
            this.btn_tambah.TabIndex = 15;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_konfirmasi
            // 
            this.btn_konfirmasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_konfirmasi.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_konfirmasi.Location = new System.Drawing.Point(1165, 714);
            this.btn_konfirmasi.Name = "btn_konfirmasi";
            this.btn_konfirmasi.Size = new System.Drawing.Size(136, 47);
            this.btn_konfirmasi.TabIndex = 20;
            this.btn_konfirmasi.Text = "Konfirmasi";
            this.btn_konfirmasi.UseVisualStyleBackColor = false;
            this.btn_konfirmasi.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_ubah.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ubah.Location = new System.Drawing.Point(1070, 714);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(87, 47);
            this.btn_ubah.TabIndex = 19;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = false;
            this.btn_ubah.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_lihatLaporan
            // 
            this.btn_lihatLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_lihatLaporan.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lihatLaporan.Location = new System.Drawing.Point(152, 101);
            this.btn_lihatLaporan.Name = "btn_lihatLaporan";
            this.btn_lihatLaporan.Size = new System.Drawing.Size(207, 47);
            this.btn_lihatLaporan.TabIndex = 21;
            this.btn_lihatLaporan.Text = "Lihat Laporan";
            this.btn_lihatLaporan.UseVisualStyleBackColor = false;
            this.btn_lihatLaporan.Click += new System.EventHandler(this.btn_lihatLaporan_Click);
            // 
            // lb_bulanTahun
            // 
            this.lb_bulanTahun.AutoSize = true;
            this.lb_bulanTahun.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bulanTahun.Location = new System.Drawing.Point(287, 270);
            this.lb_bulanTahun.Name = "lb_bulanTahun";
            this.lb_bulanTahun.Size = new System.Drawing.Size(146, 25);
            this.lb_bulanTahun.TabIndex = 40;
            this.lb_bulanTahun.Text = "Bulan / Tahun ";
            // 
            // cb_bulan
            // 
            this.cb_bulan.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bulan.FormattingEnabled = true;
            this.cb_bulan.Location = new System.Drawing.Point(470, 267);
            this.cb_bulan.Name = "cb_bulan";
            this.cb_bulan.Size = new System.Drawing.Size(172, 33);
            this.cb_bulan.TabIndex = 42;
            // 
            // tb_tahun
            // 
            this.tb_tahun.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tahun.Location = new System.Drawing.Point(674, 267);
            this.tb_tahun.MaxLength = 4;
            this.tb_tahun.Name = "tb_tahun";
            this.tb_tahun.Size = new System.Drawing.Size(80, 32);
            this.tb_tahun.TabIndex = 43;
            this.tb_tahun.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tahun_KeyPress);
            // 
            // dtp_tglInput
            // 
            this.dtp_tglInput.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_tglInput.Location = new System.Drawing.Point(472, 114);
            this.dtp_tglInput.Name = "dtp_tglInput";
            this.dtp_tglInput.Size = new System.Drawing.Size(282, 32);
            this.dtp_tglInput.TabIndex = 45;
            // 
            // lb_tglInput
            // 
            this.lb_tglInput.AutoSize = true;
            this.lb_tglInput.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tglInput.Location = new System.Drawing.Point(287, 120);
            this.lb_tglInput.Name = "lb_tglInput";
            this.lb_tglInput.Size = new System.Drawing.Size(140, 25);
            this.lb_tglInput.TabIndex = 44;
            this.lb_tglInput.Text = "Tanggal Input ";
            // 
            // dgv_penjualan
            // 
            this.dgv_penjualan.AllowUserToAddRows = false;
            this.dgv_penjualan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_penjualan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_penjualan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_penjualan.Location = new System.Drawing.Point(292, 509);
            this.dgv_penjualan.MultiSelect = false;
            this.dgv_penjualan.Name = "dgv_penjualan";
            this.dgv_penjualan.ReadOnly = true;
            this.dgv_penjualan.RowHeadersVisible = false;
            this.dgv_penjualan.RowHeadersWidth = 82;
            this.dgv_penjualan.RowTemplate.Height = 33;
            this.dgv_penjualan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_penjualan.Size = new System.Drawing.Size(1007, 184);
            this.dgv_penjualan.TabIndex = 46;
            this.dgv_penjualan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_penjualan_CellContentClick);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_hapus.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.Location = new System.Drawing.Point(292, 714);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(115, 50);
            this.btn_hapus.TabIndex = 47;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_tahunLaporan
            // 
            this.tb_tahunLaporan.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tahunLaporan.Location = new System.Drawing.Point(378, 22);
            this.tb_tahunLaporan.MaxLength = 4;
            this.tb_tahunLaporan.Name = "tb_tahunLaporan";
            this.tb_tahunLaporan.Size = new System.Drawing.Size(101, 32);
            this.tb_tahunLaporan.TabIndex = 51;
            this.tb_tahunLaporan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tahunLaporan_KeyPress);
            // 
            // cb_bulanLaporan
            // 
            this.cb_bulanLaporan.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_bulanLaporan.FormattingEnabled = true;
            this.cb_bulanLaporan.Location = new System.Drawing.Point(88, 22);
            this.cb_bulanLaporan.Name = "cb_bulanLaporan";
            this.cb_bulanLaporan.Size = new System.Drawing.Size(185, 33);
            this.cb_bulanLaporan.TabIndex = 50;
            // 
            // lb_tahun
            // 
            this.lb_tahun.AutoSize = true;
            this.lb_tahun.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tahun.Location = new System.Drawing.Point(299, 25);
            this.lb_tahun.Name = "lb_tahun";
            this.lb_tahun.Size = new System.Drawing.Size(68, 25);
            this.lb_tahun.TabIndex = 49;
            this.lb_tahun.Text = "Tahun";
            // 
            // lb_bulan
            // 
            this.lb_bulan.AutoSize = true;
            this.lb_bulan.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_bulan.Location = new System.Drawing.Point(15, 25);
            this.lb_bulan.Name = "lb_bulan";
            this.lb_bulan.Size = new System.Drawing.Size(65, 25);
            this.lb_bulan.TabIndex = 48;
            this.lb_bulan.Text = "Bulan";
            // 
            // lb_atau
            // 
            this.lb_atau.AutoSize = true;
            this.lb_atau.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_atau.Location = new System.Drawing.Point(648, 269);
            this.lb_atau.Name = "lb_atau";
            this.lb_atau.Size = new System.Drawing.Size(22, 25);
            this.lb_atau.TabIndex = 52;
            this.lb_atau.Text = "/";
            // 
            // panel_laporan
            // 
            this.panel_laporan.BackColor = System.Drawing.SystemColors.Window;
            this.panel_laporan.Controls.Add(this.btn_lihatLaporan);
            this.panel_laporan.Controls.Add(this.lb_bulan);
            this.panel_laporan.Controls.Add(this.tb_tahunLaporan);
            this.panel_laporan.Controls.Add(this.lb_tahun);
            this.panel_laporan.Controls.Add(this.cb_bulanLaporan);
            this.panel_laporan.ForeColor = System.Drawing.Color.Black;
            this.panel_laporan.Location = new System.Drawing.Point(798, 114);
            this.panel_laporan.Name = "panel_laporan";
            this.panel_laporan.Size = new System.Drawing.Size(501, 176);
            this.panel_laporan.TabIndex = 53;
            this.panel_laporan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_laporan_Paint);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(123)))), ((int)(((byte)(78)))));
            this.panel.Controls.Add(this.btn_beranda);
            this.panel.Controls.Add(this.btn_penjualan);
            this.panel.Controls.Add(this.btn_riwayat);
            this.panel.Controls.Add(this.button3);
            this.panel.Controls.Add(this.btn_pesan);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Location = new System.Drawing.Point(0, -57);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(250, 955);
            this.panel.TabIndex = 54;
            // 
            // btn_beranda
            // 
            this.btn_beranda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_beranda.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_beranda.Location = new System.Drawing.Point(29, 350);
            this.btn_beranda.Name = "btn_beranda";
            this.btn_beranda.Size = new System.Drawing.Size(190, 70);
            this.btn_beranda.TabIndex = 8;
            this.btn_beranda.Text = "Beranda";
            this.btn_beranda.UseVisualStyleBackColor = false;
            this.btn_beranda.Click += new System.EventHandler(this.btn_beranda_Click);
            // 
            // btn_penjualan
            // 
            this.btn_penjualan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_penjualan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_penjualan.Location = new System.Drawing.Point(29, 790);
            this.btn_penjualan.Name = "btn_penjualan";
            this.btn_penjualan.Size = new System.Drawing.Size(190, 70);
            this.btn_penjualan.TabIndex = 7;
            this.btn_penjualan.Text = "Penjualan";
            this.btn_penjualan.UseVisualStyleBackColor = false;
            // 
            // btn_riwayat
            // 
            this.btn_riwayat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_riwayat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_riwayat.Location = new System.Drawing.Point(29, 680);
            this.btn_riwayat.Name = "btn_riwayat";
            this.btn_riwayat.Size = new System.Drawing.Size(190, 70);
            this.btn_riwayat.TabIndex = 6;
            this.btn_riwayat.Text = "Riwayat";
            this.btn_riwayat.UseVisualStyleBackColor = false;
            this.btn_riwayat.Click += new System.EventHandler(this.btn_riwayat_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(29, 570);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(190, 70);
            this.button3.TabIndex = 5;
            this.button3.Text = "Produk";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_pesan
            // 
            this.btn_pesan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_pesan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesan.Location = new System.Drawing.Point(29, 460);
            this.btn_pesan.Name = "btn_pesan";
            this.btn_pesan.Size = new System.Drawing.Size(190, 70);
            this.btn_pesan.TabIndex = 4;
            this.btn_pesan.Text = "Pesan";
            this.btn_pesan.UseVisualStyleBackColor = false;
            this.btn_pesan.Click += new System.EventHandler(this.btn_pesan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Jreng_Kitchen.Properties.Resources.logo_jreng_kitchen;
            this.pictureBox1.Location = new System.Drawing.Point(29, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(190, 182);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1364, 889);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.panel_laporan);
            this.Controls.Add(this.lb_atau);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.dgv_penjualan);
            this.Controls.Add(this.dtp_tglInput);
            this.Controls.Add(this.lb_tglInput);
            this.Controls.Add(this.tb_tahun);
            this.Controls.Add(this.cb_bulan);
            this.Controls.Add(this.lb_bulanTahun);
            this.Controls.Add(this.btn_konfirmasi);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.cb_namaStaff);
            this.Controls.Add(this.cb_merchant);
            this.Controls.Add(this.tb_totalPotongan);
            this.Controls.Add(this.tb_biayaAdmin);
            this.Controls.Add(this.tb_pajak);
            this.Controls.Add(this.tb_totalPesanan);
            this.Controls.Add(this.tb_totalPendapatan);
            this.Controls.Add(this.lb_totalPotongan);
            this.Controls.Add(this.lb_biayaAdmin);
            this.Controls.Add(this.lb_pajak);
            this.Controls.Add(this.lb_totalPesanan);
            this.Controls.Add(this.lb_totalPendapatan);
            this.Controls.Add(this.lb_merchant);
            this.Controls.Add(this.lb_namaStaff);
            this.Controls.Add(this.lb_pendapatanMerchant);
            this.Name = "FormSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSales";
            this.Load += new System.EventHandler(this.FormSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_penjualan)).EndInit();
            this.panel_laporan.ResumeLayout(false);
            this.panel_laporan.PerformLayout();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_pendapatanMerchant;
        private System.Windows.Forms.Label lb_namaStaff;
        private System.Windows.Forms.Label lb_merchant;
        private System.Windows.Forms.Label lb_totalPendapatan;
        private System.Windows.Forms.Label lb_totalPesanan;
        private System.Windows.Forms.Label lb_pajak;
        private System.Windows.Forms.Label lb_biayaAdmin;
        private System.Windows.Forms.Label lb_totalPotongan;
        private System.Windows.Forms.TextBox tb_totalPendapatan;
        private System.Windows.Forms.TextBox tb_totalPesanan;
        private System.Windows.Forms.TextBox tb_pajak;
        private System.Windows.Forms.TextBox tb_biayaAdmin;
        private System.Windows.Forms.TextBox tb_totalPotongan;
        private System.Windows.Forms.ComboBox cb_merchant;
        private System.Windows.Forms.ComboBox cb_namaStaff;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_konfirmasi;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Button btn_lihatLaporan;
        private System.Windows.Forms.Label lb_bulanTahun;
        private System.Windows.Forms.ComboBox cb_bulan;
        private System.Windows.Forms.TextBox tb_tahun;
        private System.Windows.Forms.DateTimePicker dtp_tglInput;
        private System.Windows.Forms.Label lb_tglInput;
        private System.Windows.Forms.DataGridView dgv_penjualan;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.TextBox tb_tahunLaporan;
        private System.Windows.Forms.ComboBox cb_bulanLaporan;
        private System.Windows.Forms.Label lb_tahun;
        private System.Windows.Forms.Label lb_bulan;
        private System.Windows.Forms.Label lb_atau;
        private System.Windows.Forms.Panel panel_laporan;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_beranda;
        private System.Windows.Forms.Button btn_penjualan;
        private System.Windows.Forms.Button btn_riwayat;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_pesan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}