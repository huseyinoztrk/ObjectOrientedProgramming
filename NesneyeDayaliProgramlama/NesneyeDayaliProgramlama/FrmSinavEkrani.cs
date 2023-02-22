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
    public partial class FrmSinavEkrani : Form
    {
        public FrmSinavEkrani()
        {
            InitializeComponent();
        }

            int sayi = 1;
        private void BtnIleri_Click(object sender, EventArgs e)
        {
            sayi++;
            LblSayi.Text = sayi.ToString();
        }

        private void FrmSinavEkrani_Load(object sender, EventArgs e)
        {
            LblSayi.Text = sayi.ToString();
        }

        private void BtnGeri_Click(object sender, EventArgs e)
        {
            if (sayi <= 1)
            {
                MessageBox.Show("Başa geldiniz.");
            }
            else
            {
            sayi--;
            LblSayi.Text = sayi.ToString();
            }
        }

        private void BtnBosBirak_Click(object sender, EventArgs e)
        {
            RdBosBirak.Checked = true;
        }
    }
}
