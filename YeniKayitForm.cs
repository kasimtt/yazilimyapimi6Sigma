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
    public partial class YeniKayitForm : Form
    {
        public YeniKayitForm()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            textBox_Ad.Text = "";
            textBox_Soyad.Text = "";
            textBox_Sifre.Text = "";
            textBox_KullaniciAdi.Text = "";
            textBox_Sifre2.Text = "";
            textBox_Email.Text = "";
            comboBox_kullaniciTipi.Text = "seçiniz";
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            PersonelDatabase kayit = new PersonelDatabase();

           
            
            
            if(textBox_Sifre.Text == textBox_Sifre2.Text)
            {
                
                personel.Sifre = textBox_Sifre2.Text;
                personel.Ad = textBox_Ad.Text;
                personel.Soyad = textBox_Soyad.Text;
                personel.Email = textBox_Email.Text;
                personel.KullaniciAdi = textBox_KullaniciAdi.Text;

                if (comboBox_kullaniciTipi.Text == "Admin")
                    personel.KullaniciTipi = 1;
                else if (comboBox_kullaniciTipi.Text == "Sınav Sorumlusu")
                    personel.KullaniciTipi = 2;
                else
                    personel.KullaniciTipi = 3;
                MessageBox.Show("kayıt tamamlandı...");
            }
            else
            {
                
                textBox_Sifre.Text = "";
                textBox_Sifre2.Text = "";
                
            }
            
            Temizle();
            kayit.Kayit(personel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
