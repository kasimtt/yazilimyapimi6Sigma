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
    public partial class EgzersizYapForm : Form
    {
        public EgzersizYapForm()
        {
            InitializeComponent();
        }
        int dogruSayisi = 0;
        int soruSayisi = 0;
        string Dogru;
        private void button_basla_Click(object sender, EventArgs e)
        {
            label_dogruCevapGoster.Visible = false;
            button_basla.Enabled = false;
            button_cevapla.Enabled = true;
            radioButton_birinciSik.Visible = true;
            radioButton_ikinciSik.Visible = true;
            radioButton_ucuncuSik.Visible = true;
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
            Dogru = soru.Dogru;  
            label_Dogru.Text = Dogru; // dogru cevabı tutaan label
           ; //şimdilik burada tutuyorum daha sonra cevaplaya taşınacaktır

            RadioButtonlarıFalseYap();
        }
        private void RadioButtonlarıFalseYap()
        {
            radioButton_birinciSik.Checked = false;
            radioButton_ikinciSik.Checked = false;
            radioButton_ucuncuSik.Checked = false;
            radioButton_dorduncuSik.Checked = false;
        }

        private void EgzersizYap_Load(object sender, EventArgs e)
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

            label_dogruSayisi.Text = dogruSayisi.ToString();
            button_cevapla.Enabled = false;
            button_basla.Enabled = true;
            label_dogruCevapGoster.Visible = true;
            label_dogruCevapGoster.Text = Dogru;
           
        }

        private void button_testiBitir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dogru Sayisi : " + dogruSayisi + "\n" + "Yanlış Sayısı : " + (soruSayisi - dogruSayisi));
            OgrenciEkranSecmeForm form = new OgrenciEkranSecmeForm();
            form.Show();
            this.Hide();
        }
    }
}
