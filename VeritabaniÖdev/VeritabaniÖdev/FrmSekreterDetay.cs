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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCnumara;
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void button5_Click(object sender, EventArgs e)
        {
           BolumPaneli frb = new BolumPaneli();
            frb.Show();

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TCnumara;

            // Ad Soyad
            MySqlCommand komut1 = new MySqlCommand("SELECT ad_soyad FROM sekreterler WHERE sekreter_tc_kimlik_no=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", LblTC.Text);
            MySqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                LblAdSoyad.Text = dr1[0].ToString();
            }
            bgl.baglanti().Close();

            // Bolumleri Datagride Aktarma
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT bolumler_adi FROM bolumler", bgl.baglanti());
            da.Fill(dt1);
            dataGridView2.DataSource = dt1;

            // Doktorları Listeye Aktarma
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter("SELECT ad, soyad, uzmanlik_alani FROM doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;

            // Bolumleri comboboxa aktarma
            MySqlCommand komut2 = new MySqlCommand("SELECT bolumler_adi FROM bolumler", bgl.baglanti());
            MySqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBolum.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            MySqlCommand komutkaydet = new MySqlCommand("INSERT INTO randevular (randevu_tarihi, randevu_saat, randevu_bolum, randevu_doktor) VALUES (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", MskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", CmbBolum.Text);
            komutkaydet.Parameters.AddWithValue("@r4", CmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void CmbBolum_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            MySqlCommand komut = new MySqlCommand("SELECT ad, soyad FROM doktorlar WHERE uzmanlik_alani=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", CmbBolum.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read()) {
                CmbDoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void BtnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("INSERT INTO duyurular (duyuru) VALUES (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", RchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void BtnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
        }

        private void BtnListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frl = new FrmRandevuListesi();
            frl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }
    }
}
