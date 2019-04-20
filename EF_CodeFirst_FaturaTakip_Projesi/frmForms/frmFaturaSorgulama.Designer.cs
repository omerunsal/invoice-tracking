namespace EF_CodeFirst_FaturaTakip_Projesi.frmForms
{
    partial class frmFaturaSorgulama
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgwVeriler = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbMusteriIli = new System.Windows.Forms.ComboBox();
            this.cbMusteriIlce = new System.Windows.Forms.ComboBox();
            this.cbMusteriUnvani = new System.Windows.Forms.ComboBox();
            this.lblFaturaID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtFaturaNo = new System.Windows.Forms.TextBox();
            this.btnSiparisleriGoster = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwVeriler)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 32);
            this.label4.TabIndex = 32;
            this.label4.Text = "Müşteri İli:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(212, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "Müşteri Ünvanı:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 90);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(188, 32);
            this.label13.TabIndex = 34;
            this.label13.Text = "Müşteri İlçesi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 29);
            this.label1.TabIndex = 38;
            this.label1.Text = "Fatura No:";
            // 
            // dgwVeriler
            // 
            this.dgwVeriler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwVeriler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgwVeriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwVeriler.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgwVeriler.Location = new System.Drawing.Point(12, 210);
            this.dgwVeriler.Name = "dgwVeriler";
            this.dgwVeriler.RowTemplate.Height = 24;
            this.dgwVeriler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwVeriler.Size = new System.Drawing.Size(980, 349);
            this.dgwVeriler.TabIndex = 48;
            this.dgwVeriler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwVeriler_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox3.Controls.Add(this.cbMusteriIli);
            this.groupBox3.Controls.Add(this.cbMusteriIlce);
            this.groupBox3.Controls.Add(this.cbMusteriUnvani);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(465, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 182);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Müşteri Bilgileri";
            // 
            // cbMusteriIli
            // 
            this.cbMusteriIli.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMusteriIli.FormattingEnabled = true;
            this.cbMusteriIli.Location = new System.Drawing.Point(224, 40);
            this.cbMusteriIli.Name = "cbMusteriIli";
            this.cbMusteriIli.Size = new System.Drawing.Size(281, 37);
            this.cbMusteriIli.TabIndex = 35;
            this.cbMusteriIli.Text = "-Seciniz-";
            // 
            // cbMusteriIlce
            // 
            this.cbMusteriIlce.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMusteriIlce.FormattingEnabled = true;
            this.cbMusteriIlce.Location = new System.Drawing.Point(224, 83);
            this.cbMusteriIlce.Name = "cbMusteriIlce";
            this.cbMusteriIlce.Size = new System.Drawing.Size(281, 37);
            this.cbMusteriIlce.TabIndex = 35;
            this.cbMusteriIlce.Text = "-Seciniz-";
            // 
            // cbMusteriUnvani
            // 
            this.cbMusteriUnvani.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMusteriUnvani.FormattingEnabled = true;
            this.cbMusteriUnvani.Location = new System.Drawing.Point(224, 126);
            this.cbMusteriUnvani.Name = "cbMusteriUnvani";
            this.cbMusteriUnvani.Size = new System.Drawing.Size(281, 37);
            this.cbMusteriUnvani.TabIndex = 35;
            this.cbMusteriUnvani.Text = "-Seciniz-";
            this.cbMusteriUnvani.SelectionChangeCommitted += new System.EventHandler(this.cbMusteriUnvani_SelectionChangeCommitted);
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblFaturaID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFaturaNo);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 106);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fatura ID ile Sorgulama";
            // 
            // txtFaturaNo
            // 
            this.txtFaturaNo.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFaturaNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFaturaNo.Location = new System.Drawing.Point(137, 52);
            this.txtFaturaNo.Name = "txtFaturaNo";
            this.txtFaturaNo.Size = new System.Drawing.Size(241, 28);
            this.txtFaturaNo.TabIndex = 29;
            
            // 
            // btnSiparisleriGoster
            // 
            this.btnSiparisleriGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiparisleriGoster.Location = new System.Drawing.Point(12, 138);
            this.btnSiparisleriGoster.Name = "btnSiparisleriGoster";
            this.btnSiparisleriGoster.Size = new System.Drawing.Size(447, 56);
            this.btnSiparisleriGoster.TabIndex = 54;
            this.btnSiparisleriGoster.Text = "Siparişi Göster";
            this.btnSiparisleriGoster.UseVisualStyleBackColor = true;
            this.btnSiparisleriGoster.Click += new System.EventHandler(this.btnSiparisleriGoster_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 562);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(896, 29);
            this.label2.TabIndex = 55;
            this.label2.Text = "FaturaID girip sipariş göster butonuna tıklayınız veya müşteri ünvanı seçiniz..";
            // 
            // frmFaturaSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(1007, 598);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSiparisleriGoster);
            this.Controls.Add(this.dgwVeriler);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFaturaSorgulama";
            this.Text = "Fatura Sorgulama İşlemleri";
            this.Load += new System.EventHandler(this.frmFaturaSorgulama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwVeriler)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwVeriler;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblFaturaID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFaturaNo;
        private System.Windows.Forms.ComboBox cbMusteriIli;
        private System.Windows.Forms.ComboBox cbMusteriIlce;
        private System.Windows.Forms.ComboBox cbMusteriUnvani;
        private System.Windows.Forms.Button btnSiparisleriGoster;
        private System.Windows.Forms.Label label2;
    }
}