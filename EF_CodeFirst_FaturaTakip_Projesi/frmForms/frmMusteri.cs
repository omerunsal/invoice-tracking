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
    public partial class frmMusteri : Form
    {
        public frmMusteri()
        {
            InitializeComponent();
        }

        FaturaContext db = new FaturaContext();

        private void frmMusteri_Load(object sender, EventArgs e)
        {
            musteriVeriListele();
            Illistele();
            Ilcelistele();
        }

        private void Illistele()
        {
            var list = db.Iller.Select
           (b => new
           {
               IlKodu = b.IlID,
               b.IlAdi
           }
           ).ToList();

            cbMusteriIli.DataSource = list;
            cbMusteriIli.DisplayMember = "IlAdi";
            cbMusteriIli.ValueMember = "IlKodu";
        }

        private void Ilcelistele()
        {
            var list = db.Ilceler.Select
            (b => new
            {
                b.IlceID,
                b.IlceAdi
            }
            ).ToList();

            cbMusteriIlcesi.DataSource = list;
            cbMusteriIlcesi.DisplayMember = "IlceAdi";
            cbMusteriIlcesi.ValueMember = "IlceID";
        }

        private void musteriVeriListele()
        {
            var list = db.Musteriler.Select
           (b => new
           {
               b.MusteriID,
               b.MusteriUnvani,b.MusteriAdresi
           }
           ).ToList();

            dgwVeriler.DataSource = list;

            txtMusteriAdresi.Clear();
            txtMusteriUnvani.Clear();
            txtMusteriUnvani.Focus();
        }
        int secilenID;
        private void cbMusteriIli_SelectionChangeCommitted(object sender, EventArgs e)
        {
            secilenID = Convert.ToInt32(cbMusteriIli.SelectedValue);

            var list = (from ilce in db.Ilceler where (ilce.IlID == secilenID) select new { ilce.IlceID, ilce.IlceAdi }).ToList();

            cbMusteriIlcesi.DataSource = list;
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri musteri = new Musteri();
                musteri.MusteriUnvani = txtMusteriUnvani.Text;
                musteri.MusteriAdresi = txtMusteriAdresi.Text;
                musteri.IlceID = XsecilenID;
                db.Musteriler.Add(musteri);
                db.SaveChanges();

                musteriVeriListele();
                Refresh();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz!" + ex.InnerException.Message);
            }
        }
        int XsecilenID;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri musteri = db.Musteriler.Find(MusteriSecilenID); 
                musteri.MusteriAdresi = txtMusteriAdresi.Text;
                musteri.MusteriUnvani = txtMusteriUnvani.Text;
                musteri.IlceID = Convert.ToInt32(cbMusteriIlcesi.SelectedValue);
                db.SaveChanges();

                musteriVeriListele();
                Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Güncellenecek Müşteriyi Seçiniz!" + ex.InnerException.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Musteri musteri = db.Musteriler.Find(MusteriSecilenID);
                db.Musteriler.Remove(musteri);
                db.SaveChanges();
                musteriVeriListele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen silmek istediğiniz Müşteriyi seçiniz!" + ex.Message); ;
            }
        }

        private void cbMusteriIlcesi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            XsecilenID = Convert.ToInt32(cbMusteriIlcesi.SelectedValue);
            
        }
        int MusteriSecilenID;
        private void dgwVeriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MusteriSecilenID = Convert.ToInt32(dgwVeriler.CurrentRow.Cells[0].Value);  

            Musteri xMusteri = db.Musteriler.Find(MusteriSecilenID);
            txtMusteriAdresi.Text = xMusteri.MusteriAdresi;
            txtMusteriUnvani.Text = xMusteri.MusteriUnvani;
            cbMusteriIlcesi.SelectedValue = xMusteri.IlceID;
            cbMusteriIli.SelectedValue = xMusteri.ilce.IlID;
            
        }
    }
}
