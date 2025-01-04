using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VeritabaniÖdev
{
    public partial class FrmDoktorBilgiDüzenle : Form
    {
        public FrmDoktorBilgiDüzenle()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        public string TCNO;
        private void FrmDoktorBilgiDüzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCNO;

            MySqlCommand komut = new MySqlCommand("SELECT * FROM doktorlar where doktor_tc_kimlik_no=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",MskTC.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                CmbBolum.Text = dr[3].ToString();
                TxtSifre.Text = dr[5].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("UPDATE doktorlar SET ad=@p1,soyad=@p2,uzmanlik_alani=@p3,doktor_sifre=@p4 where doktor_tc_kimlik_no=@p5",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", CmbBolum.Text);
            komut.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut.Parameters.AddWithValue("@p5", MskTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi");
        }
    }
}
