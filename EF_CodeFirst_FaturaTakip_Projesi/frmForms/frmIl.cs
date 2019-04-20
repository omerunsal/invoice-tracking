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
    public partial class frmIl : Form
    {
        public frmIl()
        {
            InitializeComponent();
        }
        FaturaContext db = new FaturaContext();
        private void frmIl_Load(object sender, EventArgs e)
        {
            listele();
        }
        private void listele()
        {
            var list = db.Iller.Select
            (b=> new
            {
                IlKodu = b.IlID,
                b.IlAdi
            }
            ).ToList();

            dgwVeriler.DataSource = list;

            txtIlAdi.Clear();
            txtIlAdi.Focus();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Il il = new Il();
                il.IlAdi = txtIlAdi.Text;
                db.Iller.Add(il);
                db.SaveChanges();

                listele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen İl adı giriniz!" + ex.InnerException.Message);
            }
        }
        int secilenID;
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                Il il = db.Iller.Find(secilenID);
                il.IlAdi = txtIlAdi.Text;

                db.SaveChanges();

                listele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen Güncellenecek İli Seçiniz!" + ex.InnerException.Message);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                Il il = db.Iller.Find(secilenID);
                db.Iller.Remove(il);
                db.SaveChanges();
                listele();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lütfen silmek istediğiniz ili seçiniz!" + ex.Message); ;
            }
        }

        private void dgwVeriler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            secilenID = Convert.ToInt32(dgwVeriler.CurrentRow.Cells[0].Value);  
            Il xIl = db.Iller.Find(secilenID);
            txtIlAdi.Text = xIl.IlAdi;
        }
    }
}
