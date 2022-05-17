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
    public partial class RezervasyonForm : Form
    {
        public RezervasyonForm()
        {
            InitializeComponent();
        }

        private void RezervasyonForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string durum;
            if(comboBox1.SelectedItem.ToString() == "60 Gün")
            {
                durum = "Ödeme Yapılmadı";
                musteriSave(durum);
            }
            else
            {
                durum = "Ödeme Yapıldı";
                musteriSave(durum);
                odemeSave();
            }
           // musteriSave(durum);
            rezSave();

        }
        void musteriSave(string durum)
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("INSERT INTO Musteri (MüşteriAdSoyad,Rezervasyon,Durum,Eposta,KrediKartıNo) VALUES('" + adTxt.Text + "','" + comboBox1.SelectedItem.ToString() + "','" + durum + "','" + mailTxt.Text + "','" + kartTxt.Text + "')");
            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
        int rezSave()
        {
            int odaidsi = odaIdCek();
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");
            
            SqlCommand command = new SqlCommand("INSERT INTO Rezervasyon (MüşteriId,OdaId,RezervasyonTarih,CheckIn,CheckOut,Açıklama) VALUES('" + idCek() + "','" + odaidsi + "',GETDATE()," + dateTimePicker1.Value.Date.ToString("yyyy-mm-dd") + "," + dateTimePicker2.Value.Date.ToString("yyyy-mm-dd") + ", 'AAA' )");
            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
            return odaidsi;
        }
        void odemeSave()
        {
            int gun = (dateTimePicker2.Value - dateTimePicker1.Value).Days;
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

            SqlCommand command = new SqlCommand("INSERT INTO Ödeme (MüşteriId,ÖdemeTarihi,Toplam) VALUES('" + idCek() + "','" + DateTime.Now + "'," + (gun*ucretCek()) + " )");
            command.Connection = connection;
            connection.Open();

            command.ExecuteNonQuery();

            connection.Close();
        }
        int idCek()
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");
            SqlCommand command = new SqlCommand("SELECT MüşteriId FROM Musteri WHERE MüşteriAdSoyad = '"+ adTxt.Text+"'");
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int ID = 0;
            while (reader.Read())
            {
                ID = reader.GetInt32(0);
            }
            connection.Close();
            return ID;
        }
        int odaIdCek()
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");
            SqlCommand command = new SqlCommand("SELECT TOP 1 * FROM Oda O WHERE O.DoluMu = 0 ORDER BY NEWID()");
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int ID = 0;
            while (reader.Read())
            {
                ID = reader.GetInt32(0);
            }
            connection.Close();
            return ID;
        }
        int ucretCek()
        {
            SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");
            SqlCommand command = new SqlCommand("SELECT Ücret FROM Oda WHERE OdaId = "+rezSave() +"");
            command.Connection = connection;
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            int ucret = 0;
            while (reader.Read())
            {
                ucret = reader.GetInt32(0);
            }
            connection.Close();
            return ucret;
        }
    }
}
