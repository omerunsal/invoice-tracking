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
    public partial class frmUrun : Form
    {
        public frmUrun()
        {
            InitializeComponent();
        }
        FaturaContext db = new FaturaContext();
        private void frmUrun_Load(object sender, EventArgs e)
        {
            urunListele();
            birimAdiListele();
        }

        private void birimAdiListele()
        {
            var list = db.Birimler.Select
           (b => new
           {
               b.BirimID,
               b.BirimAdi
           }
           ).ToList();

            cbBirim.DataSource = list;
            cbBirim.DisplayMember = "BirimAdi";
            cbBirim.ValueMember = "BirimID";
        }

        private void urunListele()
        {
            var list = db.Urunler.Select
            (b => new
            {
                b.UrunID,
                b.UrunAdi,
                b.UrunKodu,
                b.BirimFiyati
            }
            ).ToList();

            dgwVeriler.DataSource = list;

            txtBirimFiyati.Clear();
            txtUrunAdi.Clear();
            txtUrunKodu.Clear();
            //cbBirim.SelectedIndex = 0;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = new Urun();
                urun.UrunAdi = txtUrunAdi.Text;
                urun.UrunKodu = Convert.ToInt32(txtUrunKodu.Text);
                urun.BirimFiyati = Convert.ToDecimal(txtBirimFiyati.Text);
                urun.BirimID = secilenID;
                
                db.Urunler.Add(urun);
                db.SaveChanges();

                urunListele();
                Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz!" + ex.InnerException.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = db.Urunler.Find(UrunSecilenID); 
                urun.UrunAdi = txtUrunAdi.Text;
                urun.UrunKodu = Convert.ToInt32(txtUrunKodu.Text);
                urun.BirimFiyati = Convert.ToDecimal(txtBirimFiyati.Text);
                urun.BirimID = secilenID;
                db.SaveChanges();
                urunListele();
                Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Güncellenecek Ürünü Seçiniz!" + ex.InnerException.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Urun urun = db.Urunler.Find(UrunSecilenID);
                db.Urunler.Remove(urun);
                db.SaveChanges();
                urunListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen silmek istediğiniz Ürünü seçiniz!" + ex.Message); ;
            }
        }
        int secilenID;
        private void cbBirim_SelectionChangeCommitted(object sender, EventArgs e)
        {
            secilenID = Convert.ToInt32(cbBirim.SelectedValue);
        }
        int UrunSecilenID;
        private void dgwVeriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UrunSecilenID = Convert.ToInt32(dgwVeriler.CurrentRow.Cells[0].Value);  

            Urun xUrun = db.Urunler.Find(UrunSecilenID);
            txtBirimFiyati.Text = xUrun.BirimFiyati.ToString();
            txtUrunAdi.Text = xUrun.UrunAdi;
            txtUrunKodu.Text = xUrun.UrunKodu.ToString();
            cbBirim.SelectedValue = xUrun.BirimID;
            
        }
    }
}
