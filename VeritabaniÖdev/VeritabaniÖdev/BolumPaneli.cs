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
    public partial class BolumPaneli : Form
    {
        public BolumPaneli()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void BolumPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM bolumler", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("INSERT INTO bolumler (bolumler_adi) VALUES (@b1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", txtBolum.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Txtid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBolum.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("DELETE FROM bolumler WHERE bolumler_id=@b1", bgl.baglanti());
            komut.Parameters.AddWithValue("@b1", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("UPDATE bolumler SET bolumler_adi=@p1 WHERE bolumler_id=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtBolum.Text);
            komut.Parameters.AddWithValue("@p2", Txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi");
        }
    }
}
