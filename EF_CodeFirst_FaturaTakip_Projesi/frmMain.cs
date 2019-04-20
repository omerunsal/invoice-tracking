using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_CodeFirst_FaturaTakip_Projesi
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmForms.frmUrun yeniUrun = new frmForms.frmUrun();
            yeniUrun.MdiParent = this;
            yeniUrun.Show();
        }

        private void birimEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmForms.frmBirim yeniBirim = new frmForms.frmBirim();
            yeniBirim.MdiParent = this;
            yeniBirim.Show();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmForms.frmMusteri yeniMusteri = new frmForms.frmMusteri();
            yeniMusteri.MdiParent = this;
            yeniMusteri.Show();
        }

        private void ilEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmForms.frmIl yeniIl = new frmForms.frmIl();
            yeniIl.MdiParent = this;
            yeniIl.Show();
        }

        private void ilçeEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmForms.frmIlce yeniIlce = new frmForms.frmIlce();
            yeniIlce.MdiParent = this;
            yeniIlce.Show();
        }

        private void yeniFaturaOluşturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmForms.frmYeniFaturaOlustur yeniFatura = new frmForms.frmYeniFaturaOlustur();
            yeniFatura.MdiParent = this;
            yeniFatura.Show();
        }

        private void faturaSorgulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmForms.frmFaturaSorgulama yeniSorgulama = new frmForms.frmFaturaSorgulama();
            yeniSorgulama.MdiParent = this;
            yeniSorgulama.Show();
        }

        private void faturaDetaylarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmForms.frmFaturaDetay yeniFatura = new frmForms.frmFaturaDetay();
            yeniFatura.MdiParent = this;
            yeniFatura.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
