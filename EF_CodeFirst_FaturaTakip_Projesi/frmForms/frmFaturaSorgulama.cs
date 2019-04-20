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
    public partial class frmFaturaSorgulama : Form
    {
        public frmFaturaSorgulama()
        {
            InitializeComponent();
        }
        FaturaContext db = new FaturaContext();
        int faturaID;
        private void btnSiparisleriGoster_Click(object sender, EventArgs e)
        {
            if (txtFaturaNo != null)
            {
                try
                {
                    if (txtFaturaNo != null)
                    {
                        faturaID = Convert.ToInt32(txtFaturaNo.Text);
                        var list = (from fatura in db.faturaMasters where (fatura.FaturaID == faturaID) select new { fatura.FaturaID, fatura.FaturaTarihi, fatura.IrsaliyeNo, fatura.OdemeTarihi }).ToList();
                        dgwVeriler.DataSource = list;
                    }
                    else
                    {
                        MessageBox.Show("Fatura No giriniz veya Müşteri Ünvanı seçiniz!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                dgwVeriler.Rows.Clear();
            }

        }

        private void frmFaturaSorgulama_Load(object sender, EventArgs e)
        {
            musteriVeriListele();

        }

        private void musteriVeriListele()
        {
            var list = db.Musteriler.Select
          (b => new
          {
              b.MusteriID,
              b.MusteriUnvani,
              b.MusteriAdresi
          }
          ).ToList();

            cbMusteriUnvani.DataSource = list;
            cbMusteriUnvani.ValueMember = "MusteriID";
            cbMusteriUnvani.DisplayMember = "MusteriUnvani";

        }
        int musteriSecilen;
        private void cbMusteriUnvani_SelectionChangeCommitted(object sender, EventArgs e)
        {
           musteriSecilen  = Convert.ToInt32(cbMusteriUnvani.SelectedValue);
            var list = (from musteri in db.Musteriler where (musteri.MusteriID == musteriSecilen) select new {musteri.IlceID, musteri.ilce.IlceAdi }).ToList();
            var il = (from musteri in db.Musteriler where (musteri.MusteriID == musteriSecilen) select new { musteri.ilce.il.IlID,musteri.ilce.il.IlAdi}).ToList();

            cbMusteriIlce.DataSource = list;
            cbMusteriIlce.DisplayMember = "IlceAdi";
            cbMusteriIli.DataSource = il;
            cbMusteriIli.DisplayMember = "IlAdi";

            var faturaGoster = (from fatura in db.faturaMasters where (fatura.MusteriID == musteriSecilen) select new { fatura.FaturaID, fatura.FaturaTarihi, fatura.IrsaliyeNo, fatura.OdemeTarihi }).ToList();
            dgwVeriler.DataSource = faturaGoster;
        }
        int FaturaSecilenID;
        private void dgwVeriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                FaturaSecilenID = Convert.ToInt32(dgwVeriler.CurrentRow.Cells[0].Value);  

                FaturaMaster xFatura = db.faturaMasters.Find(FaturaSecilenID);
                txtFaturaNo.Text = xFatura.FaturaID.ToString();
                cbMusteriIli.SelectedValue = xFatura.musteri.ilce.IlID;
                cbMusteriIlce.SelectedValue = xFatura.musteri.IlceID;
                cbMusteriUnvani.SelectedValue = xFatura.musteri.MusteriUnvani;
            }
            catch (Exception)
            {

                return;
            }
        }

        
    }
}
