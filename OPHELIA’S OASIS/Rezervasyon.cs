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
            
            SqlCommand command = new SqlCommand("INSERT INTO Rezervasyon (MüşteriId,OdaId,RezervasyonTarih,CheckIn,CheckOut) VALUES(" + id+ "," + odaidsi + ",GETDATE(),CONVERT (datetime,'" + year1 + "-" + month1 + "-" + day1 + "'),CONVERT (datetime,'" + year2 + "-" + month2 + "-" + day2 + "'))");
            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
            return odaidsi;
        }
        public void odemeSave(int id,double rezUcret,DateTime checkOut,DateTime checkIn,double indirim)
        {
            int gun = (checkOut.Day - checkIn.Day);
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("INSERT INTO Ödeme (MüşteriId,ÖdemeTarihi,Toplam,İndirim) VALUES(" + id + ",GETDATE()," + (gun * rezUcret) + ","+ indirim+" )");
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

        public string rezTipiÇek(int musteriId)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");
            SqlCommand command = new SqlCommand("SELECT Rezervasyon FROM Musteri WHERE MüşteriId = '" + musteriId + "'");
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            string tip = "";
            while (reader.Read())
            {
                tip = reader.GetString(0);
            }
            connection.Close();
            return tip;
        }
        public int GetOdaIdFromRezervasyon(int müşteriId)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");
            SqlCommand command = new SqlCommand("SELECT OdaId FROM Rezervasyon WHERE MüşteriId = '" + müşteriId + "'");
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
        public void rezUpdate(int musteriId, int day1, int month1, int year1, int day2, int month2, int year2)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("UPDATE Rezervasyon SET CheckIn = CONVERT(datetime, " + year1 + " - " + month1 + " - " + day1 + "), CheckOut = CONVERT (datetime," + year2 + "-" + month2 + "-" + day2 + ") WHERE MüşteriId = " + musteriId + "");
            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
        public void cezaEkle(int musteriId,double ücret)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("Update Ödeme set Toplam = (dbo.cezaÜcretEkle("+musteriId+") +"+(ücret*1.1)+") where MüşteriId = "+musteriId+"");
            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
