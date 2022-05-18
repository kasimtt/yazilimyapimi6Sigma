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
    public partial class OgrenciForm : Form
    {
        public OgrenciForm()
        {
            InitializeComponent();
        }

        private void button_giris_Click(object sender, EventArgs e)
        {

           
            bool GirdiMi;
            Personel personel = new Personel();
            PersonelDatabase personelGiris = new PersonelDatabase(); // yapıcı methodla bağlan methodu çalıştı..
            personel.KullaniciTipi = 3;//öğrenci tipi olduğu icin kullanici tipini 3 alıyoruz.
            personel.KullaniciAdi = textBox_kullaniciAdi.Text;
            personel.Sifre = textBox_şifre.Text;


           


            GirdiMi = personelGiris.Giris(personel);

            if (GirdiMi)
            {
                OgrenciEkranSecmeForm ogrenciEkranSecmeForm = new OgrenciEkranSecmeForm();
                ogrenciEkranSecmeForm.label_KullaniciAdi.Text = textBox_kullaniciAdi.Text;
                this.Hide();
                ogrenciEkranSecmeForm.ShowDialog();

                
                
                
                
            }
            else
                MessageBox.Show("giriş yapılamadı");
               
        }

        private void checkBox_sifreGizle_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_sifreGizle.Checked)
            {
                textBox_şifre.PasswordChar = '*';
                checkBox_sifreGizle.Text = "Şifreyi Göster";
            }
            else
            {
                textBox_şifre.PasswordChar = '\0';
                checkBox_sifreGizle.Text = "Sifteyi Gizle";
            }
        }

        private void button_şifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttumForm form = new SifremiUnuttumForm();
            this.Hide();
            form.Show();
        }
    }
}
