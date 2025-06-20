namespace Jreng_Kitchen
{
    partial class FormHistory
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
            this.dgv_history = new System.Windows.Forms.DataGridView();
            this.dgv_detailHistory = new System.Windows.Forms.DataGridView();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.lb_idPemesanan = new System.Windows.Forms.Label();
            this.lb_statusLunas = new System.Windows.Forms.Label();
            this.lb_alamat = new System.Windows.Forms.Label();
            this.lb_noTelp = new System.Windows.Forms.Label();
            this.tb_alamat = new System.Windows.Forms.TextBox();
            this.cb_statusLunas = new System.Windows.Forms.ComboBox();
            this.lb_biayaOngkir = new System.Windows.Forms.Label();
            this.tb_noTelp = new System.Windows.Forms.TextBox();
            this.tb_idPemesanan = new System.Windows.Forms.TextBox();
            this.tb_biayaOngkir = new System.Windows.Forms.TextBox();
            this.btn_konfirmasi = new System.Windows.Forms.Button();
            this.tb_cari = new System.Windows.Forms.TextBox();
            this.btn_cari = new System.Windows.Forms.Button();
            this.chb_lunas = new System.Windows.Forms.CheckBox();
            this.chb_belumLunas = new System.Windows.Forms.CheckBox();
            this.cb_metodePembayaran = new System.Windows.Forms.ComboBox();
            this.lb_metodePembayaran = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_beranda = new System.Windows.Forms.Button();
            this.btn_penjualan = new System.Windows.Forms.Button();
            this.btn_riwayat = new System.Windows.Forms.Button();
            this.btn_produk = new System.Windows.Forms.Button();
            this.btn_pesan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detailHistory)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_history
            // 
            this.dgv_history.AllowUserToAddRows = false;
            this.dgv_history.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_history.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_history.Location = new System.Drawing.Point(284, 76);
            this.dgv_history.MultiSelect = false;
            this.dgv_history.Name = "dgv_history";
            this.dgv_history.ReadOnly = true;
            this.dgv_history.RowHeadersVisible = false;
            this.dgv_history.RowHeadersWidth = 82;
            this.dgv_history.RowTemplate.Height = 33;
            this.dgv_history.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_history.Size = new System.Drawing.Size(1029, 353);
            this.dgv_history.TabIndex = 0;
            this.dgv_history.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_history_CellContentClick);
            // 
            // dgv_detailHistory
            // 
            this.dgv_detailHistory.AllowUserToAddRows = false;
            this.dgv_detailHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_detailHistory.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_detailHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_detailHistory.Location = new System.Drawing.Point(284, 447);
            this.dgv_detailHistory.MultiSelect = false;
            this.dgv_detailHistory.Name = "dgv_detailHistory";
            this.dgv_detailHistory.ReadOnly = true;
            this.dgv_detailHistory.RowHeadersVisible = false;
            this.dgv_detailHistory.RowHeadersWidth = 82;
            this.dgv_detailHistory.RowTemplate.Height = 33;
            this.dgv_detailHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_detailHistory.Size = new System.Drawing.Size(1029, 247);
            this.dgv_detailHistory.TabIndex = 1;
            // 
            // btn_ubah
            // 
            this.btn_ubah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_ubah.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ubah.Location = new System.Drawing.Point(1069, 815);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(94, 47);
            this.btn_ubah.TabIndex = 2;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = false;
            this.btn_ubah.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // lb_idPemesanan
            // 
            this.lb_idPemesanan.AutoSize = true;
            this.lb_idPemesanan.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_idPemesanan.Location = new System.Drawing.Point(280, 711);
            this.lb_idPemesanan.Name = "lb_idPemesanan";
            this.lb_idPemesanan.Size = new System.Drawing.Size(140, 25);
            this.lb_idPemesanan.TabIndex = 3;
            this.lb_idPemesanan.Text = "ID Pemesanan";
            // 
            // lb_statusLunas
            // 
            this.lb_statusLunas.AutoSize = true;
            this.lb_statusLunas.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_statusLunas.Location = new System.Drawing.Point(952, 711);
            this.lb_statusLunas.Name = "lb_statusLunas";
            this.lb_statusLunas.Size = new System.Drawing.Size(131, 25);
            this.lb_statusLunas.TabIndex = 4;
            this.lb_statusLunas.Text = "Status Lunas ";
            // 
            // lb_alamat
            // 
            this.lb_alamat.AutoSize = true;
            this.lb_alamat.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_alamat.Location = new System.Drawing.Point(278, 795);
            this.lb_alamat.Name = "lb_alamat";
            this.lb_alamat.Size = new System.Drawing.Size(80, 25);
            this.lb_alamat.TabIndex = 5;
            this.lb_alamat.Text = "Alamat ";
            // 
            // lb_noTelp
            // 
            this.lb_noTelp.AutoSize = true;
            this.lb_noTelp.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_noTelp.Location = new System.Drawing.Point(278, 753);
            this.lb_noTelp.Name = "lb_noTelp";
            this.lb_noTelp.Size = new System.Drawing.Size(84, 25);
            this.lb_noTelp.TabIndex = 6;
            this.lb_noTelp.Text = "No. Telp";
            // 
            // tb_alamat
            // 
            this.tb_alamat.Location = new System.Drawing.Point(442, 792);
            this.tb_alamat.Name = "tb_alamat";
            this.tb_alamat.Size = new System.Drawing.Size(299, 31);
            this.tb_alamat.TabIndex = 7;
            // 
            // cb_statusLunas
            // 
            this.cb_statusLunas.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_statusLunas.FormattingEnabled = true;
            this.cb_statusLunas.Location = new System.Drawing.Point(1096, 708);
            this.cb_statusLunas.Name = "cb_statusLunas";
            this.cb_statusLunas.Size = new System.Drawing.Size(217, 33);
            this.cb_statusLunas.TabIndex = 8;
            // 
            // lb_biayaOngkir
            // 
            this.lb_biayaOngkir.AutoSize = true;
            this.lb_biayaOngkir.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_biayaOngkir.Location = new System.Drawing.Point(278, 837);
            this.lb_biayaOngkir.Name = "lb_biayaOngkir";
            this.lb_biayaOngkir.Size = new System.Drawing.Size(134, 25);
            this.lb_biayaOngkir.TabIndex = 9;
            this.lb_biayaOngkir.Text = "Biaya Ongkir ";
            // 
            // tb_noTelp
            // 
            this.tb_noTelp.Location = new System.Drawing.Point(442, 750);
            this.tb_noTelp.Name = "tb_noTelp";
            this.tb_noTelp.Size = new System.Drawing.Size(299, 31);
            this.tb_noTelp.TabIndex = 10;
            // 
            // tb_idPemesanan
            // 
            this.tb_idPemesanan.Location = new System.Drawing.Point(442, 708);
            this.tb_idPemesanan.Name = "tb_idPemesanan";
            this.tb_idPemesanan.Size = new System.Drawing.Size(299, 31);
            this.tb_idPemesanan.TabIndex = 11;
            // 
            // tb_biayaOngkir
            // 
            this.tb_biayaOngkir.Location = new System.Drawing.Point(442, 834);
            this.tb_biayaOngkir.Name = "tb_biayaOngkir";
            this.tb_biayaOngkir.Size = new System.Drawing.Size(157, 31);
            this.tb_biayaOngkir.TabIndex = 12;
            // 
            // btn_konfirmasi
            // 
            this.btn_konfirmasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_konfirmasi.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_konfirmasi.Location = new System.Drawing.Point(1172, 815);
            this.btn_konfirmasi.Name = "btn_konfirmasi";
            this.btn_konfirmasi.Size = new System.Drawing.Size(144, 47);
            this.btn_konfirmasi.TabIndex = 13;
            this.btn_konfirmasi.Text = "Konfirmasi";
            this.btn_konfirmasi.UseVisualStyleBackColor = false;
            this.btn_konfirmasi.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // tb_cari
            // 
            this.tb_cari.Location = new System.Drawing.Point(284, 28);
            this.tb_cari.MaxLength = 25;
            this.tb_cari.Name = "tb_cari";
            this.tb_cari.Size = new System.Drawing.Size(550, 31);
            this.tb_cari.TabIndex = 14;
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_cari.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari.Location = new System.Drawing.Point(852, 24);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(87, 39);
            this.btn_cari.TabIndex = 15;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = false;
            this.btn_cari.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // chb_lunas
            // 
            this.chb_lunas.AutoSize = true;
            this.chb_lunas.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_lunas.Location = new System.Drawing.Point(1024, 30);
            this.chb_lunas.Name = "chb_lunas";
            this.chb_lunas.Size = new System.Drawing.Size(98, 29);
            this.chb_lunas.TabIndex = 33;
            this.chb_lunas.Text = "Lunas";
            this.chb_lunas.UseVisualStyleBackColor = true;
            // 
            // chb_belumLunas
            // 
            this.chb_belumLunas.AutoSize = true;
            this.chb_belumLunas.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_belumLunas.Location = new System.Drawing.Point(1152, 30);
            this.chb_belumLunas.Name = "chb_belumLunas";
            this.chb_belumLunas.Size = new System.Drawing.Size(161, 29);
            this.chb_belumLunas.TabIndex = 34;
            this.chb_belumLunas.Text = "Belum Lunas";
            this.chb_belumLunas.UseVisualStyleBackColor = true;
            // 
            // cb_metodePembayaran
            // 
            this.cb_metodePembayaran.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_metodePembayaran.FormattingEnabled = true;
            this.cb_metodePembayaran.Location = new System.Drawing.Point(1172, 750);
            this.cb_metodePembayaran.Name = "cb_metodePembayaran";
            this.cb_metodePembayaran.Size = new System.Drawing.Size(141, 33);
            this.cb_metodePembayaran.TabIndex = 44;
            // 
            // lb_metodePembayaran
            // 
            this.lb_metodePembayaran.AutoSize = true;
            this.lb_metodePembayaran.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_metodePembayaran.Location = new System.Drawing.Point(952, 753);
            this.lb_metodePembayaran.Name = "lb_metodePembayaran";
            this.lb_metodePembayaran.Size = new System.Drawing.Size(197, 25);
            this.lb_metodePembayaran.TabIndex = 43;
            this.lb_metodePembayaran.Text = "Metode Pembayaran";
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
            this.panel.TabIndex = 46;
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
            this.btn_riwayat.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_riwayat.Location = new System.Drawing.Point(29, 680);
            this.btn_riwayat.Name = "btn_riwayat";
            this.btn_riwayat.Size = new System.Drawing.Size(190, 70);
            this.btn_riwayat.TabIndex = 6;
            this.btn_riwayat.Text = "Riwayat";
            this.btn_riwayat.UseVisualStyleBackColor = false;
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
            // FormHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1364, 889);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.cb_metodePembayaran);
            this.Controls.Add(this.lb_metodePembayaran);
            this.Controls.Add(this.chb_belumLunas);
            this.Controls.Add(this.chb_lunas);
            this.Controls.Add(this.btn_cari);
            this.Controls.Add(this.tb_cari);
            this.Controls.Add(this.btn_konfirmasi);
            this.Controls.Add(this.tb_biayaOngkir);
            this.Controls.Add(this.tb_idPemesanan);
            this.Controls.Add(this.tb_noTelp);
            this.Controls.Add(this.lb_biayaOngkir);
            this.Controls.Add(this.cb_statusLunas);
            this.Controls.Add(this.tb_alamat);
            this.Controls.Add(this.lb_noTelp);
            this.Controls.Add(this.lb_alamat);
            this.Controls.Add(this.lb_statusLunas);
            this.Controls.Add(this.lb_idPemesanan);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.dgv_detailHistory);
            this.Controls.Add(this.dgv_history);
            this.Name = "FormHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormHistory";
            this.Load += new System.EventHandler(this.FormHistory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_history)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detailHistory)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_history;
        private System.Windows.Forms.DataGridView dgv_detailHistory;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Label lb_idPemesanan;
        private System.Windows.Forms.Label lb_statusLunas;
        private System.Windows.Forms.Label lb_alamat;
        private System.Windows.Forms.Label lb_noTelp;
        private System.Windows.Forms.TextBox tb_alamat;
        private System.Windows.Forms.ComboBox cb_statusLunas;
        private System.Windows.Forms.Label lb_biayaOngkir;
        private System.Windows.Forms.TextBox tb_noTelp;
        private System.Windows.Forms.TextBox tb_idPemesanan;
        private System.Windows.Forms.TextBox tb_biayaOngkir;
        private System.Windows.Forms.Button btn_konfirmasi;
        private System.Windows.Forms.TextBox tb_cari;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.CheckBox chb_lunas;
        private System.Windows.Forms.CheckBox chb_belumLunas;
        private System.Windows.Forms.ComboBox cb_metodePembayaran;
        private System.Windows.Forms.Label lb_metodePembayaran;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_beranda;
        private System.Windows.Forms.Button btn_penjualan;
        private System.Windows.Forms.Button btn_riwayat;
        private System.Windows.Forms.Button btn_produk;
        private System.Windows.Forms.Button btn_pesan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}