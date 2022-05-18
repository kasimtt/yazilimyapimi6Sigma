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
    public partial class OgrenciEkranSecmeForm : Form
    {
        public OgrenciEkranSecmeForm()
        {
            InitializeComponent();
        }

        private void button_SinavYap_Click(object sender, EventArgs e)
        {
            SinavOlmaFormu sinavOlmaFormu = new SinavOlmaFormu();
            sinavOlmaFormu.label_Kullanici.Text = label_KullaniciAdi.Text;  
            this.Hide();
            sinavOlmaFormu.ShowDialog();
            
        }

        private void button_Rapor_Click(object sender, EventArgs e)
        {
            RaporFormucs raporformucs = new RaporFormucs();
            raporformucs.label_kullaniciAdiRapor.Text = label_KullaniciAdi.Text;
            this.Hide();
            raporformucs.ShowDialog();
        }

        private void button_anaMenu_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button_EksersizYap_Click(object sender, EventArgs e)
        {
            EgzersizYapForm form = new EgzersizYapForm();
            form.Show();
            this.Hide();
        }
    }
}
