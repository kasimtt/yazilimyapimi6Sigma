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
    public partial class SınavSorumlusuForm : Form
    {
        public SınavSorumlusuForm()
        {
            InitializeComponent();
        }

        private void button_giris_Click(object sender, EventArgs e)
        {
            bool GirdiMi;

            Personel personel = new Personel();
            PersonelDatabase PersonelGiris = new PersonelDatabase();
            personel.KullaniciTipi = 2;
            personel.KullaniciAdi = textBox_kullaniciAdi.Text;
            personel.Sifre = textBox_şifre.Text;  // sınav sorumlusu olduğu için 2 girdik

            GirdiMi = PersonelGiris.Giris(personel);

            if (GirdiMi)
            {

                SoruEklemeFormu soruEklemeFormu = new SoruEklemeFormu();
                soruEklemeFormu.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Giriş başarısız...","program");


        }

        private void checkBox_SifreGizle_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_SifreGizle.Checked)
            {
                checkBox_SifreGizle.Text = "Şifreyi Göster";
                textBox_şifre.PasswordChar = '*';
            }
            else
            {
                checkBox_SifreGizle.Text = "Şifreyi Gizle";
                textBox_şifre.PasswordChar = '\0';
            }
        }

        private void button_SifremiUnuttum_Click(object sender, EventArgs e)
        {
            SifremiUnuttumForm form = new SifremiUnuttumForm();
            form.Show();
            this.Hide();
        }
    }
}
