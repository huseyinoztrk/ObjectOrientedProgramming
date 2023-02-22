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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();
        Ogrenci ogrenci = new Ogrenci();
        
        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            FrmKayitOl fr = new FrmKayitOl();
            fr.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var result = new List<Ogrenci>(); //bu alanda Ogrenci listesi oluşturduk
            SqlCommand cmd = new SqlCommand("Select OgrenciTC,OgrenciSifre from Ogrenciler", bgl.baglanti());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            result = dt.AsEnumerable().Select(s=>new Ogrenci
            {
                OgrenciTC1 = s.Field<string>("OgrenciTC"),
                OgrenciSifre1 = s.Field<string>("OgrenciSifre")
            }).ToList();

            var user = result.FirstOrDefault(x => x.OgrenciTC1 == TxtTC.Text && x.OgrenciSifre1 == TxtSifre.Text);
            if(user != null)
            {
                //MessageBox.Show("Giriş başarılı bir şekilde yapılmıştır.","Hoş Geldiniz");
                FrmOgrenciPanel fr = new FrmOgrenciPanel();
                fr.tc = TxtTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen TC'nizi veya şifrenizi kontrol ediniz!", "Geçersiz Giriş");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var result = new List<Ogretmen>(); //bu alanda Ogretmen listesini oluşturduk
            SqlCommand cmd = new SqlCommand("Select OgretmenTC,OgretmenSifre from Ogretmen",bgl.baglanti());

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            result = dt.AsEnumerable().Select(s => new Ogretmen
            {
                OgretmenTC1 = s.Field<string>("OgretmenTC"),
                OgretmenSifre1 = s.Field<string>("OgretmenSifre")
            }).ToList();

            var user = result.FirstOrDefault(x=>x.OgretmenTC1==TxtTC.Text && x.OgretmenSifre1==TxtSifre.Text);
            if (user != null)
            {
                //MessageBox.Show("Giriş başarılı bir şekilde yapılmıştır.", "Hoş Geldiniz");
                FrmOgretmen fr = new FrmOgretmen();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Lütfen TC'nizi veya şifrenizi kontrol ediniz!", "Geçersiz Giriş");
            }
        }
    }
}
