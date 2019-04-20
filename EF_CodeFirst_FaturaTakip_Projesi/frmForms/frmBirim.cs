using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CodeFirst_FaturaTakip_Projesi.frmForms
{
    public partial class frmBirim : Form
    {
        public frmBirim()
        {
            InitializeComponent();
        }

        FaturaContext db = new FaturaContext();

        private void frmBirim_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void listele()
        {
            var list = db.Birimler.Select
            (b => new
            {
                BirimKodu = b.BirimID,
                b.BirimAdi
            }
            ).ToList();

            dgwVeriler.DataSource = list;

            txtBirimAdi.Clear();
            txtBirimAdi.Focus();
                
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Birim birim = new Birim();
                birim.BirimAdi = txtBirimAdi.Text;
                db.Birimler.Add(birim);
                db.SaveChanges();

                listele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen birim adı giriniz!" + ex.InnerException.Message);
            }
        }

        int secilenID; 

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Birim birim = db.Birimler.Find(secilenID);
                birim.BirimAdi = txtBirimAdi.Text;

                db.SaveChanges();

                listele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen Güncellenecek Birimi Seçiniz!" + ex.InnerException.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Birim birim = db.Birimler.Find(secilenID);
                db.Birimler.Remove(birim);
                db.SaveChanges();
                listele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen silmek istediğiniz birimi seçiniz!"+ex.Message);;
            }

        }

        private void dgwVeriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            secilenID = Convert.ToInt32(dgwVeriler.CurrentRow.Cells[0].Value);  

            Birim xBirim = db.Birimler.Find(secilenID);
            txtBirimAdi.Text = xBirim.BirimAdi;
        }
    }
}
