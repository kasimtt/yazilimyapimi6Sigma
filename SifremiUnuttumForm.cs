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
    public partial class SifremiUnuttumForm : Form
    {
        public SifremiUnuttumForm()
        {
            InitializeComponent();
        }

        private void button_YeniSifre_Click(object sender, EventArgs e)
        {
            
            if(textBox_KullaniciAdi.Text == "")
            {
                MessageBox.Show("kullanıcı adınızı giriniz");
            }
            else
            {
                label_yenisifre.Visible = true;
                textBox_Sifre.Visible = true;    
                button_SifreyiKaydet.Visible = true;
            }
        
        }

        private void button_SifreyiKaydet_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            personel.KullaniciAdi = textBox_KullaniciAdi.Text;
            personel.Sifre = textBox_Sifre.Text;    
            PersonelDatabase personelDatabase = new PersonelDatabase();
            bool dogruMu=personelDatabase.SifreGüncelle(personel);

            if (dogruMu == true)
            {
                MessageBox.Show("şifreniz değiştirilmiştir");
                Form1 form = new Form1();
                this.Hide();
                form.Show();
            }
            else
                MessageBox.Show("kullanici Adınız bulunamamıştır. Lütfen kontrol ediniz...");
            
        }
    }
}
