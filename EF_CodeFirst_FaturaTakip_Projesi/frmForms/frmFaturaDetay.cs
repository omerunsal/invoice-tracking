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
    public partial class frmFaturaDetay : Form
    {
        public frmFaturaDetay()
        {
            InitializeComponent();
        }

        private void frmFaturaDetay_Load(object sender, EventArgs e)
        {
            listele();
        }
        FaturaContext db = new FaturaContext();
        private void listele()
        {
             var list = db.faturaDetays.Select(f => new { f.FaturaID, FaturaBasımTarihi = f.faturaMaster.FaturaTarihi, f.faturaMaster.IrsaliyeNo, f.faturaMaster.OdemeTarihi, f.faturaMaster.musteri.ilce.il.IlAdi, f.faturaMaster.musteri.ilce.IlceAdi, f.faturaMaster.musteri.MusteriUnvani, f.urun.UrunAdi, f.urun.BirimFiyati, f.urun.birim.BirimAdi, f.KDV, f.KDVliFiyat, f.Miktar, f.ToplamFiyat }).ToList();

              dgwVeriler.DataSource = list;
        }
        int faturaSecilenID;
        private void dgwVeriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            faturaSecilenID = Convert.ToInt32(dgwVeriler.CurrentRow.Cells[0].Value);  

            FaturaMaster xFatura = db.faturaMasters.Find(faturaSecilenID);
            txtIrsaliyeNo.Text = xFatura.IrsaliyeNo.ToString();
            txtMusteriIlcesi.Text = xFatura.musteri.ilce.IlceAdi;
            txtMusteriIli.Text = xFatura.musteri.ilce.il.IlAdi;
            txtMusteriUnvani.Text = xFatura.musteri.MusteriUnvani;
            dtpFaturaTarihi.Value = xFatura.FaturaTarihi;
            dtpOdemeTarihi.Value = xFatura.OdemeTarihi;
            
        }
    }
}
