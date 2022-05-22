using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPHELIA_S_OASIS
{
    public partial class RezervasyonSil : Form
    {
        public RezervasyonSil()
        {
            InitializeComponent();
        }

        private void RezervasyonSil_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            listView1.View = View.Details;
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("select MüşteriId, MüşteriAdSoyad, Rezervasyon, OdaId, Durum, Toplam from RezervasyonAll");

            command.Connection = connection;
            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            int sayac = 0;
            while (reader.Read())
            {
                string[] doldur = new string[] { reader.GetString(1), reader.GetString(2), reader.GetInt32(3).ToString(),reader.GetString(4), reader.GetDouble(5).ToString() };

                listView1.Items.Add(reader.GetInt32(0).ToString()).SubItems.AddRange(doldur);
                sayac++;
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Çalışan cls = new Çalışan();

            string musteriId = listView1.SelectedItems[0].Text;
            string odaId = listView1.SelectedItems[0].SubItems[3].Text;
            cls.RezervasyonSil(musteriId,odaId);
            MessageBox.Show("Rezervasyon başarıyla iptal edilmiştir.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÇalışanMenu menu = new ÇalışanMenu();
            this.Hide();
            menu.Location = this.Location;
            menu.Show();
        }
    }
}
