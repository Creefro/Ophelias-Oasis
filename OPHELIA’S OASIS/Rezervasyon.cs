using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPHELIA_S_OASIS
{
    class Rezervasyon
    {
        public void musteriSave(string musteriAd,string rezervasyonTip, string durum,string eposta,string kartNo)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("INSERT INTO Musteri (MüşteriAdSoyad,Rezervasyon,Durum,Eposta,KrediKartıNo) VALUES('" + musteriAd + "','" + rezervasyonTip + "','" + durum + "','" + eposta + "','" + kartNo + "')");
            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
        public int rezSave(int id,int day1,int month1,int year1, int day2, int month2, int year2)
        {
            int odaidsi = odaIdCek();
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");
            
            SqlCommand command = new SqlCommand("INSERT INTO Rezervasyon (MüşteriId,OdaId,RezervasyonTarih,CheckIn,CheckOut) VALUES(" + id+ "," + odaidsi + ",GETDATE(),CONVERT (datetime," + day1 + "-" + month1 + "-" + year1 + "),CONVERT (datetime," + day2 + "-" + month2 + "-" + year2 + "))");
            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
            return odaidsi;
        }
        public void odemeSave(int id,double rezUcret,DateTime checkOut,DateTime checkIn)
        {
            int gun = (checkOut - checkIn).Days;
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("INSERT INTO Ödeme (MüşteriId,ÖdemeTarihi,Toplam) VALUES(" + id + ",GETDATE()," + (gun * rezUcret) + " )");
            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
        public int idCek(string musteriAd)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");
            SqlCommand command = new SqlCommand("SELECT MüşteriId FROM Musteri WHERE MüşteriAdSoyad = '" + musteriAd + "'");
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int ID = 0;
            while (reader.Read())
            {
                ID = reader.GetInt32(0);
            }
            connection.Close();
            return ID;
        }
        public int odaIdCek()
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");
            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Oda O WHERE O.DoluMu = 0 ORDER BY NEWID()");
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int ID = 0;
            while (reader.Read())
            {
                ID = reader.GetInt32(0);
            }
            connection.Close();
            return ID;
        }
        public double ucretCek(int odaId)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");
            SqlCommand command = new SqlCommand("SELECT Ücret FROM Oda WHERE OdaId = " + odaId + "");
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            double ucret = 0;
            while (reader.Read())
            {
                ucret = reader.GetDouble(0);
            }
            connection.Close();
            return ucret;
        }
        public void odaDoldur(int odaId)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("UPDATE Oda SET DoluMu = 1 WHERE OdaId = " + odaId+ "");
            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
