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
    public partial class FaturaForm : Form
    {
        public int arananOda;
        public FaturaForm(int arananOda)
        {
            InitializeComponent();
            this.arananOda = arananOda;
        }

        private void FaturaForm_Load(object sender, EventArgs e)
        {
            string now = DateTime.Now.ToShortDateString();
            listView1.View = View.Details;
            SqlConnection connection = new SqlConnection("Data Source=FAEGNIR\\SQLEXPRESS;Initial Catalog=\"OPHELIA’S OASIS\";Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT O.OdaId,MüşteriAdSoyad,CheckIn,CheckOut,O.Ücret FROM Rezervasyon R INNER JOIN Musteri M ON R.MüşteriId = M.MüşteriId INNER JOIN Oda O ON O.OdaId = R.OdaId WHERE R.CheckOut = CAST(GETDATE() AS DATE)");
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (arananOda == reader.GetInt32(0))
                {
                    string uc = reader.GetValue(4).ToString();
                    string a = (reader.GetDateTime(3) - reader.GetDateTime(2)).TotalDays.ToString();
                    string[] doldur = new string[] { reader.GetString(1), reader.GetDateTime(2).ToShortDateString(), reader.GetDateTime(3).ToShortDateString(), a, uc.ToString(), now };

                    listView1.Items.Add(reader.GetInt32(0).ToString()).SubItems.AddRange(doldur);
                }
                else
                {
                    label1.Text = "Seçilen odada bugün için bir rezervasyon yok.";
                }
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÇalışanMenu main = new ÇalışanMenu();
            main.Location = this.Location;
            this.Hide();
            main.Show();
        }
    }
}
