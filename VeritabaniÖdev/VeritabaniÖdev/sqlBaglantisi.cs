using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VeritabaniÖdev
{
    internal class sqlBaglantisi
    {
        public MySqlConnection baglanti()
        {
            MySqlConnection baglan = new MySqlConnection("Server=localhost;Database=hastane2;Uid=root;Pwd=1234");
            baglan.Open();
            return baglan;
      
        }
    }
}
