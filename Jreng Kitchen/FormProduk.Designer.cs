namespace Jreng_Kitchen
{
    partial class FormProduk
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
            this.dgv_menu = new System.Windows.Forms.DataGridView();
            this.lb_namaMenu = new System.Windows.Forms.Label();
            this.lb_hargaMenu = new System.Windows.Forms.Label();
            this.tb_namaMenu = new System.Windows.Forms.TextBox();
            this.tb_hargaMenu = new System.Windows.Forms.TextBox();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.btn_cari = new System.Windows.Forms.Button();
            this.btn_konfirmasi = new System.Windows.Forms.Button();
            this.btn_ubah = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.btn_beranda = new System.Windows.Forms.Button();
            this.btn_penjualan = new System.Windows.Forms.Button();
            this.btn_riwayat = new System.Windows.Forms.Button();
            this.btn_produk = new System.Windows.Forms.Button();
            this.btn_pesan = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_menu
            // 
            this.dgv_menu.AllowUserToAddRows = false;
            this.dgv_menu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_menu.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_menu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_menu.Location = new System.Drawing.Point(276, 104);
            this.dgv_menu.MultiSelect = false;
            this.dgv_menu.Name = "dgv_menu";
            this.dgv_menu.ReadOnly = true;
            this.dgv_menu.RowHeadersVisible = false;
            this.dgv_menu.RowHeadersWidth = 82;
            this.dgv_menu.RowTemplate.Height = 33;
            this.dgv_menu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_menu.Size = new System.Drawing.Size(771, 535);
            this.dgv_menu.TabIndex = 1;
            this.dgv_menu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_menu_CellContentClick);
            // 
            // lb_namaMenu
            // 
            this.lb_namaMenu.AutoSize = true;
            this.lb_namaMenu.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_namaMenu.Location = new System.Drawing.Point(1077, 104);
            this.lb_namaMenu.Name = "lb_namaMenu";
            this.lb_namaMenu.Size = new System.Drawing.Size(124, 25);
            this.lb_namaMenu.TabIndex = 2;
            this.lb_namaMenu.Text = "Nama Menu ";
            // 
            // lb_hargaMenu
            // 
            this.lb_hargaMenu.AutoSize = true;
            this.lb_hargaMenu.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hargaMenu.Location = new System.Drawing.Point(1077, 227);
            this.lb_hargaMenu.Name = "lb_hargaMenu";
            this.lb_hargaMenu.Size = new System.Drawing.Size(126, 25);
            this.lb_hargaMenu.TabIndex = 3;
            this.lb_hargaMenu.Text = "Harga Menu ";
            // 
            // tb_namaMenu
            // 
            this.tb_namaMenu.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_namaMenu.Location = new System.Drawing.Point(1082, 146);
            this.tb_namaMenu.MaxLength = 30;
            this.tb_namaMenu.Name = "tb_namaMenu";
            this.tb_namaMenu.Size = new System.Drawing.Size(241, 32);
            this.tb_namaMenu.TabIndex = 4;
            // 
            // tb_hargaMenu
            // 
            this.tb_hargaMenu.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hargaMenu.Location = new System.Drawing.Point(1082, 270);
            this.tb_hargaMenu.MaxLength = 6;
            this.tb_hargaMenu.Name = "tb_hargaMenu";
            this.tb_hargaMenu.Size = new System.Drawing.Size(241, 32);
            this.tb_hargaMenu.TabIndex = 5;
            this.tb_hargaMenu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_hargaMenu_KeyPress);
            // 
            // btn_tambah
            // 
            this.btn_tambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_tambah.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tambah.Location = new System.Drawing.Point(1206, 359);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(117, 51);
            this.btn_tambah.TabIndex = 6;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = false;
            this.btn_tambah.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_hapus.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.Location = new System.Drawing.Point(932, 660);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(115, 50);
            this.btn_hapus.TabIndex = 7;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = false;
            this.btn_hapus.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(276, 53);
            this.tb_search.MaxLength = 30;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(549, 32);
            this.tb_search.TabIndex = 15;
            // 
            // btn_cari
            // 
            this.btn_cari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_cari.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari.Location = new System.Drawing.Point(841, 49);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(86, 39);
            this.btn_cari.TabIndex = 16;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = false;
            this.btn_cari.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_konfirmasi
            // 
            this.btn_konfirmasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_konfirmasi.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_konfirmasi.Location = new System.Drawing.Point(1176, 517);
            this.btn_konfirmasi.Name = "btn_konfirmasi";
            this.btn_konfirmasi.Size = new System.Drawing.Size(147, 47);
            this.btn_konfirmasi.TabIndex = 18;
            this.btn_konfirmasi.Text = "Konfirmasi";
            this.btn_konfirmasi.UseVisualStyleBackColor = false;
            this.btn_konfirmasi.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_ubah
            // 
            this.btn_ubah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_ubah.Font = new System.Drawing.Font("Cambria", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ubah.Location = new System.Drawing.Point(1082, 517);
            this.btn_ubah.Name = "btn_ubah";
            this.btn_ubah.Size = new System.Drawing.Size(88, 47);
            this.btn_ubah.TabIndex = 17;
            this.btn_ubah.Text = "Ubah";
            this.btn_ubah.UseVisualStyleBackColor = false;
            this.btn_ubah.Click += new System.EventHandler(this.btn_edit_Click);
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
            this.panel.TabIndex = 20;
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
            this.btn_produk.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produk.Location = new System.Drawing.Point(29, 570);
            this.btn_produk.Name = "btn_produk";
            this.btn_produk.Size = new System.Drawing.Size(190, 70);
            this.btn_produk.TabIndex = 5;
            this.btn_produk.Text = "Produk";
            this.btn_produk.UseVisualStyleBackColor = false;
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
            // FormProduk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::Jreng_Kitchen.Properties.Resources.Product;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 889);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btn_konfirmasi);
            this.Controls.Add(this.btn_ubah);
            this.Controls.Add(this.btn_cari);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.tb_hargaMenu);
            this.Controls.Add(this.tb_namaMenu);
            this.Controls.Add(this.lb_hargaMenu);
            this.Controls.Add(this.lb_namaMenu);
            this.Controls.Add(this.dgv_menu);
            this.DoubleBuffered = true;
            this.Name = "FormProduk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormProduk";
            this.Load += new System.EventHandler(this.FormProduk_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_menu)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_menu;
        private System.Windows.Forms.Label lb_namaMenu;
        private System.Windows.Forms.Label lb_hargaMenu;
        private System.Windows.Forms.TextBox tb_namaMenu;
        private System.Windows.Forms.TextBox tb_hargaMenu;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.Button btn_konfirmasi;
        private System.Windows.Forms.Button btn_ubah;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btn_beranda;
        private System.Windows.Forms.Button btn_penjualan;
        private System.Windows.Forms.Button btn_riwayat;
        private System.Windows.Forms.Button btn_produk;
        private System.Windows.Forms.Button btn_pesan;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}