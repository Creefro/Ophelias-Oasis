using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPHELIA_S_OASIS
{
    class OdaYönet
    {
        public void tumOdalarUcretDegistir(double yeniUcret)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("UPDATE Oda SET Ücret =" + yeniUcret + "");
            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
        public void odaIdsiyleUcretDegistir(double yeniUcret, int odaId)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("UPDATE Oda SET Ücret =" + yeniUcret + "WHERE OdaId =" + odaId + "");
            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
    }
}
