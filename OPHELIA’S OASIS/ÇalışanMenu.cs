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
            listViewGelen.Visible = false;
            listViewDoluluk.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FaturaForm main = new FaturaForm(Convert.ToInt32(numericUpDown1.Value));
            main.Location = this.Location;
            this.Hide();
            main.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (gelenButton.Checked)
            {
                gelensergile();
            }
            else if (dolulukButton.Checked)
            {
                doluluksergile();
            }
            else
                MessageBox.Show("Lütfen rapor seçin.", "Hata");
        }
        void gelensergile()
        {
            label1.Text = "Günlük Gelen Rapor:";
            listViewDoluluk.Visible = false;
            listViewGelen.Visible = true;
            listViewGelen.Items.Clear();
            listViewGelen.View = View.Details;
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("SELECT MüşteriAdSoyad, Rezervasyon ,O.OdaId , CheckOut FROM Rezervasyon R INNER JOIN Musteri M ON R.MüşteriId = M.MüşteriId INNER JOIN Oda O ON O.OdaId = R.OdaId WHERE R.CheckIn = CAST(GETDATE() AS DATE) ORDER BY M.MüşteriAdSoyad ASC");
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {

                string[] doldur = new string[] { reader.GetString(1), reader.GetInt32(2).ToString(), reader.GetDateTime(3).ToShortDateString() };

                listViewGelen.Items.Add(reader.GetString(0)).SubItems.AddRange(doldur);
            }
            connection.Close();
        }
        void doluluksergile()
        {
            listViewGelen.Visible = false;
            label1.Text = "Günlük Doluluk Rapor";
            listViewDoluluk.Visible = true;
            listViewDoluluk.Items.Clear();

            listViewDoluluk.View = View.Details;

            SqlConnection connection1 = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand dolulukcom = new SqlCommand("SELECT MüşteriAdSoyad,OdaId,CheckOut FROM (Rezervasyon R INNER JOIN Musteri M ON M.MüşteriId = R.MüşteriId) WHERE (R.RezervasyonTarih = DATEADD(day, -1, CAST(GETDATE() AS date))) UNION SELECT MüşteriAdSoyad,OdaId,CONVERT(datetime,0000-00-00) FROM (Rezervasyon R INNER JOIN Musteri M ON M.MüşteriId = R.MüşteriId) WHERE not exists (SELECT * FROM Rezervasyon WHERE (R.RezervasyonTarih = DATEADD(day, -1, CAST(GETDATE() AS date)))) ORDER BY OdaId ASC");
            dolulukcom.Connection = connection1;
            connection1.Open();
            SqlDataReader reader2 = dolulukcom.ExecuteReader();


            while (reader2.Read())
            {
                string tarih;
                string ad;
                string now = DateTime.Now.ToShortDateString();
                if (reader2.GetDateTime(2).ToString() == "1.01.1900 00:00:00")
                {
                    tarih = "";
                }
                else
                {
                    tarih = reader2.GetDateTime(2).ToShortDateString();
                }
                if (tarih == now)
                {
                    ad = "* " + reader2.GetString(0);
                }
                else
                    ad = reader2.GetString(0);
                string[] doludoldur = new string[] { reader2.GetInt32(1).ToString(), tarih };

                listViewDoluluk.Items.Add(ad).SubItems.AddRange(doludoldur);
            }
            connection1.Close();
        }
    }
}
