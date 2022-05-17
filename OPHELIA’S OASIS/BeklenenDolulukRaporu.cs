using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPHELIA_S_OASIS
{
    public class BeklenenDolulukRaporu
    {
        string kacOda;
        string rezervasyonTipi;
        string rezervasyonTarihi;
        public string[] GetBeklenenDolulukRaporu()
        {
            // kullanıcıyı çeker
            
            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");

            SqlCommand command = new SqlCommand("select * from dbo.beklenenDolulukRaporu()");

            command.Connection = connection;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();
            List<BeklenenDolulukRaporu> raporIcerik = new List<BeklenenDolulukRaporu>();
            string[] arr = new string[] { };
            int sayac = 0;
            while (reader.Read())
            {
                arr[sayac] = reader.GetInt32(0).ToString();
                arr[sayac + 1] = reader.GetString(1);
                arr[sayac + 2] = reader.GetDateTime(2).ToShortDateString();
                sayac = sayac + 3;
            }
            connection.Close();

            return arr;
        }
    }
}
