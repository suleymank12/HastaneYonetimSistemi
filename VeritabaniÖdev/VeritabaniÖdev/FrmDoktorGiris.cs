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
using MySqlConnector;

namespace VeritabaniÖdev
{
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }
        sqlBaglantisi bgl = new sqlBaglantisi();
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            MySql.Data.MySqlClient.MySqlCommand komut = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM doktorlar where doktor_tc_kimlik_no=@p1 and doktor_sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", MskTC.Text);
            komut.Parameters.AddWithValue("@p2", TxtSifre.Text);
            MySql.Data.MySqlClient.MySqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmDoktorDetay fr = new FrmDoktorDetay();
                fr.TC = MskTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
