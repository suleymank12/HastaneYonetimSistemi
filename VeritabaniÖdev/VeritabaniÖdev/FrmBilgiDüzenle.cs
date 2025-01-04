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
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }
        public string TCno;
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            MskTC.Text = TCno;
            MySqlCommand komut = new MySqlCommand("SELECT * FROM hastalar WHERE tc_kimlik_no=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                TxtAd.Text = dr[1].ToString();
                TxtSoyad.Text = dr[2].ToString();
                MskTlfn.Text = dr[4].ToString();
                TxtSifre.Text = dr[5].ToString();
                CmbCinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            MySqlCommand komut2 = new MySqlCommand("UPDATE hastalar SET ad=@p1,soyad=@p2,telefon=@p3,sifre=@p4,cinsiyet=@p5 WHERE tc_kimlik_no=@p6", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut2.Parameters.AddWithValue("@p2", TxtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", MskTlfn.Text);
            komut2.Parameters.AddWithValue("@p4", TxtSifre.Text);
            komut2.Parameters.AddWithValue("@p5", CmbCinsiyet.Text);
            komut2.Parameters.AddWithValue("@p6", MskTC.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
        }
    }
}
