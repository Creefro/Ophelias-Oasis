using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPHELIA_S_OASIS
{
    class Admin
    {
       public float beklenenDolulukOranı()
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("select SUM(B.[Kaç Oda]) from dbo.beklenenDolulukRaporu() B");

            command.Connection = connection;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            float dolulukOran = 0;
            while (reader.Read())
            {
                dolulukOran = reader.GetInt32(0);
            }
            connection.Close();
            return dolulukOran/30;
        }

    }
}
