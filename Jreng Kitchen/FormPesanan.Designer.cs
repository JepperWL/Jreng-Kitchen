namespace Jreng_Kitchen
{
    partial class FormPesanan
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
            this.lb_namaStaff = new System.Windows.Forms.Label();
            this.cb_namaStaff = new System.Windows.Forms.ComboBox();
            this.lb_namaCustomer = new System.Windows.Forms.Label();
            this.dgv_pesanan = new System.Windows.Forms.DataGridView();
            this.lb_noTelp = new System.Windows.Forms.Label();
            this.tb_noTelp = new System.Windows.Forms.TextBox();
            this.lb_alamat = new System.Windows.Forms.Label();
            this.lb_tglPO = new System.Windows.Forms.Label();
            this.tb_alamat = new System.Windows.Forms.TextBox();
            this.dtp_tglPO = new System.Windows.Forms.DateTimePicker();
            this.tb_namaCustomer = new System.Windows.Forms.TextBox();
            this.btn_lanjutkan = new System.Windows.Forms.Button();
            this.lb_totalPesanan = new System.Windows.Forms.Label();
            this.lb_ongkir = new System.Windows.Forms.Label();
            this.tb_ongkir = new System.Windows.Forms.TextBox();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.cb_statusLunas = new System.Windows.Forms.ComboBox();
            this.lb_statusLunas = new System.Windows.Forms.Label();
            this.cb_namaMenu = new System.Windows.Forms.ComboBox();
            this.lb_menu = new System.Windows.Forms.Label();
            this.tb_qty = new System.Windows.Forms.TextBox();
            this.btn_plus = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.lb_harga = new System.Windows.Forms.Label();
            this.lb_angkaHrg = new System.Windows.Forms.Label();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.lb_metodePembayaran = new System.Windows.Forms.Label();
            this.cb_metodePembayaran = new System.Windows.Forms.ComboBox();
            this.lb_jumlah = new System.Windows.Forms.Label();
            this.lb_detailPesanan = new System.Windows.Forms.Label();
            this.lb_daftarMenu = new System.Windows.Forms.Label();
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_beranda = new System.Windows.Forms.Button();
            this.btn_penjualan = new System.Windows.Forms.Button();
            this.btn_riwayat = new System.Windows.Forms.Button();
            this.btn_produk = new System.Windows.Forms.Button();
            this.btn_pesan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_namaStaff
            // 
            this.lb_namaStaff.AutoSize = true;
            this.lb_namaStaff.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_namaStaff.Location = new System.Drawing.Point(265, 103);
            this.lb_namaStaff.Name = "lb_namaStaff";
            this.lb_namaStaff.Size = new System.Drawing.Size(107, 25);
            this.lb_namaStaff.TabIndex = 5;
            this.lb_namaStaff.Text = "Nama Staff";
            // 
            // cb_namaStaff
            // 
            this.cb_namaStaff.FormattingEnabled = true;
            this.cb_namaStaff.Location = new System.Drawing.Point(441, 100);
            this.cb_namaStaff.Name = "cb_namaStaff";
            this.cb_namaStaff.Size = new System.Drawing.Size(266, 33);
            this.cb_namaStaff.TabIndex = 6;
            this.cb_namaStaff.SelectedIndexChanged += new System.EventHandler(this.cb_namaStaff_SelectedIndexChanged);
            // 
            // lb_namaCustomer
            // 
            this.lb_namaCustomer.AutoSize = true;
            this.lb_namaCustomer.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_namaCustomer.Location = new System.Drawing.Point(265, 155);
            this.lb_namaCustomer.Name = "lb_namaCustomer";
            this.lb_namaCustomer.Size = new System.Drawing.Size(155, 25);
            this.lb_namaCustomer.TabIndex = 7;
            this.lb_namaCustomer.Text = "Nama Customer";
            // 
            // dgv_pesanan
            // 
            this.dgv_pesanan.AllowUserToAddRows = false;
            this.dgv_pesanan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_pesanan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_pesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pesanan.Location = new System.Drawing.Point(270, 385);
            this.dgv_pesanan.MultiSelect = false;
            this.dgv_pesanan.Name = "dgv_pesanan";
            this.dgv_pesanan.ReadOnly = true;
            this.dgv_pesanan.RowHeadersVisible = false;
            this.dgv_pesanan.RowHeadersWidth = 82;
            this.dgv_pesanan.RowTemplate.Height = 33;
            this.dgv_pesanan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_pesanan.Size = new System.Drawing.Size(557, 238);
            this.dgv_pesanan.TabIndex = 11;
            this.dgv_pesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_pesanan_CellContentClick);
            // 
            // lb_noTelp
            // 
            this.lb_noTelp.AutoSize = true;
            this.lb_noTelp.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_noTelp.Location = new System.Drawing.Point(265, 207);
            this.lb_noTelp.Name = "lb_noTelp";
            this.lb_noTelp.Size = new System.Drawing.Size(84, 25);
            this.lb_noTelp.TabIndex = 12;
            this.lb_noTelp.Text = "No. Telp";
            // 
            // tb_noTelp
            // 
            this.tb_noTelp.Location = new System.Drawing.Point(441, 204);
            this.tb_noTelp.MaxLength = 13;
            this.tb_noTelp.Name = "tb_noTelp";
            this.tb_noTelp.Size = new System.Drawing.Size(266, 31);
            this.tb_noTelp.TabIndex = 13;
            this.tb_noTelp.TextChanged += new System.EventHandler(this.tb_noTelp_TextChanged);
            this.tb_noTelp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_noTelp_KeyPress);
            // 
            // lb_alamat
            // 
            this.lb_alamat.AutoSize = true;
            this.lb_alamat.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alamat.Location = new System.Drawing.Point(265, 259);
            this.lb_alamat.Name = "lb_alamat";
            this.lb_alamat.Size = new System.Drawing.Size(75, 25);
            this.lb_alamat.TabIndex = 14;
            this.lb_alamat.Text = "Alamat";
            // 
            // lb_tglPO
            // 
            this.lb_tglPO.AutoSize = true;
            this.lb_tglPO.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tglPO.Location = new System.Drawing.Point(455, 320);
            this.lb_tglPO.Name = "lb_tglPO";
            this.lb_tglPO.Size = new System.Drawing.Size(111, 25);
            this.lb_tglPO.TabIndex = 15;
            this.lb_tglPO.Text = "Tanggal PO";
            // 
            // tb_alamat
            // 
            this.tb_alamat.Location = new System.Drawing.Point(441, 256);
            this.tb_alamat.MaxLength = 100;
            this.tb_alamat.Name = "tb_alamat";
            this.tb_alamat.Size = new System.Drawing.Size(266, 31);
            this.tb_alamat.TabIndex = 16;
            // 
            // dtp_tglPO
            // 
            this.dtp_tglPO.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_tglPO.Location = new System.Drawing.Point(579, 314);
            this.dtp_tglPO.Name = "dtp_tglPO";
            this.dtp_tglPO.Size = new System.Drawing.Size(248, 32);
            this.dtp_tglPO.TabIndex = 17;
            // 
            // tb_namaCustomer
            // 
            this.tb_namaCustomer.Location = new System.Drawing.Point(441, 152);
            this.tb_namaCustomer.MaxLength = 30;
            this.tb_namaCustomer.Name = "tb_namaCustomer";
            this.tb_namaCustomer.Size = new System.Drawing.Size(266, 31);
            this.tb_namaCustomer.TabIndex = 19;
            this.tb_namaCustomer.TextChanged += new System.EventHandler(this.tb_namaCustomer_TextChanged);
            // 
            // btn_lanjutkan
            // 
            this.btn_lanjutkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_lanjutkan.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lanjutkan.Location = new System.Drawing.Point(1124, 792);
            this.btn_lanjutkan.Name = "btn_lanjutkan";
            this.btn_lanjutkan.Size = new System.Drawing.Size(216, 54);
            this.btn_lanjutkan.TabIndex = 20;
            this.btn_lanjutkan.Text = "Lanjutkan Pesanan";
            this.btn_lanjutkan.UseVisualStyleBackColor = false;
            this.btn_lanjutkan.Click += new System.EventHandler(this.btn_continue_Click);
            // 
            // lb_totalPesanan
            // 
            this.lb_totalPesanan.AutoSize = true;
            this.lb_totalPesanan.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_totalPesanan.Location = new System.Drawing.Point(265, 659);
            this.lb_totalPesanan.Name = "lb_totalPesanan";
            this.lb_totalPesanan.Size = new System.Drawing.Size(56, 25);
            this.lb_totalPesanan.TabIndex = 21;
            this.lb_totalPesanan.Text = "Total";
            // 
            // lb_ongkir
            // 
            this.lb_ongkir.AutoSize = true;
            this.lb_ongkir.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ongkir.Location = new System.Drawing.Point(265, 712);
            this.lb_ongkir.Name = "lb_ongkir";
            this.lb_ongkir.Size = new System.Drawing.Size(134, 25);
            this.lb_ongkir.TabIndex = 25;
            this.lb_ongkir.Text = "Biaya Ongkir ";
            // 
            // tb_ongkir
            // 
            this.tb_ongkir.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ongkir.Location = new System.Drawing.Point(421, 709);
            this.tb_ongkir.MaxLength = 6;
            this.tb_ongkir.Name = "tb_ongkir";
            this.tb_ongkir.Size = new System.Drawing.Size(214, 32);
            this.tb_ongkir.TabIndex = 26;
            this.tb_ongkir.TextChanged += new System.EventHandler(this.tb_ongkir_TextChanged);
            this.tb_ongkir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ongkir_KeyPress);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_hapus.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.Location = new System.Drawing.Point(715, 651);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(112, 40);
            this.btn_hapus.TabIndex = 27;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // cb_statusLunas
            // 
            this.cb_statusLunas.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_statusLunas.FormattingEnabled = true;
            this.cb_statusLunas.Location = new System.Drawing.Point(421, 761);
            this.cb_statusLunas.Name = "cb_statusLunas";
            this.cb_statusLunas.Size = new System.Drawing.Size(214, 33);
            this.cb_statusLunas.TabIndex = 28;
            // 
            // lb_statusLunas
            // 
            this.lb_statusLunas.AutoSize = true;
            this.lb_statusLunas.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statusLunas.Location = new System.Drawing.Point(265, 764);
            this.lb_statusLunas.Name = "lb_statusLunas";
            this.lb_statusLunas.Size = new System.Drawing.Size(131, 25);
            this.lb_statusLunas.TabIndex = 29;
            this.lb_statusLunas.Text = "Status Lunas ";
            // 
            // cb_namaMenu
            // 
            this.cb_namaMenu.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_namaMenu.FormattingEnabled = true;
            this.cb_namaMenu.Location = new System.Drawing.Point(963, 538);
            this.cb_namaMenu.Name = "cb_namaMenu";
            this.cb_namaMenu.Size = new System.Drawing.Size(377, 33);
            this.cb_namaMenu.TabIndex = 32;
            this.cb_namaMenu.SelectedIndexChanged += new System.EventHandler(this.cb_namaMenu_SelectedIndexChanged);
            // 
            // lb_menu
            // 
            this.lb_menu.AutoSize = true;
            this.lb_menu.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_menu.Location = new System.Drawing.Point(871, 541);
            this.lb_menu.Name = "lb_menu";
            this.lb_menu.Size = new System.Drawing.Size(63, 25);
            this.lb_menu.TabIndex = 33;
            this.lb_menu.Text = "Menu";
            // 
            // tb_qty
            // 
            this.tb_qty.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_qty.Location = new System.Drawing.Point(1003, 642);
            this.tb_qty.MaxLength = 2;
            this.tb_qty.Name = "tb_qty";
            this.tb_qty.Size = new System.Drawing.Size(48, 32);
            this.tb_qty.TabIndex = 34;
            this.tb_qty.TextChanged += new System.EventHandler(this.tb_qty_TextChanged);
            this.tb_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_qty_KeyPress);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(1057, 641);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(34, 33);
            this.btn_plus.TabIndex = 35;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(963, 642);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(34, 33);
            this.btn_minus.TabIndex = 36;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // lb_harga
            // 
            this.lb_harga.AutoSize = true;
            this.lb_harga.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_harga.Location = new System.Drawing.Point(871, 593);
            this.lb_harga.Name = "lb_harga";
            this.lb_harga.Size = new System.Drawing.Size(65, 25);
            this.lb_harga.TabIndex = 37;
            this.lb_harga.Text = "Harga";
            // 
            // lb_angkaHrg
            // 
            this.lb_angkaHrg.AutoSize = true;
            this.lb_angkaHrg.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_angkaHrg.Location = new System.Drawing.Point(958, 593);
            this.lb_angkaHrg.Name = "lb_angkaHrg";
            this.lb_angkaHrg.Size = new System.Drawing.Size(24, 25);
            this.lb_angkaHrg.TabIndex = 38;
            this.lb_angkaHrg.Text = "...";
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_tambah.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.Location = new System.Drawing.Point(876, 697);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(112, 54);
            this.btn_tambah.TabIndex = 39;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lb_metodePembayaran
            // 
            this.lb_metodePembayaran.AutoSize = true;
            this.lb_metodePembayaran.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_metodePembayaran.Location = new System.Drawing.Point(265, 816);
            this.lb_metodePembayaran.Name = "lb_metodePembayaran";
            this.lb_metodePembayaran.Size = new System.Drawing.Size(197, 25);
            this.lb_metodePembayaran.TabIndex = 41;
            this.lb_metodePembayaran.Text = "Metode Pembayaran";
            // 
            // cb_metodePembayaran
            // 
            this.cb_metodePembayaran.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_metodePembayaran.FormattingEnabled = true;
            this.cb_metodePembayaran.Location = new System.Drawing.Point(482, 813);
            this.cb_metodePembayaran.Name = "cb_metodePembayaran";
            this.cb_metodePembayaran.Size = new System.Drawing.Size(153, 33);
            this.cb_metodePembayaran.TabIndex = 42;
            // 
            // lb_jumlah
            // 
            this.lb_jumlah.AutoSize = true;
            this.lb_jumlah.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jumlah.Location = new System.Drawing.Point(871, 645);
            this.lb_jumlah.Name = "lb_jumlah";
            this.lb_jumlah.Size = new System.Drawing.Size(75, 25);
            this.lb_jumlah.TabIndex = 43;
            this.lb_jumlah.Text = "Jumlah";
            // 
            // lb_detailPesanan
            // 
            this.lb_detailPesanan.AutoSize = true;
            this.lb_detailPesanan.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_detailPesanan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.lb_detailPesanan.Location = new System.Drawing.Point(264, 41);
            this.lb_detailPesanan.Name = "lb_detailPesanan";
            this.lb_detailPesanan.Size = new System.Drawing.Size(328, 32);
            this.lb_detailPesanan.TabIndex = 44;
            this.lb_detailPesanan.Text = "Masukkan Detail Pesanan";
            // 
            // lb_daftarMenu
            // 
            this.lb_daftarMenu.AutoSize = true;
            this.lb_daftarMenu.BackColor = System.Drawing.Color.Transparent;
            this.lb_daftarMenu.Font = new System.Drawing.Font("Cambria", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_daftarMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.lb_daftarMenu.Location = new System.Drawing.Point(870, 72);
            this.lb_daftarMenu.Name = "lb_daftarMenu";
            this.lb_daftarMenu.Size = new System.Drawing.Size(167, 32);
            this.lb_daftarMenu.TabIndex = 45;
            this.lb_daftarMenu.Text = "Daftar Menu";
            // 
            // dgv_menu
            // 
            this.dgv_menu.AllowUserToAddRows = false;
            this.dgv_menu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_menu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Location = new System.Drawing.Point(876, 122);
            this.dgv_menu.MultiSelect = false;
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.ReadOnly = true;
            this.dgv_menu.RowHeadersVisible = false;
            this.dgv_menu.RowHeadersWidth = 82;
            this.dgv_menu.RowTemplate.Height = 33;
            this.dgv_menu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_menu.Size = new System.Drawing.Size(464, 377);
            this.dgv_menu.TabIndex = 46;
            this.dgv_menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_menu_CellContentClick);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(123)))), ((int)(((byte)(78)))));
            this.panel.Controls.Add(this.btn_beranda);
            this.panel.Controls.Add(this.btn_penjualan);
            this.panel.Controls.Add(this.btn_riwayat);
            this.panel.Controls.Add(this.btn_produk);
            this.panel.Controls.Add(this.btn_pesan);
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Location = new System.Drawing.Point(0, -57);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(250, 955);
            this.panel.TabIndex = 48;
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
            this.btn_penjualan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_penjualan.Location = new System.Drawing.Point(29, 790);
            this.btn_penjualan.Name = "btn_penjualan";
            this.btn_penjualan.Size = new System.Drawing.Size(190, 70);
            this.btn_penjualan.TabIndex = 7;
            this.btn_penjualan.Text = "Penjualan";
            this.btn_penjualan.UseVisualStyleBackColor = false;
            this.btn_penjualan.Click += new System.EventHandler(this.btn_penjualan_Click);
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
            // btn_produk
            // 
            this.btn_produk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_produk.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produk.Location = new System.Drawing.Point(29, 570);
            this.btn_produk.Name = "btn_produk";
            this.btn_produk.Size = new System.Drawing.Size(190, 70);
            this.btn_produk.TabIndex = 5;
            this.btn_produk.Text = "Produk";
            this.btn_produk.UseVisualStyleBackColor = false;
            this.btn_produk.Click += new System.EventHandler(this.btn_produk_Click);
            // 
            // btn_pesan
            // 
            this.btn_pesan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_pesan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesan.Location = new System.Drawing.Point(29, 460);
            this.btn_pesan.Name = "btn_pesan";
            this.btn_pesan.Size = new System.Drawing.Size(190, 70);
            this.btn_pesan.TabIndex = 4;
            this.btn_pesan.Text = "Pesan";
            this.btn_pesan.UseVisualStyleBackColor = false;
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
            // FormPesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Jreng_Kitchen.Properties.Resources.Order_Page;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 889);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dgv_menu);
            this.Controls.Add(this.lb_daftarMenu);
            this.Controls.Add(this.lb_detailPesanan);
            this.Controls.Add(this.lb_jumlah);
            this.Controls.Add(this.cb_metodePembayaran);
            this.Controls.Add(this.lb_metodePembayaran);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.lb_angkaHrg);
            this.Controls.Add(this.lb_harga);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.tb_qty);
            this.Controls.Add(this.lb_menu);
            this.Controls.Add(this.cb_namaMenu);
            this.Controls.Add(this.lb_statusLunas);
            this.Controls.Add(this.cb_statusLunas);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.tb_ongkir);
            this.Controls.Add(this.lb_ongkir);
            this.Controls.Add(this.lb_totalPesanan);
            this.Controls.Add(this.btn_lanjutkan);
            this.Controls.Add(this.tb_namaCustomer);
            this.Controls.Add(this.dtp_tglPO);
            this.Controls.Add(this.tb_alamat);
            this.Controls.Add(this.lb_tglPO);
            this.Controls.Add(this.lb_alamat);
            this.Controls.Add(this.tb_noTelp);
            this.Controls.Add(this.lb_noTelp);
            this.Controls.Add(this.dgv_pesanan);
            this.Controls.Add(this.lb_namaCustomer);
            this.Controls.Add(this.cb_namaStaff);
            this.Controls.Add(this.lb_namaStaff);
            this.DoubleBuffered = true;
            this.Name = "FormPesanan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPesanan";
            this.Load += new System.EventHandler(this.FormPesanan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_namaStaff;
        private System.Windows.Forms.ComboBox cb_namaStaff;
        private System.Windows.Forms.Label lb_namaCustomer;
        private System.Windows.Forms.DataGridView dgv_pesanan;
        private System.Windows.Forms.Label lb_noTelp;
        private System.Windows.Forms.TextBox tb_noTelp;
        private System.Windows.Forms.Label lb_alamat;
        private System.Windows.Forms.Label lb_tglPO;
        private System.Windows.Forms.TextBox tb_alamat;
        private System.Windows.Forms.DateTimePicker dtp_tglPO;
        private System.Windows.Forms.TextBox tb_namaCustomer;
        private System.Windows.Forms.Button btn_lanjutkan;
        private System.Windows.Forms.Label lb_totalPesanan;
        private System.Windows.Forms.Label lb_ongkir;
        private System.Windows.Forms.TextBox tb_ongkir;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.ComboBox cb_statusLunas;
        private System.Windows.Forms.Label lb_statusLunas;
        private System.Windows.Forms.ComboBox cb_namaMenu;
        private System.Windows.Forms.Label lb_menu;
        private System.Windows.Forms.TextBox tb_qty;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Label lb_harga;
        private System.Windows.Forms.Label lb_angkaHrg;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Label lb_metodePembayaran;
        private System.Windows.Forms.ComboBox cb_metodePembayaran;
        private System.Windows.Forms.Label lb_jumlah;
        private System.Windows.Forms.Label lb_detailPesanan;
        private System.Windows.Forms.Label lb_daftarMenu;
        private System.Windows.Forms.DataGridView dgv_menu;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_beranda;
        private System.Windows.Forms.Button btn_penjualan;
        private System.Windows.Forms.Button btn_riwayat;
        private System.Windows.Forms.Button btn_produk;
        private System.Windows.Forms.Button btn_pesan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}