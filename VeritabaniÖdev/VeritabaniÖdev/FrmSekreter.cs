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
    public partial class FrmSekreter : Form
    {
        public FrmSekreter()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            MySqlCommand komut = new MySqlCommand("SELECT * FROM sekreterler WHERE sekreter_tc_kimlik_no=@p1 AND sekreter_sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmSekreterDetay frs = new FrmSekreterDetay();
                frs.TCnumara = MskTC.Text;
                frs.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
