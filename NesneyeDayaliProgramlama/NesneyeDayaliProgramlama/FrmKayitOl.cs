using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NesneyeDayaliProgramlama
{
    public partial class FrmKayitOl : Form
    {
        public FrmKayitOl()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        Ogrenci ogrenci = new Ogrenci();
        int durum;

        void Kontrol()
        {
            ogrenci.OgrenciAd1 = TxtAd.Text;
            ogrenci.OgrenciSoyad1 = TxtSoyAd.Text;
            ogrenci.OgrenciTC1 = TxtTC.Text;
            ogrenci.OgrenciSifre1 = TxtOgrenciSifre.Text;

            SqlCommand kontrol = new SqlCommand("Select OgrenciTC from Ogrenciler where OgrenciTC=@OgrenciTC", bgl.baglanti());
            kontrol.Parameters.AddWithValue("@OgrenciTC", ogrenci.OgrenciTC1);
            SqlDataReader dr1 = kontrol.ExecuteReader();
            if(dr1.Read())
            {
                durum = 1;
            }
            else
            {
                durum = 0;
            }
        }

        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            Kontrol();
            
            if(durum != 1)
            {
                ogrenci.OgrenciAd1 = TxtAd.Text;
                ogrenci.OgrenciSoyad1 = TxtSoyAd.Text;
                ogrenci.OgrenciTC1 = TxtTC.Text;
                ogrenci.OgrenciSifre1 = TxtOgrenciSifre.Text;

                SqlCommand kayitOl = new SqlCommand("Insert Into Ogrenciler (OgrenciAd,OgrenciSoyad,OgrenciTC,OgrenciSifre) values (@OgrenciAd,@OgrenciSoyad,@OgrenciTC,@OgrenciSifre)",bgl.baglanti());
                kayitOl.Parameters.AddWithValue("@OgrenciAd", ogrenci.OgrenciAd1);
                kayitOl.Parameters.AddWithValue("@OgrenciSoyad", ogrenci.OgrenciSoyad1);
                kayitOl.Parameters.AddWithValue("@OgrenciTC", ogrenci.OgrenciTC1);
                kayitOl.Parameters.AddWithValue("@OgrenciSifre", ogrenci.OgrenciSifre1);
                kayitOl.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kayıt başarılı bir şekilde gerçekleşmiştir. Artık TC ve şifreniz ile giriş yapabilirsiniz.", "Kayıt Başarılı");
                Form1 fr = new Form1();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC'niz ile kayıtlı öğrenci bulunmaktadır.", "HATA");
            }
        }
    }
}
