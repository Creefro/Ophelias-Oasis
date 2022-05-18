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
    public partial class FiyatDeğiştirForm : Form
    {
        public FiyatDeğiştirForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 1)
            {
                MessageBox.Show("Fiyat Girin.", "Hata!");
            }
            else
            {
                SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

                SqlCommand command = new SqlCommand("UPDATE Oda SET Ücret =" + float.Parse(textBox1.Text) + "WHERE OdaId =" + Convert.ToInt32(numericUpDown1.Value) + "");
                command.Connection = connection;
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 1)
            {
                MessageBox.Show("Fiyat Girin.", "Hata!");
            }
            else
            {
                SqlConnection connection = Helper.GetConnection("Ophelias-Oasis");

                SqlCommand command = new SqlCommand("UPDATE Oda SET Ücret =" + float.Parse(textBox2.Text) + "");
                command.Connection = connection;
                connection.Open();

                command.ExecuteNonQuery();

                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminPanel main = new AdminPanel();
            main.Location = this.Location;
            this.Hide();
            main.Show();
        }
    }
}
