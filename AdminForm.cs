using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6SigmaSoruProgrami
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            bool GirdiMi;
            Personel personel = new Personel();
            PersonelDatabase personelGiris = new PersonelDatabase(); // yapıcı method ile bağlan() methodu çalışır...

            personel.KullaniciAdi = textBox_KullaniciAdi.Text;
            personel.Sifre = textBox_KullaniciSifre.Text;
            personel.KullaniciTipi = 1; // admin olduğu icin tip idsini 1 veriyoruz.

            GirdiMi = personelGiris.Giris(personel);

            if(GirdiMi)
            {
                AdminEkraniSecme secme = new AdminEkraniSecme();
                secme.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Giris başarisiz");
            }

        }

        private void checkBox_SifreGizle_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_SifreGizle.Checked == true)
            {
                checkBox_SifreGizle.Text = "Sifreyi Göster";
                textBox_KullaniciSifre.PasswordChar = '*';
            }
            else
            {
                checkBox_SifreGizle.Text = "Şifreyi Gizle";
                textBox_KullaniciSifre.PasswordChar = '\0' ;
            }
        }

        private void button_şifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttumForm sifremiUnuttumForm = new SifremiUnuttumForm();
            this.Hide();
            sifremiUnuttumForm.Show();
            
        }
    }
}
