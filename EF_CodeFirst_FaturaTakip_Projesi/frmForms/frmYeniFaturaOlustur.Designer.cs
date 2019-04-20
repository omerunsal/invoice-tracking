namespace EF_CodeFirst_FaturaTakip_Projesi.frmForms
{
    partial class frmYeniFaturaOlustur
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
            this.btnFaturaKaydet = new System.Windows.Forms.Button();
            this.txtIrsaliyeNo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblFaturaID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMusteriUnvani = new System.Windows.Forms.ComboBox();
            this.cbMusteriIlcesi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMusteriIli = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nudUrunMiktari = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbUrunAdi = new System.Windows.Forms.ComboBox();
            this.txtUrunFiyati = new System.Windows.Forms.TextBox();
            this.txtKDV = new System.Windows.Forms.TextBox();
            this.txtUrunBirimi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFaturaToplami = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnListeriTemizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunMiktari)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFaturaKaydet
            // 
            this.btnFaturaKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFaturaKaydet.Location = new System.Drawing.Point(12, 293);
            this.btnFaturaKaydet.Name = "btnFaturaKaydet";
            this.btnFaturaKaydet.Size = new System.Drawing.Size(536, 37);
            this.btnFaturaKaydet.TabIndex = 33;
            this.btnFaturaKaydet.Text = "Faturayı Kaydet";
            this.btnFaturaKaydet.UseVisualStyleBackColor = true;
            this.btnFaturaKaydet.Click += new System.EventHandler(this.btnFaturaKaydet_Click);
            // 
            // txtIrsaliyeNo
            // 
            this.txtIrsaliyeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIrsaliyeNo.Location = new System.Drawing.Point(189, 185);
            this.txtIrsaliyeNo.Name = "txtIrsaliyeNo";
            this.txtIrsaliyeNo.Size = new System.Drawing.Size(324, 34);
            this.txtIrsaliyeNo.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Khaki;
            this.groupBox1.Controls.Add(this.dtpOdemeTarihi);
            this.groupBox1.Controls.Add(this.lblFaturaID);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMusteriUnvani);
            this.groupBox1.Controls.Add(this.cbMusteriIlcesi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbMusteriIli);
            this.groupBox1.Controls.Add(this.txtIrsaliyeNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(536, 275);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri ve İrsaliye İşlemleri";
            // 
            // dtpOdemeTarihi
            // 
            this.dtpOdemeTarihi.CustomFormat = "dd/MM/yyyy";
            this.dtpOdemeTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpOdemeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpOdemeTarihi.Location = new System.Drawing.Point(189, 224);
            this.dtpOdemeTarihi.Name = "dtpOdemeTarihi";
            this.dtpOdemeTarihi.Size = new System.Drawing.Size(324, 30);
            this.dtpOdemeTarihi.TabIndex = 39;
            // 
            // lblFaturaID
            // 
            this.lblFaturaID.AutoSize = true;
            this.lblFaturaID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaturaID.Location = new System.Drawing.Point(184, 24);
            this.lblFaturaID.Name = "lblFaturaID";
            this.lblFaturaID.Size = new System.Drawing.Size(0, 25);
            this.lblFaturaID.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 29);
            this.label6.TabIndex = 38;
            this.label6.Text = "Ödeme Tarihi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 29);
            this.label5.TabIndex = 38;
            this.label5.Text = "İrsaliye No:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "Müşteri Ünvanı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "Müşteri İlçesi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 38;
            this.label2.Text = "Müşteri İli:";
            // 
            // cbMusteriUnvani
            // 
            this.cbMusteriUnvani.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMusteriUnvani.FormattingEnabled = true;
            this.cbMusteriUnvani.Location = new System.Drawing.Point(189, 142);
            this.cbMusteriUnvani.Name = "cbMusteriUnvani";
            this.cbMusteriUnvani.Size = new System.Drawing.Size(324, 37);
            this.cbMusteriUnvani.TabIndex = 30;
            this.cbMusteriUnvani.Text = "-Seciniz-";
            // 
            // cbMusteriIlcesi
            // 
            this.cbMusteriIlcesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMusteriIlcesi.FormattingEnabled = true;
            this.cbMusteriIlcesi.Location = new System.Drawing.Point(189, 98);
            this.cbMusteriIlcesi.Name = "cbMusteriIlcesi";
            this.cbMusteriIlcesi.Size = new System.Drawing.Size(324, 37);
            this.cbMusteriIlcesi.TabIndex = 30;
            this.cbMusteriIlcesi.Text = "-Seciniz-";
            this.cbMusteriIlcesi.SelectedIndexChanged += new System.EventHandler(this.cbMusteriIlcesi_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Fatura No:";
            // 
            // cbMusteriIli
            // 
            this.cbMusteriIli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMusteriIli.FormattingEnabled = true;
            this.cbMusteriIli.Location = new System.Drawing.Point(189, 56);
            this.cbMusteriIli.Name = "cbMusteriIli";
            this.cbMusteriIli.Size = new System.Drawing.Size(324, 37);
            this.cbMusteriIli.TabIndex = 30;
            this.cbMusteriIli.Text = "-Seciniz-";
            this.cbMusteriIli.SelectedIndexChanged += new System.EventHandler(this.cbMusteriIli_SelectedIndexChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Khaki;
            this.groupBox2.Controls.Add(this.nudUrunMiktari);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cbUrunAdi);
            this.groupBox2.Controls.Add(this.txtUrunFiyati);
            this.groupBox2.Controls.Add(this.txtKDV);
            this.groupBox2.Controls.Add(this.txtUrunBirimi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(554, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(536, 275);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // nudUrunMiktari
            // 
            this.nudUrunMiktari.Location = new System.Drawing.Point(189, 185);
            this.nudUrunMiktari.Name = "nudUrunMiktari";
            this.nudUrunMiktari.Size = new System.Drawing.Size(324, 34);
            this.nudUrunMiktari.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 29);
            this.label8.TabIndex = 38;
            this.label8.Text = "Ürün Miktarı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 29);
            this.label9.TabIndex = 38;
            this.label9.Text = "Ürün KDV:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 29);
            this.label10.TabIndex = 38;
            this.label10.Text = "Ürün Birimi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(133, 29);
            this.label11.TabIndex = 38;
            this.label11.Text = "Ürün Fiyatı:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 29);
            this.label12.TabIndex = 38;
            this.label12.Text = "Ürün Adı:";
            // 
            // cbUrunAdi
            // 
            this.cbUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUrunAdi.FormattingEnabled = true;
            this.cbUrunAdi.Location = new System.Drawing.Point(189, 22);
            this.cbUrunAdi.Name = "cbUrunAdi";
            this.cbUrunAdi.Size = new System.Drawing.Size(324, 37);
            this.cbUrunAdi.TabIndex = 30;
            this.cbUrunAdi.Text = "-Seciniz-";
            this.cbUrunAdi.SelectedIndexChanged += new System.EventHandler(this.cbUrunAdi_SelectedIndexChanged_1);
            // 
            // txtUrunFiyati
            // 
            this.txtUrunFiyati.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUrunFiyati.Enabled = false;
            this.txtUrunFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrunFiyati.Location = new System.Drawing.Point(189, 64);
            this.txtUrunFiyati.Name = "txtUrunFiyati";
            this.txtUrunFiyati.Size = new System.Drawing.Size(324, 34);
            this.txtUrunFiyati.TabIndex = 29;
            // 
            // txtKDV
            // 
            this.txtKDV.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtKDV.Enabled = false;
            this.txtKDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKDV.Location = new System.Drawing.Point(189, 144);
            this.txtKDV.Name = "txtKDV";
            this.txtKDV.Size = new System.Drawing.Size(324, 34);
            this.txtKDV.TabIndex = 29;
            // 
            // txtUrunBirimi
            // 
            this.txtUrunBirimi.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtUrunBirimi.Enabled = false;
            this.txtUrunBirimi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUrunBirimi.Location = new System.Drawing.Point(189, 104);
            this.txtUrunBirimi.Name = "txtUrunBirimi";
            this.txtUrunBirimi.Size = new System.Drawing.Size(324, 34);
            this.txtUrunBirimi.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(759, 725);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 29);
            this.label7.TabIndex = 40;
            this.label7.Text = "Fatura Toplamı:";
            // 
            // lblFaturaToplami
            // 
            this.lblFaturaToplami.AutoSize = true;
            this.lblFaturaToplami.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaturaToplami.Location = new System.Drawing.Point(947, 725);
            this.lblFaturaToplami.Name = "lblFaturaToplami";
            this.lblFaturaToplami.Size = new System.Drawing.Size(0, 29);
            this.lblFaturaToplami.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 725);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(525, 32);
            this.label13.TabIndex = 41;
            this.label13.Text = "Müşteri Ünvanı Seçip Fatura Kesiniz..";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 336);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1078, 386);
            this.listView1.TabIndex = 42;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Miktari";
            this.columnHeader3.Width = 116;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "KDV";
            this.columnHeader4.Width = 63;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "KDV\'li Fiyatı";
            this.columnHeader5.Width = 136;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Toplam Fiyat";
            this.columnHeader6.Width = 160;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.Location = new System.Drawing.Point(554, 293);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(117, 37);
            this.btnEkle.TabIndex = 43;
            this.btnEkle.Text = "Ürün Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.Location = new System.Drawing.Point(691, 293);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(148, 37);
            this.btnSil.TabIndex = 43;
            this.btnSil.Text = "Ürün Çıkar";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click_1);
            // 
            // btnListeriTemizle
            // 
            this.btnListeriTemizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListeriTemizle.Location = new System.Drawing.Point(860, 293);
            this.btnListeriTemizle.Name = "btnListeriTemizle";
            this.btnListeriTemizle.Size = new System.Drawing.Size(230, 37);
            this.btnListeriTemizle.TabIndex = 43;
            this.btnListeriTemizle.Text = "Listeleri Temizle";
            this.btnListeriTemizle.UseVisualStyleBackColor = true;
            this.btnListeriTemizle.Click += new System.EventHandler(this.btnListeriTemizle_Click);
            // 
            // frmYeniFaturaOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(1110, 758);
            this.Controls.Add(this.btnListeriTemizle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblFaturaToplami);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFaturaKaydet);
            this.Name = "frmYeniFaturaOlustur";
            this.Text = "Yeni Fatura Formu";
            this.Load += new System.EventHandler(this.frmYeniFaturaOlustur_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUrunMiktari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFaturaKaydet;
        private System.Windows.Forms.TextBox txtIrsaliyeNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpOdemeTarihi;
        private System.Windows.Forms.Label lblFaturaID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMusteriUnvani;
        private System.Windows.Forms.ComboBox cbMusteriIlcesi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMusteriIli;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbUrunAdi;
        private System.Windows.Forms.TextBox txtUrunBirimi;
        private System.Windows.Forms.TextBox txtUrunFiyati;
        private System.Windows.Forms.TextBox txtKDV;
        private System.Windows.Forms.NumericUpDown nudUrunMiktari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFaturaToplami;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnListeriTemizle;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}