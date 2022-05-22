using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPHELIA_S_OASIS
{
    public class UserProvider
    {
        public Çalışan getUser(string kullaniciAdi, string password)
        {
            // kullanıcıyı çeker
            Çalışan user = null;
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("SELECT *FROM Çalışan WHERE KullanıcıAdı ='" + kullaniciAdi + "' and Şifre='" + password + "'");

            command.Connection = connection;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                user = new Çalışan();

                user.Ad = reader.GetString(1); //ad
                user.Soyad = reader.GetString(2); //soyad
                user.KullaniciAdi = reader.GetString(3);   //kname
                user.Password = reader.GetString(4);  //password
            }
            connection.Close();

            return user;
        }
    }
}
