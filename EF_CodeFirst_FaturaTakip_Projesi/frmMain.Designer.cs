namespace EF_CodeFirst_FaturaTakip_Projesi
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.yeniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.birimEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ilEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ilçeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniFaturaOluşturToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.faturaSorgulaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.faturaDetaylarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Khaki;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniToolStripMenuItem,
            this.faturaİşlemleriToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1099, 53);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // yeniToolStripMenuItem
            // 
            this.yeniToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünEkleToolStripMenuItem,
            this.birimEkleToolStripMenuItem,
            this.müşteriEkleToolStripMenuItem,
            this.toolStripSeparator1,
            this.ilEkleToolStripMenuItem,
            this.ilçeEkleToolStripMenuItem,
            this.toolStripSeparator2,
            this.çıkışToolStripMenuItem});
            this.yeniToolStripMenuItem.Name = "yeniToolStripMenuItem";
            this.yeniToolStripMenuItem.Size = new System.Drawing.Size(91, 49);
            this.yeniToolStripMenuItem.Text = "Yeni";
            // 
            // ürünEkleToolStripMenuItem
            // 
            this.ürünEkleToolStripMenuItem.Name = "ürünEkleToolStripMenuItem";
            this.ürünEkleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.ürünEkleToolStripMenuItem.Size = new System.Drawing.Size(363, 50);
            this.ürünEkleToolStripMenuItem.Text = "Ürün Ekle";
            this.ürünEkleToolStripMenuItem.Click += new System.EventHandler(this.ürünEkleToolStripMenuItem_Click);
            // 
            // birimEkleToolStripMenuItem
            // 
            this.birimEkleToolStripMenuItem.Name = "birimEkleToolStripMenuItem";
            this.birimEkleToolStripMenuItem.Size = new System.Drawing.Size(363, 50);
            this.birimEkleToolStripMenuItem.Text = "Birim Ekle";
            this.birimEkleToolStripMenuItem.Click += new System.EventHandler(this.birimEkleToolStripMenuItem_Click);
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(363, 50);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(360, 6);
            // 
            // ilEkleToolStripMenuItem
            // 
            this.ilEkleToolStripMenuItem.Name = "ilEkleToolStripMenuItem";
            this.ilEkleToolStripMenuItem.Size = new System.Drawing.Size(363, 50);
            this.ilEkleToolStripMenuItem.Text = "İl Ekle";
            this.ilEkleToolStripMenuItem.Click += new System.EventHandler(this.ilEkleToolStripMenuItem_Click);
            // 
            // ilçeEkleToolStripMenuItem
            // 
            this.ilçeEkleToolStripMenuItem.Name = "ilçeEkleToolStripMenuItem";
            this.ilçeEkleToolStripMenuItem.Size = new System.Drawing.Size(363, 50);
            this.ilçeEkleToolStripMenuItem.Text = "İlçe Ekle";
            this.ilçeEkleToolStripMenuItem.Click += new System.EventHandler(this.ilçeEkleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(360, 6);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(363, 50);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // faturaİşlemleriToolStripMenuItem
            // 
            this.faturaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniFaturaOluşturToolStripMenuItem,
            this.toolStripSeparator3,
            this.faturaSorgulaToolStripMenuItem,
            this.faturaDetaylarToolStripMenuItem});
            this.faturaİşlemleriToolStripMenuItem.Name = "faturaİşlemleriToolStripMenuItem";
            this.faturaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(251, 49);
            this.faturaİşlemleriToolStripMenuItem.Text = "Fatura İşlemleri";
            // 
            // yeniFaturaOluşturToolStripMenuItem
            // 
            this.yeniFaturaOluşturToolStripMenuItem.Name = "yeniFaturaOluşturToolStripMenuItem";
            this.yeniFaturaOluşturToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.yeniFaturaOluşturToolStripMenuItem.Size = new System.Drawing.Size(489, 50);
            this.yeniFaturaOluşturToolStripMenuItem.Text = "Yeni Fatura Oluştur";
            this.yeniFaturaOluşturToolStripMenuItem.Click += new System.EventHandler(this.yeniFaturaOluşturToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(486, 6);
            // 
            // faturaSorgulaToolStripMenuItem
            // 
            this.faturaSorgulaToolStripMenuItem.Name = "faturaSorgulaToolStripMenuItem";
            this.faturaSorgulaToolStripMenuItem.Size = new System.Drawing.Size(489, 50);
            this.faturaSorgulaToolStripMenuItem.Text = "Fatura Sorgula";
            this.faturaSorgulaToolStripMenuItem.Click += new System.EventHandler(this.faturaSorgulaToolStripMenuItem_Click);
            // 
            // faturaDetaylarToolStripMenuItem
            // 
            this.faturaDetaylarToolStripMenuItem.Name = "faturaDetaylarToolStripMenuItem";
            this.faturaDetaylarToolStripMenuItem.Size = new System.Drawing.Size(489, 50);
            this.faturaDetaylarToolStripMenuItem.Text = "Fatura Detaylar";
            this.faturaDetaylarToolStripMenuItem.Click += new System.EventHandler(this.faturaDetaylarToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1099, 649);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Fatura Takip Projesine Hoşgeldiniz";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yeniToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ürünEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem birimEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ilEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ilçeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniFaturaOluşturToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem faturaSorgulaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem faturaDetaylarToolStripMenuItem;
    }
}

