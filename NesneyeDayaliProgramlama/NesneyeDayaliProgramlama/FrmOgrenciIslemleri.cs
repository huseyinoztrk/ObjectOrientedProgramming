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
    public partial class FrmOgrenciIslemleri : Form
    {
        public FrmOgrenciIslemleri()
        {
            InitializeComponent();
        }

        SqlBaglantisi bgl = new SqlBaglantisi();

        private void FrmOgrenciIslemleri_Load(object sender, EventArgs e)
        {
            liste();
        }
            void liste()
            {
                SqlDataAdapter da = new SqlDataAdapter("Select * From Ogrenciler", bgl.baglanti());
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TxtTC.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            TxtSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Ogrenciler values (@p1,@p2,@p3,@p4)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci başarıyla eklenmiştir.");
            liste();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from Ogrenciler Where OgrenciTC=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", TxtTC.Text);
            cmd.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kulüp Silme İşlemi Başarıyla Gerçekleşmiştir.");
            liste();
        }
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            SqlCommand komut1 = new SqlCommand("Update Ogrenciler set OgrenciTC=@p1,OgrenciAd=@p2,OgrenciSoyad=@p3,OgrenciSifre=@p4 where OgrenciTC=@p5", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", TxtTC.Text);
            komut1.Parameters.AddWithValue("@p2", TxtAd.Text);
            komut1.Parameters.AddWithValue("@p3", TxtSoyad.Text);
            komut1.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut1.Parameters.AddWithValue("@p5", TxtTC.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Öğrenci kaydı güncellenmiştir.");
            liste();
        }
    }
}
