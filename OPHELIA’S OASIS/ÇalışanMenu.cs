using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OPHELIA_S_OASIS
{
    public partial class ÇalışanMenu : Form
    {
        public ÇalışanMenu()
        {
            InitializeComponent();
        }

        private void ÇalışanMenu_Load(object sender, EventArgs e)
        {
            listViewGelen.View = View.Details;
            listViewDoluluk.View = View.Details;

            int sayac = 0;
            int sayac2 = 0;
            SqlConnection connection = new SqlConnection("Data Source=FAEGNIR\\SQLEXPRESS;Initial Catalog=\"OPHELIA’S OASIS\";Integrated Security=True");
            SqlConnection connection1 = new SqlConnection("Data Source=FAEGNIR\\SQLEXPRESS;Initial Catalog=\"OPHELIA’S OASIS\";Integrated Security=True");

            SqlCommand command = new SqlCommand("SELECT MüşteriAdSoyad, Rezervasyon ,O.OdaId , CheckOut FROM Rezervasyon R INNER JOIN Musteri M ON R.MüşteriId = M.MüşteriId INNER JOIN Oda O ON O.OdaId = R.OdaId WHERE R.CheckIn = CAST(GETDATE() AS DATE) ORDER BY M.MüşteriAdSoyad ASC");
            SqlCommand dolulukcom = new SqlCommand("SELECT MüşteriAdSoyad,OdaId,CheckOut FROM (Rezervasyon R INNER JOIN Musteri M ON M.MüşteriId = R.MüşteriId) WHERE (R.RezervasyonTarih = DATEADD(day, -1, CAST(GETDATE() AS date))) UNION SELECT MüşteriAdSoyad,OdaId,CONVERT(datetime,0000-00-00) FROM (Rezervasyon R INNER JOIN Musteri M ON M.MüşteriId = R.MüşteriId) WHERE not exists (SELECT * FROM Rezervasyon WHERE (R.RezervasyonTarih = DATEADD(day, -1, CAST(GETDATE() AS date)))) ORDER BY OdaId ASC");
            command.Connection = connection;
            dolulukcom.Connection = connection1;
            connection1.Open();
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            SqlDataReader reader2 = dolulukcom.ExecuteReader();

            while (reader.Read())
            {

                string[] doldur = new string[] { reader.GetString(0), reader.GetString(1), reader.GetInt32(2).ToString(), reader.GetDateTime(3).ToShortDateString() };    
                
                listViewGelen.Items.Add(sayac.ToString()).SubItems.AddRange(doldur);
                sayac++;

            }
            while (reader2.Read())
            {
                string tarih;
                if (reader2.GetDateTime(2).ToString() == "1.01.1900 00:00:00")
                {
                    tarih = "YOK";
                }
                else
                {
                    tarih = reader2.GetDateTime(2).ToShortDateString();
                }
                string[] doludoldur = new string[] { reader2.GetString(0), reader2.GetInt32(1).ToString(), tarih};

                listViewDoluluk.Items.Add(sayac2.ToString()).SubItems.AddRange(doludoldur);
                sayac2++;

            }
            connection.Close();
            connection1.Close();
        }
    }
}
