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
    public partial class SoruEklemeFormu : Form
    {
        public SoruEklemeFormu()
        {
            InitializeComponent();
        }

        
      

       

        private void button_ResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            textBox_Soru.Text = openFileDialog1.FileName;
            
        }

        private void button_kaydet_Click(object sender, EventArgs e)
        {
            Soru soru = new Soru();
            soru.KonuID = comboBox_Konu.SelectedIndex + 1;
            soru.UniteID = comboBox_unite.SelectedIndex + 1;
            soru.ResimYolu = textBox_Soru.Text;
            soru.Dogru = textBox_DogruSik.Text;
            soru.A = textBox_ASikki.Text;
            soru.B = textBox_BSikki.Text;
            soru.C = textBox_CSikki.Text;
            soru.D = textBox_DSikki.Text;
            SoruDataBase soruDataBase = new SoruDataBase();
            soruDataBase.SoruEkle(soru);
            MessageBox.Show("Soru kaydedildi...");
            Temizle();

        }

        private void Temizle()
        {
            comboBox_Konu.Text = "";
            comboBox_unite.Text = "";
            textBox_Soru.Text = "";
            textBox_DogruSik.Text = "";
            textBox_ASikki.Text = "";
            textBox_BSikki.Text = "";
            textBox_CSikki.Text = "";
            textBox_DSikki.Text = "";
        }

        private void SoruEklemeFormu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizDataSetBitti.QuizView' table. You can move, or remove it, as needed.
            this.quizViewTableAdapter.Fill(this.quizDataSetBitti.QuizView);

        }



        private void button_listele_Click_1(object sender, EventArgs e)
        {
            this.quizViewTableAdapter.Fill(this.quizDataSetBitti.QuizView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }
    }
}
