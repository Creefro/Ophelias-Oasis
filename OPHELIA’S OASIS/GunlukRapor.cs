using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace OPHELIA_S_OASIS
{
    public class GunlukRapor
    {
        public string adSoyad;
        public string rezervasyonTip;
        public string odaId;
        public string checkIn;

        public List<GunlukRapor> GetGunlukRapor()
        {
            SqlConnection connection = new SqlConnection("Data Source=FAEGNIR\\SQLEXPRESS;Initial Catalog=\"OPHELIA’S OASIS\";Integrated Security=True");

            SqlCommand command = new SqlCommand("SELECT MüşteriAdSoyad, Rezervasyon ,O.OdaId , CheckOut FROM Rezervasyon R INNER JOIN Musteri M ON R.MüşteriId = M.MüşteriId INNER JOIN Oda O ON O.OdaId = R.OdaId WHERE R.CheckIn = CAST(GETDATE() AS DATE) ORDER BY M.MüşteriAdSoyad ASC");

            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            List<GunlukRapor> row =  new List<GunlukRapor>();
            List<string> rowa =  new List<string>();
            while (reader.Read())
            {
                row.Add(new GunlukRapor
                {
                    adSoyad = reader.GetString(0),
                    rezervasyonTip = reader.GetString(1),
                    odaId = reader.GetInt32(2).ToString(),
                    checkIn = reader.GetDateTime(3).ToShortDateString()
                 });
            }
            
            connection.Close();
            return row;
        }
    }
}
