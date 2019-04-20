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
    public partial class frmYeniFaturaOlustur : Form
    {
        public frmYeniFaturaOlustur()
        {
            InitializeComponent();
        }


        List<FaturaDetay> faturaDetays = new List<FaturaDetay>();

        private void FaturaDetayListele()
        {
            listView1.Items.Clear();
            foreach (FaturaDetay d in faturaDetays)
            {
                ListViewItem lItem = new ListViewItem();
                lItem.Text = d.UrunID.ToString();
                lItem.SubItems.Add(d.urun.UrunAdi);
                lItem.SubItems.Add(d.Miktar.ToString());
                lItem.SubItems.Add(d.KDV.ToString());
                lItem.SubItems.Add(d.KDVliFiyat.ToString());
                lItem.SubItems.Add(d.ToplamFiyat.ToString());
                lItem.SubItems.Add(d.Aciklama.ToString());
                listView1.Items.Add(lItem);
            }
            lblFaturaToplami.Text = faturaDetays.Sum(x => x.ToplamFiyat).ToString();
        }

        private void FaturayaurunEkle(FaturaDetay model)
        {
            var f = faturaDetays.Where(x => x.UrunID == model.UrunID);
            if (f.Count() == 0)
            {
                faturaDetays.Add(model);
            }
            else
            {
                FaturaDetay d = f.Single();
                d.Miktar += model.Miktar;
                d.ToplamFiyat = d.Miktar * d.KDVliFiyat;
            }
            FaturaDetayListele();
        }

        private void FaturayaurunSil(int id)
        {
            faturaDetays.Remove(faturaDetays.Where(x => x.UrunID == id).Single());
            FaturaDetayListele();
        }
        
        
        private void frmYeniFaturaOlustur_Load_1(object sender, EventArgs e)
        {
            using (FaturaContext db1 = new FaturaContext())
            {
                cbMusteriIli.DataSource = db1.Iller.ToList();
                cbMusteriIli.DisplayMember = "IlAdi";
                cbMusteriIli.ValueMember = "IlID";
            }

            FaturaContext db = new FaturaContext();
            cbUrunAdi.DataSource = db.Urunler.ToList();
            cbUrunAdi.DisplayMember = "urunAdi";
            cbUrunAdi.ValueMember = "urunID";
        }

        private void cbMusteriIli_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbMusteriIli.SelectedIndex != -1)
            {
                using (FaturaContext dbIlce = new FaturaContext())
                {
                    Il secilen = (cbMusteriIli.SelectedItem as Il);
                    cbMusteriIlcesi.Text = string.Empty;
                    cbMusteriIlcesi.DataSource = dbIlce.Ilceler.Where(x => x.IlID == secilen.IlID).ToList();
                    cbMusteriIlcesi.DisplayMember = "IlceAdi";
                    cbMusteriIlcesi.ValueMember = "IlceAdi";
                }

            }
        }

        private void cbUrunAdi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cbUrunAdi.SelectedIndex != -1)
            {
                Urun secilen = (cbUrunAdi.SelectedItem as Urun);
                txtUrunBirimi.Text = secilen.birim.BirimAdi;
                txtUrunFiyati.Text = secilen.BirimFiyati.ToString();
                txtKDV.Text = "%18";
            }
        }

        private void cbMusteriIlcesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMusteriIlcesi.SelectedIndex != -1)
            {
                using (FaturaContext dbIlce = new FaturaContext())
                {
                    Ilce secilen = (cbMusteriIlcesi.SelectedItem as Ilce);
                    cbMusteriUnvani.Text = string.Empty;
                    cbMusteriUnvani.DataSource = dbIlce.Musteriler.Where(x => x.IlceID == secilen.IlceID).ToList();
                    cbMusteriUnvani.DisplayMember = "MusteriUnvani";
                }
            }

        }

        private void btnFaturaKaydet_Click(object sender, EventArgs e)
        {
            Musteri musteri = cbMusteriUnvani.SelectedItem as Musteri;
            if (musteri == null)
            {
                MessageBox.Show("Müşteri seçmediniz!");
                return;
            }

            if (txtIrsaliyeNo.Text.Length == 0)
            {
                MessageBox.Show("İrsaliye No seçmediniz!");
                return;
            }

            if (faturaDetays.Count == 0)
            {
                MessageBox.Show("Faturaya ürün eklemediniz!");
                return;
            }

            FaturaMaster fatura = new FaturaMaster();
            fatura.FaturaTarihi = DateTime.Now;
            fatura.OdemeTarihi = dtpOdemeTarihi.Value;
            fatura.MusteriID = musteri.MusteriID;
            fatura.IrsaliyeNo = int.Parse(txtIrsaliyeNo.Text);

            using (FaturaContext db = new FaturaContext())
            {
                db.faturaMasters.Add(fatura);
                try
                {
                    db.SaveChanges();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                    return;
                }
            }



            using (FaturaContext db = new FaturaContext())
            {
                foreach (FaturaDetay d in faturaDetays)
                {
                    d.FaturaID = fatura.FaturaID;
                    db.faturaDetays.Add(new FaturaDetay()
                    {
                        FaturaID = fatura.FaturaID,
                        UrunID = d.UrunID,
                        Miktar = d.Miktar,
                        KDV = d.KDV,
                        KDVliFiyat = d.KDVliFiyat,
                        ToplamFiyat = d.ToplamFiyat,
                        Aciklama = d.Aciklama
                    });
                }

                try
                {
                    db.SaveChanges();
                    MessageBox.Show("Fatura Oluşturuldu");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }

        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            int Adet;
            try
            {
                Adet = int.Parse(nudUrunMiktari.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }

            if (cbUrunAdi.SelectedIndex == -1)
                return;

            Urun secilen = (cbUrunAdi.SelectedItem as Urun);

            FaturayaurunEkle(new FaturaDetay()
            {
                urun = secilen,
                UrunID = (int)cbUrunAdi.SelectedValue,
                Miktar = Adet,
                KDV = 18,
                KDVliFiyat = ((18 / 100) * secilen.BirimFiyati) + secilen.BirimFiyati,
                ToplamFiyat = (((18 / 100) * secilen.BirimFiyati) + secilen.BirimFiyati) * Adet,
                Aciklama = ""
            });
            FaturaDetayListele();
        }

        private void btnSil_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count != 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    FaturayaurunSil(int.Parse(item.Text));
                }
            }
        }

        private void btnListeriTemizle_Click(object sender, EventArgs e)
        {
            faturaDetays.Clear();
            listView1.Items.Clear();
            lblFaturaToplami.Text = "0";
        }
    }
}

