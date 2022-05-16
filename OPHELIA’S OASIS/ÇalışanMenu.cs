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
            SqlConnection connection = new SqlConnection("Data Source=FAEGNIR\\SQLEXPRESS;Initial Catalog=\"OPHELIA’S OASIS\";Integrated Security=True");

            SqlCommand command = new SqlCommand("SELECT MüşteriAdSoyad, Rezervasyon ,O.OdaId , CheckOut FROM Rezervasyon R INNER JOIN Musteri M ON R.MüşteriId = M.MüşteriId INNER JOIN Oda O ON O.OdaId = R.OdaId WHERE R.CheckIn = CAST(GETDATE() AS DATE) ORDER BY M.MüşteriAdSoyad ASC");

            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
           // ListViewItem item = new ListViewItem();
            while (reader.Read())
            {

                string[] doldur = new string[] { reader.GetString(0), reader.GetString(1), reader.GetInt32(2).ToString(), reader.GetDateTime(3).ToShortDateString() };
                //listViewGelen.Items.Add(reader.GetString(0));
                //listViewGelen.Items.Add(reader.GetString(1));
                //listViewGelen.Items.Add(reader.GetInt32(2).ToString());
                //listViewGelen.Items.Add(reader.GetDateTime(3).ToString());
                
                listViewGelen.Items.Add(sayac.ToString()).SubItems.AddRange(doldur);
                sayac++;
               // item.SubItems.AddRange(doldur);
               // listViewGelen.Items.Add(item);             
                    //listViewGelen.Items.Add("").SubItems.AddRange(doldur);
            }
            connection.Close();
        }
    }
}
