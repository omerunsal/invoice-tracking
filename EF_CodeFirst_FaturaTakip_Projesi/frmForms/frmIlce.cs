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
    public partial class frmIlce : Form
    {
        public frmIlce()
        {
            InitializeComponent();
        }
        FaturaContext db = new FaturaContext();
        private void frmIlce_Load(object sender, EventArgs e)
        {
            {
                Illistele();
                Ilcelistele();
            }
            
        }

        private void Ilcelistele()
        {
            var list = db.Ilceler.Select
            (b => new
            {
                IlceKodu = b.IlceID,
                b.IlceAdi
            }
            ).ToList();

            dgwVeriler.DataSource = list;

            txtIlceAdi.Clear();
            txtIlceAdi.Focus();

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

            cbIl.DataSource = list;
            cbIl.DisplayMember = "IlAdi";
            cbIl.ValueMember = "IlKodu";
        }

        int secilenID;
        Ilce xIlce;

        private void cbIl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            secilenID = Convert.ToInt32(cbIl.SelectedValue);
            var list = (from ilce in db.Ilceler where(ilce.IlID==secilenID) select new {ilce.IlceID,ilce.IlceAdi }).ToList();
            
            dgwVeriler.DataSource = list;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Ilce ilce = new Ilce();
                ilce.IlID = secilenID;

                ilce.IlceAdi = txtIlceAdi.Text;
                db.Ilceler.Add(ilce);
                db.SaveChanges();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen İlçe adı giriniz!" + ex.InnerException.Message);
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Ilce ilce = db.Ilceler.Find(IlcesecilenID);
                ilce.IlceAdi = txtIlceAdi.Text;
                ilce.IlID =Convert.ToInt32(cbIl.SelectedValue);
                db.SaveChanges();

                Ilcelistele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen Güncellenecek İlçeyi Seçiniz!" + ex.InnerException.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Ilce ilce = db.Ilceler.Find(IlcesecilenID);
                db.Ilceler.Remove(ilce);
                db.SaveChanges();
                Ilcelistele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lütfen silmek istediğiniz İlçeyi seçiniz!" + ex.Message); ;
            }
        }
        int IlcesecilenID;
        private void dgwVeriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //DataGridView'den seçilen ID'yi alalım.
            IlcesecilenID = Convert.ToInt32(dgwVeriler.CurrentRow.Cells[0].Value);  //Veya .Cells["BirimID"] (birimkodu)

            Ilce xIlce = db.Ilceler.Find(IlcesecilenID);
            txtIlceAdi.Text = xIlce.IlceAdi;
            cbIl.SelectedValue = xIlce.IlID;
        }
    }
}
