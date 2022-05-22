using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPHELIA_S_OASIS
{
    public partial class RezervasyonErtele : Form
    {
        public RezervasyonErtele()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            int musteriId =rezervasyon.idCek(textBox1.Text);
            rezervasyon.rezUpdate(musteriId, dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year, dateTimePicker2.Value.Day, dateTimePicker2.Value.Month, dateTimePicker2.Value.Year);

            // ceza ekle
            if(rezervasyon.rezTipiÇek(musteriId)=="Ön Ödemeli" || rezervasyon.rezTipiÇek(musteriId) == "60 Gün Önceden")
            {
                double eskiUcret = rezervasyon.ucretCek(rezervasyon.GetOdaIdFromRezervasyon(musteriId));
                rezervasyon.cezaEkle(musteriId, eskiUcret);
                MessageBox.Show("Rezervasyon tarihiniz başarıyla değiştirilmiştir.");
            }
            else
            {
                MessageBox.Show("Rezervasyon tarihiniz başarıyla değiştirilmiştir.");
            }

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            RezervasyonForm scr = new RezervasyonForm();
            scr.Show();
            this.Hide();
        }
    }
}
