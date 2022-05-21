using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace OPHELIA_S_OASIS
{
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (beklenenDoluluk.Checked)
            {
                GetBeklenenDolulukRaporu();
            }
            else if (beklenenOdaGelir.Checked)
            {
                GetBeklenenOdaGelirRaporu();
            }
            else if (tesvikRaporu.Checked)
            {

            }
            else
                MessageBox.Show("Hata");
        }

        public void GetBeklenenDolulukRaporu()
        {
            listView1.Visible = true;
            listView2.Visible = false;

            listView1.Items.Clear();
            listView1.View = View.Details;
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("select * from dbo.beklenenDolulukRaporu()");

            command.Connection = connection;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            int sayac = 0;
            while (reader.Read())
            {
                string[] doldur = new string[] { reader.GetString(1), reader.GetDateTime(2).ToShortDateString() };

                listView1.Items.Add(reader.GetInt32(0).ToString()).SubItems.AddRange(doldur);
                sayac++;
            }
            connection.Close();
        }
        public void GetBeklenenOdaGelirRaporu()
        {
            listView1.Visible = false;
            listView2.Visible = true;

            listView1.Items.Clear();
            listView1.View = View.Details;
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("select * from dbo.beklenenGelir()");

            command.Connection = connection;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            int sayac = 0;
            while (reader.Read())
            {
                string[] doldur = new string[] { reader.GetFloat(1).ToString() };

                listView2.Items.Add(reader.GetDateTime(0).ToShortDateString()).SubItems.AddRange(doldur);
                sayac++;
            }
            connection.Close();
        }
        public void GetTeşvikRaporu()
        {
            listView1.Visible = false;
            listView2.Visible = false;
            // kullanıcıyı çeker
            listView1.Items.Clear();
            listView1.View = View.Details;
            SqlConnection connection = Helper.GetConnection("SinavSistemiDB");

            SqlCommand command = new SqlCommand("select * from dbo.beklenenGelir()");

            command.Connection = connection;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            int sayac = 0;
            while (reader.Read())
            {
                string[] doldur = new string[] { reader.GetString(1), reader.GetDateTime(2).ToShortDateString() };

                listView1.Items.Add(reader.GetInt32(0).ToString()).SubItems.AddRange(doldur);
                sayac++;
            }
            connection.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FiyatDeğiştirForm main = new FiyatDeğiştirForm();
            main.Location = this.Location;
            this.Hide();
            main.Show();
        }

        private void GeriButton_Click(object sender, EventArgs e)
        {
            RezervasyonForm main = new RezervasyonForm();
            main.Location = this.Location;
            this.Hide();
            main.Show();
        }
    }
}









