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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }       
        sqlBaglantisi bgl = new sqlBaglantisi();
        public string TC;
        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            LblTC.Text = TC;

            // Doktor Ad Soyad
            MySqlCommand komut = new MySqlCommand("SELECT ad,soyad FROM doktorlar where doktor_tc_kimlik_no=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",LblTC.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            // Randevular
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM randevular where randevu_doktor='"+LblAdSoyad.Text+"'",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDüzenle fr = new FrmDoktorBilgiDüzenle();
            fr.TCNO = LblTC.Text;
            fr.Show();

        }

        private void BtnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchÖnBilgi.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
