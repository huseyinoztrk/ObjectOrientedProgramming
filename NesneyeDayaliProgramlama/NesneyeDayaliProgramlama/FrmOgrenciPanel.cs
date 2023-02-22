using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NesneyeDayaliProgramlama
{
    public partial class FrmOgrenciPanel : Form
    {
        public FrmOgrenciPanel()
        {
            InitializeComponent();
        }
        public string tc;
        SqlBaglantisi bgl = new SqlBaglantisi();
        private void BtnSinavGiris_Click(object sender, EventArgs e)
        {
            FrmSinavEkrani fr = new FrmSinavEkrani();
            fr.Show();
        }

        private void FrmOgrenciPanel_Load(object sender, EventArgs e)
        {
            //Öğrencinin notunu datagridview kısmına yazdırdığımız alan
            SqlCommand cmd = new SqlCommand("Select SoruSayisi,DogruCevapSayisi,Puanlar from Sonuclar where OgrenciTC=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", tc);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Tc labeline tc kimlik kısmını çektiğim alan
            LblTC.Text = tc;

            //Üst kısımdaki labellara ad-soyad ve tc'yi çektiğimiz alan
            SqlCommand komut = new SqlCommand("Select OgrenciAd,OgrenciSoyad From Ogrenciler where OgrenciTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();
        }
    }
}
