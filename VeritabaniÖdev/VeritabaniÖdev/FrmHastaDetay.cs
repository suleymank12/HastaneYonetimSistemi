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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }
        public string tc;
        sqlBaglantisi bgl = new sqlBaglantisi();

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = tc;

            // Ad Soyad Çekme
            MySqlCommand komut = new MySqlCommand("SELECT ad,soyad FROM hastalar WHERE tc_kimlik_no=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // Randevu Geçmişi
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM randevular WHERE hasta_TC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

            // Bolumleri Çekme
            MySqlCommand komut2 = new MySqlCommand("SELECT bolumler_adi FROM bolumler",bgl.baglanti());
            MySqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                CmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void CmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            CmbDoktor.Items.Clear();
            MySqlCommand komut3 = new MySqlCommand("SELECT ad,soyad FROM doktorlar WHERE uzmanlik_alani=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", CmbBrans.Text);
            MySqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read()) 
            { 
                CmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);            
            }
            bgl.baglanti().Close();
        }

        private void CmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM randevular WHERE randevu_bolum='" + CmbBrans.Text + "'"  + "and randevu_doktor='"+CmbDoktor.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LnkBilgiDüzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle fr = new FrmBilgiDüzenle();
            fr.TCno = LblTC.Text;
            fr.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();


        }

        private void BtnRandevuAl_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("UPDATE randevular SET randevu_durum = 1, hasta_TC=@p1, hasta_sikayet=@p2 where randevu_id=@p3",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", LblTC.Text);
            komut.Parameters.AddWithValue("@p2", RchÖnBilgi.Text);
            komut.Parameters.AddWithValue("@p3", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
