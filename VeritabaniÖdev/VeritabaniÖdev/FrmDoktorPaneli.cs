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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            MySqlDataAdapter da1 = new MySqlDataAdapter("SELECT * FROM doktorlar", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            // Bolumleri comboboxa aktarma
            MySqlCommand komut2 = new MySqlCommand("SELECT bolumler_adi FROM bolumler", bgl.baglanti());
            MySqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBolum.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("INSERT INTO doktorlar (ad, soyad, uzmanlik_alani, doktor_tc_kimlik_no, doktor_sifre) VALUES (@d1,@d2,@d3,@d4,@d5)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", CmbBolum.Text);
            komut.Parameters.AddWithValue("@d4", MskTCNo.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   // datagriedview'e tıkladığında textboxlara yazdırıyo
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbBolum.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            MskTCNo.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("DELETE FROM doktorlar WHERE doktor_tc_kimlik_no=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTCNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("UPDATE doktorlar SET ad=@d1, soyad=@d2, uzmanlik_alani=@d3, doktor_sifre=@d5 WHERE doktor_tc_kimlik_no=@d4", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", TxtAd.Text);
            komut.Parameters.AddWithValue("@d2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@d3", CmbBolum.Text);
            komut.Parameters.AddWithValue("@d4", MskTCNo.Text);
            komut.Parameters.AddWithValue("@d5", TxtSifre.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
