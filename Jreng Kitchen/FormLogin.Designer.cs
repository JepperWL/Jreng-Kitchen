namespace Jreng_Kitchen
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btn_pesan = new System.Windows.Forms.Button();
            this.btn_produk = new System.Windows.Forms.Button();
            this.btn_riwayat = new System.Windows.Forms.Button();
            this.btn_penjualan = new System.Windows.Forms.Button();
            this.lb_ddmmyyyy = new System.Windows.Forms.Label();
            this.lb_hhmm = new System.Windows.Forms.Label();
            this.panel_datetime = new System.Windows.Forms.Panel();
            this.panel_pesananBerjalan = new System.Windows.Forms.Panel();
            this.panel_jmlPesanan = new System.Windows.Forms.Panel();
            this.lb_pesanan = new System.Windows.Forms.Label();
            this.lb_jml = new System.Windows.Forms.Label();
            this.lb_berjalan = new System.Windows.Forms.Label();
            this.lb_pesananSedang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            this.panel_datetime.SuspendLayout();
            this.panel_pesananBerjalan.SuspendLayout();
            this.panel_jmlPesanan.SuspendLayout();
            this.SuspendLayout();
            // 
            // pb_logo
            // 
            this.pb_logo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pb_logo.Image = global::Jreng_Kitchen.Properties.Resources.logo_jreng_kitchen;
            this.pb_logo.Location = new System.Drawing.Point(412, 213);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(554, 440);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 0;
            this.pb_logo.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btn_pesan
            // 
            this.btn_pesan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_pesan.Font = new System.Drawing.Font("Cambria", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pesan.Location = new System.Drawing.Point(704, 556);
            this.btn_pesan.Name = "btn_pesan";
            this.btn_pesan.Size = new System.Drawing.Size(253, 97);
            this.btn_pesan.TabIndex = 4;
            this.btn_pesan.Text = "Pesan";
            this.btn_pesan.UseVisualStyleBackColor = false;
            this.btn_pesan.Click += new System.EventHandler(this.btn_pesanan_Click);
            // 
            // btn_produk
            // 
            this.btn_produk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_produk.Font = new System.Drawing.Font("Cambria", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_produk.Location = new System.Drawing.Point(1009, 556);
            this.btn_produk.Name = "btn_produk";
            this.btn_produk.Size = new System.Drawing.Size(253, 97);
            this.btn_produk.TabIndex = 5;
            this.btn_produk.Text = "Produk";
            this.btn_produk.UseVisualStyleBackColor = false;
            this.btn_produk.Click += new System.EventHandler(this.btn_produk_Click);
            // 
            // btn_riwayat
            // 
            this.btn_riwayat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_riwayat.Font = new System.Drawing.Font("Cambria", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_riwayat.Location = new System.Drawing.Point(704, 700);
            this.btn_riwayat.Name = "btn_riwayat";
            this.btn_riwayat.Size = new System.Drawing.Size(253, 97);
            this.btn_riwayat.TabIndex = 6;
            this.btn_riwayat.Text = "Riwayat";
            this.btn_riwayat.UseVisualStyleBackColor = false;
            this.btn_riwayat.Click += new System.EventHandler(this.btn_history_Click);
            // 
            // btn_penjualan
            // 
            this.btn_penjualan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.btn_penjualan.Font = new System.Drawing.Font("Cambria", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_penjualan.Location = new System.Drawing.Point(1009, 700);
            this.btn_penjualan.Name = "btn_penjualan";
            this.btn_penjualan.Size = new System.Drawing.Size(253, 97);
            this.btn_penjualan.TabIndex = 7;
            this.btn_penjualan.Text = "Penjualan";
            this.btn_penjualan.UseVisualStyleBackColor = false;
            this.btn_penjualan.Click += new System.EventHandler(this.btn_sales_Click);
            // 
            // lb_ddmmyyyy
            // 
            this.lb_ddmmyyyy.AutoSize = true;
            this.lb_ddmmyyyy.BackColor = System.Drawing.Color.Transparent;
            this.lb_ddmmyyyy.Font = new System.Drawing.Font("Cambria", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ddmmyyyy.Location = new System.Drawing.Point(19, 31);
            this.lb_ddmmyyyy.Name = "lb_ddmmyyyy";
            this.lb_ddmmyyyy.Size = new System.Drawing.Size(315, 62);
            this.lb_ddmmyyyy.TabIndex = 9;
            this.lb_ddmmyyyy.Text = "Hari, tanggal";
            // 
            // lb_hhmm
            // 
            this.lb_hhmm.AutoSize = true;
            this.lb_hhmm.BackColor = System.Drawing.Color.Transparent;
            this.lb_hhmm.Font = new System.Drawing.Font("Cambria", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hhmm.Location = new System.Drawing.Point(382, 104);
            this.lb_hhmm.Name = "lb_hhmm";
            this.lb_hhmm.Size = new System.Drawing.Size(113, 62);
            this.lb_hhmm.TabIndex = 10;
            this.lb_hhmm.Text = "Jam";
            // 
            // panel_datetime
            // 
            this.panel_datetime.BackColor = System.Drawing.Color.White;
            this.panel_datetime.Controls.Add(this.lb_ddmmyyyy);
            this.panel_datetime.Controls.Add(this.lb_hhmm);
            this.panel_datetime.Location = new System.Drawing.Point(704, 318);
            this.panel_datetime.Name = "panel_datetime";
            this.panel_datetime.Size = new System.Drawing.Size(558, 193);
            this.panel_datetime.TabIndex = 11;
            this.panel_datetime.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_datetime_Paint);
            // 
            // panel_pesananBerjalan
            // 
            this.panel_pesananBerjalan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(186)))), ((int)(((byte)(68)))));
            this.panel_pesananBerjalan.Controls.Add(this.panel_jmlPesanan);
            this.panel_pesananBerjalan.Controls.Add(this.lb_berjalan);
            this.panel_pesananBerjalan.Controls.Add(this.lb_pesananSedang);
            this.panel_pesananBerjalan.Location = new System.Drawing.Point(704, 91);
            this.panel_pesananBerjalan.Name = "panel_pesananBerjalan";
            this.panel_pesananBerjalan.Size = new System.Drawing.Size(558, 185);
            this.panel_pesananBerjalan.TabIndex = 12;
            this.panel_pesananBerjalan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_pesananBerjalan_Paint);
            // 
            // panel_jmlPesanan
            // 
            this.panel_jmlPesanan.BackColor = System.Drawing.Color.White;
            this.panel_jmlPesanan.Controls.Add(this.lb_pesanan);
            this.panel_jmlPesanan.Controls.Add(this.lb_jml);
            this.panel_jmlPesanan.Location = new System.Drawing.Point(282, 48);
            this.panel_jmlPesanan.Name = "panel_jmlPesanan";
            this.panel_jmlPesanan.Size = new System.Drawing.Size(247, 86);
            this.panel_jmlPesanan.TabIndex = 2;
            this.panel_jmlPesanan.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_jmlPesanan_Paint);
            // 
            // lb_pesanan
            // 
            this.lb_pesanan.AutoSize = true;
            this.lb_pesanan.Font = new System.Drawing.Font("Cambria", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pesanan.Location = new System.Drawing.Point(62, 18);
            this.lb_pesanan.Name = "lb_pesanan";
            this.lb_pesanan.Size = new System.Drawing.Size(171, 43);
            this.lb_pesanan.TabIndex = 1;
            this.lb_pesanan.Text = "| Pesanan";
            // 
            // lb_jml
            // 
            this.lb_jml.AutoSize = true;
            this.lb_jml.Font = new System.Drawing.Font("Cambria", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jml.Location = new System.Drawing.Point(15, 18);
            this.lb_jml.Name = "lb_jml";
            this.lb_jml.Size = new System.Drawing.Size(59, 43);
            this.lb_jml.TabIndex = 0;
            this.lb_jml.Text = "20";
            // 
            // lb_berjalan
            // 
            this.lb_berjalan.AutoSize = true;
            this.lb_berjalan.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_berjalan.Location = new System.Drawing.Point(23, 97);
            this.lb_berjalan.Name = "lb_berjalan";
            this.lb_berjalan.Size = new System.Drawing.Size(142, 37);
            this.lb_berjalan.TabIndex = 1;
            this.lb_berjalan.Text = "Berjalan:";
            // 
            // lb_pesananSedang
            // 
            this.lb_pesananSedang.AutoSize = true;
            this.lb_pesananSedang.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_pesananSedang.Location = new System.Drawing.Point(23, 48);
            this.lb_pesananSedang.Name = "lb_pesananSedang";
            this.lb_pesananSedang.Size = new System.Drawing.Size(239, 37);
            this.lb_pesananSedang.TabIndex = 0;
            this.lb_pesananSedang.Text = "Pesanan Sedang";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(123)))), ((int)(((byte)(78)))));
            this.BackgroundImage = global::Jreng_Kitchen.Properties.Resources.Home_Page;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 889);
            this.Controls.Add(this.panel_pesananBerjalan);
            this.Controls.Add(this.panel_datetime);
            this.Controls.Add(this.btn_penjualan);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.btn_riwayat);
            this.Controls.Add(this.btn_produk);
            this.Controls.Add(this.btn_pesan);
            this.DoubleBuffered = true;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            this.panel_datetime.ResumeLayout(false);
            this.panel_datetime.PerformLayout();
            this.panel_pesananBerjalan.ResumeLayout(false);
            this.panel_pesananBerjalan.PerformLayout();
            this.panel_jmlPesanan.ResumeLayout(false);
            this.panel_jmlPesanan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_logo;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btn_pesan;
        private System.Windows.Forms.Button btn_produk;
        private System.Windows.Forms.Button btn_riwayat;
        private System.Windows.Forms.Button btn_penjualan;
        private System.Windows.Forms.Label lb_ddmmyyyy;
        private System.Windows.Forms.Label lb_hhmm;
        private System.Windows.Forms.Panel panel_datetime;
        private System.Windows.Forms.Panel panel_pesananBerjalan;
        private System.Windows.Forms.Label lb_pesananSedang;
        private System.Windows.Forms.Panel panel_jmlPesanan;
        private System.Windows.Forms.Label lb_pesanan;
        private System.Windows.Forms.Label lb_jml;
        private System.Windows.Forms.Label lb_berjalan;
    }
}

