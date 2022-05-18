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
    public partial class SinavOlmaFormu : Form
    {
        public string KullaniciAdi1 { get; set; }
        public SinavOlmaFormu()
        {
            InitializeComponent();
        }
        int dogruSayisi = 0;
        int soruSayisi = 0;
        string dogru;
        int dakika = 9;
        int saniye = 60;
        private void button_basla_Click(object sender, EventArgs e)
        {
            timer1.Start();

            button_basla.Enabled = false;
            button_cevapla.Enabled = true;
            radioButton_birinciSik.Visible = true;
            radioButton_ikinciSik.Visible=true;
            radioButton_ucuncuSik.Visible=true;
            radioButton_dorduncuSik.Visible = true;
            soruSayisi += 1;



            SoruDataBase soruDataBase = new SoruDataBase();
            Soru soru = new Soru();
          
            button_basla.Text = "Sonraki";
            soruDataBase.SoruSor(soru);

            pictureBox_SoruResmi.ImageLocation = soru.ResimYolu;
            radioButton_birinciSik.Text = soru.A;
            radioButton_ikinciSik.Text = soru.B;
            radioButton_ucuncuSik.Text = soru.C;
            radioButton_dorduncuSik.Text = soru.D;
            label_Dogru.Text = soru.Dogru;


            


            if (soruSayisi == 10)
            {
                
                RaporDatabase raporDatabase = new RaporDatabase();
                Rapor rapor = new Rapor();
                rapor.KullaniciAdi = label_Kullanici.Text;
                rapor.ToplamDogru = dogruSayisi;
                rapor.ToplamYanlıs = (10 - dogruSayisi);
                rapor.Tarih = DateTime.Now.ToString();
                raporDatabase.SonucEkle(rapor);
                MessageBox.Show("Sınav Bitti ");
                MessageBox.Show("Dogru Sayisi : " + rapor.ToplamDogru + "\n" + "Yanlış Sayisi : " + rapor.ToplamYanlıs);

                OgrenciEkranSecmeForm ogrenciEkranSecmeForm = new OgrenciEkranSecmeForm();
                ogrenciEkranSecmeForm.Show();
                this.Hide();
            }
            RadioButtonlarıFalseYap();
       
        }

        private void RadioButtonlarıFalseYap()
        {
            radioButton_birinciSik.Checked = false;
            radioButton_ikinciSik.Checked = false;
            radioButton_ucuncuSik.Checked = false;
            radioButton_dorduncuSik.Checked = false;
        }
         
        
   

        private void SinavOlmaFormu_Load(object sender, EventArgs e)
        {
            button_cevapla.Enabled = false;
            radioButton_birinciSik.Checked = false;
            radioButton_ikinciSik.Checked = false;
            radioButton_ucuncuSik.Checked = false;
            radioButton_dorduncuSik.Checked = false;
            radioButton_birinciSik.Visible = false;
            radioButton_ikinciSik.Visible = false;
            radioButton_ucuncuSik.Visible = false;
            radioButton_dorduncuSik.Visible = false;
        }

        private void button_cevapla_Click(object sender, EventArgs e)
        {

            if ((radioButton_birinciSik.Checked == true) && (radioButton_birinciSik.Text == label_Dogru.Text))
            {
                dogruSayisi = dogruSayisi + 1;
                

            }
            else if ((radioButton_ikinciSik.Checked == true) && (radioButton_ikinciSik.Text == label_Dogru.Text))
            {
                dogruSayisi = dogruSayisi + 1;
            }
            else if ((radioButton_ucuncuSik.Checked == true) && (radioButton_ucuncuSik.Text == label_Dogru.Text))
            {
                dogruSayisi = dogruSayisi + 1;
            }
            else if ((radioButton_dorduncuSik.Checked == true) && (radioButton_dorduncuSik.Text == label_Dogru.Text))
            {
                dogruSayisi = dogruSayisi + 1;
            }

           
            button_cevapla.Enabled = false;
            button_basla.Enabled = true;
         
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            saniye = saniye - 1;
            label_Saniye.Text = saniye.ToString();
            label_Dakika.Text = dakika.ToString();

            if(saniye == 0)
            {
                dakika = dakika - 1;
                saniye = 60;
                label_Dakika.Text = dakika.ToString();

            }
            if(label_Dakika.Text == "0" && label_Saniye.Text =="0")
            {
                timer1.Stop() ;
                RaporDatabase raporDatabase = new RaporDatabase();
                Rapor rapor = new Rapor();
                rapor.KullaniciAdi = label_Kullanici.Text;
                rapor.ToplamDogru = dogruSayisi;
                rapor.ToplamYanlıs = (soruSayisi - dogruSayisi);
                rapor.Tarih = DateTime.Now.ToString();
                raporDatabase.SonucEkle(rapor);
                MessageBox.Show("süreniz bitti...");
                MessageBox.Show("Doğru Sayısı  : " + rapor.ToplamDogru+ "\n" + "Yanlış Sayısı : " + rapor.ToplamYanlıs);

                OgrenciEkranSecmeForm ogrenciEkranSecmeForm = new OgrenciEkranSecmeForm();
                ogrenciEkranSecmeForm.Show();
                this.Hide();



            }
        }

        
    }
}
