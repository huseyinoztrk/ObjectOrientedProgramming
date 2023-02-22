using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneyeDayaliProgramlama
{
    public partial class FrmOgretmen : Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void BtnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            FrmOgrenciIslemleri fr = new FrmOgrenciIslemleri();
            fr.Show();
        }

        private void BtnSoruIslemleri_Click(object sender, EventArgs e)
        {
            FrmSoruIslemleri fr = new FrmSoruIslemleri();
            fr.Show();
        }

        private void BtnSinavIslemleri_Click(object sender, EventArgs e)
        {
            FrmSinavIslemleri fr = new FrmSinavIslemleri();
            fr.Show();
        }

        private void BtnSinavNotlari_Click(object sender, EventArgs e)
        {
            FrmOgretmenNotEkrani fr = new FrmOgretmenNotEkrani();
            fr.Show();
        }

        private void BtnSinavTarihleri_Click(object sender, EventArgs e)
        {
            FrmSinavTarihleri fr = new FrmSinavTarihleri();
            fr.Show();
        }
    }
}
