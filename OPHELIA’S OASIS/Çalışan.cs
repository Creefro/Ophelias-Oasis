using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPHELIA_S_OASIS
{
    public class Çalışan
    {
        string kullaniciAdi;
        string ad;
        string soyad;
        string password;
        public string KullaniciAdi { get { return kullaniciAdi; } set { kullaniciAdi = value; } }
        public string Ad { get { return ad; } set { ad = value; } }
        public string Soyad { get { return soyad; } set { soyad = value; } }
        public string Password { get { return password; } set { password = value; } }
        public void RezervasyonSil(string musteriId,string odaId)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("delete from Rezervasyon where MüşteriId = "+ musteriId +"");

            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
            OdemeSil(musteriId);
            OdaDoldur(odaId);
            
        }
        private void OdemeSil(string musteriId)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("delete from Ödeme where MüşteriId = " + musteriId + "");

            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
            MusteriSil(musteriId);
        }
        private void MusteriSil(string musteriId)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("delete from Musteri where MüşteriId = " + musteriId + "");

            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

        }
        private void OdaDoldur(string odaId)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("update Oda set DoluMu = 0 where OdaId ="+odaId+"");

            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();

        }
    }
}
