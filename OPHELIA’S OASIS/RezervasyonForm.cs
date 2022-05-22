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
            //rezervasyon Yap
            Rezervasyon rezervasyon;
            string durum;
            if (dateTimePicker2.Value < dateTimePicker1.Value)
            {
                MessageBox.Show("Check Out Check In'den geri tarihli olamaz.");
            }
            else
            {
                if(comboBox1.SelectedItem.ToString()=="Ön Ödemeli")
                {
                
                    if (dateTimePicker1.Value < DateTime.Now.AddDays(90))
                    {
                        MessageBox.Show("Ön ödemeli rezervasyonlar minimum 90 gün sonraya alınabilir.");
                        dateTimePicker1.Value = DateTime.Now.AddDays(91);
                        dateTimePicker2.Value = DateTime.Now.AddDays(92);
                    }
                    else
                    {
                        rezervasyon = new Rezervasyon();
                        durum = "Ödeme Yapıldı";
                        rezervasyon.musteriSave(adTxt.Text,comboBox1.SelectedItem.ToString(),durum,mailTxt.Text,kartTxt.Text);
                        int musteriId = rezervasyon.idCek(adTxt.Text);
                        int odaId = rezervasyon.rezSave(musteriId,dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year, dateTimePicker2.Value.Day, dateTimePicker2.Value.Month, dateTimePicker2.Value.Year);
                        double ucret = rezervasyon.ucretCek(odaId) * 0.75;
                        rezervasyon.odemeSave(musteriId, ucret, dateTimePicker2.Value, dateTimePicker1.Value,0);
                        rezervasyon.odaDoldur(odaId);
                        MessageBox.Show("Rezervasyon başarılı.");

                    }

                }
                else if (comboBox1.SelectedItem.ToString() == "Teşvik")
                {
                    Admin admin = new Admin();
                    rezervasyon = new Rezervasyon();
                    
                    if (admin.beklenenDolulukOranı() <= 0.6)
                    {
                        durum = "Ödeme Yapıldı";
                        rezervasyon.musteriSave(adTxt.Text, comboBox1.SelectedItem.ToString(), durum, mailTxt.Text, kartTxt.Text);
                        int musteriId = rezervasyon.idCek(adTxt.Text);
                        int odaId = rezervasyon.rezSave(musteriId, dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year, dateTimePicker2.Value.Day, dateTimePicker2.Value.Month, dateTimePicker2.Value.Year);
                        double ucret = rezervasyon.ucretCek(odaId);
                        rezervasyon.odemeSave(musteriId, ucret*0.8, dateTimePicker2.Value, dateTimePicker1.Value, ucret*0.2);
                        rezervasyon.odaDoldur(odaId);
                        MessageBox.Show("Rezervasyon başarılı.");

                    }
                    else
                    {
                        durum = "Ödeme Yapıldı";
                        rezervasyon.musteriSave(adTxt.Text, comboBox1.SelectedItem.ToString(), durum, mailTxt.Text, kartTxt.Text);
                        int musteriId = rezervasyon.idCek(adTxt.Text);
                        int odaId = rezervasyon.rezSave(musteriId, dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year, dateTimePicker2.Value.Day, dateTimePicker2.Value.Month, dateTimePicker2.Value.Year);
                        double ucret = rezervasyon.ucretCek(odaId);
                        rezervasyon.odemeSave(musteriId, ucret, dateTimePicker2.Value, dateTimePicker1.Value, 0);
                        rezervasyon.odaDoldur(odaId);
                        MessageBox.Show("Rezervasyon başarılı.");

                    }

                }
                else if (comboBox1.SelectedItem.ToString() == "Klasik")
                {
                    rezervasyon = new Rezervasyon();
                    durum = "Ödeme Yapıldı";
                    rezervasyon.musteriSave(adTxt.Text, comboBox1.SelectedItem.ToString(), durum, mailTxt.Text, kartTxt.Text);
                    int musteriId = rezervasyon.idCek(adTxt.Text);
                    int odaId = rezervasyon.rezSave(musteriId, dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year, dateTimePicker2.Value.Day, dateTimePicker2.Value.Month, dateTimePicker2.Value.Year);
                    double ucret = rezervasyon.ucretCek(odaId);
                    rezervasyon.odemeSave(musteriId, ucret, dateTimePicker2.Value, dateTimePicker1.Value,0);
                    rezervasyon.odaDoldur(odaId);
                    MessageBox.Show("Rezervasyon başarılı.");

                }
                else if (comboBox1.SelectedItem.ToString() == "60 Gün")
                {
                    if (dateTimePicker1.Value < DateTime.Now.AddDays(60))
                    {
                        MessageBox.Show("60 Gün Önceden rezervasyonlar minimum 60 gün sonraya alınabilir.");
                        dateTimePicker1.Value = DateTime.Now.AddDays(61);
                        dateTimePicker2.Value = DateTime.Now.AddDays(62);
                    }
                    else
                    {
                        rezervasyon = new Rezervasyon();
                        durum = "Ödeme Yapılmadı";
                        rezervasyon.musteriSave(adTxt.Text, comboBox1.SelectedItem.ToString(), durum, mailTxt.Text, kartTxt.Text);
                        int musteriId = rezervasyon.idCek(adTxt.Text);
                        int odaId = rezervasyon.rezSave(musteriId, dateTimePicker1.Value.Day, dateTimePicker1.Value.Month, dateTimePicker1.Value.Year, dateTimePicker2.Value.Day, dateTimePicker2.Value.Month, dateTimePicker2.Value.Year);
                        double ucret = rezervasyon.ucretCek(odaId) * 0.85;
                        rezervasyon.odemeSave(musteriId, ucret, dateTimePicker2.Value, dateTimePicker1.Value,0);
                        rezervasyon.odaDoldur(odaId);
                        MessageBox.Show("Rezervasyon başarılı.");
                    }
                   
                }
                else
                {
                    MessageBox.Show("Lütfen bir rezervasyon tipi seçiniz.");
                }
            }
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                groupBox1.Enabled = false;
            }
            else
            {
                groupBox1.Enabled = true;
            }
        }

        private void adTxt_TextChanged(object sender, EventArgs e)
        {
            label11.Text = adTxt.Text;
        }

        private void kartTxt_KeyUp(object sender, KeyEventArgs e)
        {
            label9.Text = kartTxt.Text;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = comboBox2.Text + "/" + comboBox3.Text;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            label10.Text = comboBox2.Text + "/" + comboBox3.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label12.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //rezervasyon tarih değistirme

            RezervasyonErtele scr = new RezervasyonErtele();
            this.Hide();
            scr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnaMenu menu = new AnaMenu();
            this.Hide();
            menu.Show();
        }
    }
}