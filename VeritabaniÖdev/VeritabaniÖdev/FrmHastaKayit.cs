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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        sqlBaglantisi bgl = new sqlBaglantisi();
        private void BtnKayit_Click(object sender, EventArgs e)
        {
            // Ad ve Soyad Kontrolü
            if (string.IsNullOrEmpty(TxtAd.Text) || string.IsNullOrEmpty(TxtSoyad.Text))
            {
                MessageBox.Show("Ad ve Soyad boş bırakılamaz!");
                return;
            }

            // TC Kimlik Numarası Kontrolü
            if (MskTC.Text.Length != 11 || !long.TryParse(MskTC.Text, out _))
            {
                MessageBox.Show("TC Kimlik Numarası 11 haneli olmalı ve sadece rakamlardan oluşmalıdır!");
                return;
            }

            // Telefon Numarası Kontrolü
            if (string.IsNullOrEmpty(MskTlf.Text) || !long.TryParse(MskTlf.Text, out _))
            {
                MessageBox.Show("Telefon numarası yalnızca rakamlardan oluşmalıdır!");
                return;
            }

            // Şifre Kontrolü
            if (string.IsNullOrEmpty(TxtSifre.Text))
            {
                MessageBox.Show("Şifre boş bırakılamaz!");
                return;
            }

            // Cinsiyet Kontrolü
            if (string.IsNullOrEmpty(CmbCnsyt.Text) ||
                !(CmbCnsyt.Text == "Erkek" || CmbCnsyt.Text == "Kadın"))
            {
                MessageBox.Show("Lütfen geçerli bir cinsiyet seçin (Erkek/Kadın)!");
                return;
            }

            // Veritabanına Kayıt
            try
            {
                MySqlCommand komut = new MySqlCommand(
                    "INSERT INTO hastalar (ad, soyad, tc_kimlik_no, telefon, sifre, cinsiyet) " +
                    "VALUES (@p1, @p2, @p3, @p4, @p5, @p6)",
                    bgl.baglanti()
                );
                komut.Parameters.AddWithValue("@p1", TxtAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtSoyad.Text);
                komut.Parameters.AddWithValue("@p3", MskTC.Text);
                komut.Parameters.AddWithValue("@p4", MskTlf.Text);
                komut.Parameters.AddWithValue("@p5", TxtSifre.Text);
                komut.Parameters.AddWithValue("@p6", CmbCnsyt.Text);

                komut.ExecuteNonQuery();
                bgl.baglanti().Close();

                MessageBox.Show("Kaydınız başarılı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}");
            }
        }

    }
}
