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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public Çalışan user;
        public UserProvider giris;
        private void girisBttn_Click(object sender, EventArgs e)
        {
            giris = new UserProvider();
            user = giris.getUser(kullaniciAdiTextBox.Text, sifreTextBox.Text);
            if (user != null)
            {
                if (user.KullaniciAdi == "admin"&& user.Password =="admin")
                {
                    AdminPanel main = new AdminPanel();
                    this.Hide();
                    main.Location = this.Location;
                    main.Show();
                }
                else
                {
                    ÇalışanMenu main = new ÇalışanMenu();
                    this.Hide();
                    main.Location = this.Location;
                    main.Show();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Hata!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnaMenu menu = new AnaMenu();
            menu.Show();
            this.Hide();
        }
    }
}
