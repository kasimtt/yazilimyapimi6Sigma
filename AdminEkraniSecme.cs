using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _6SigmaSoruProgrami
{
    public partial class AdminEkraniSecme : Form
    {
        public AdminEkraniSecme()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void AdminEkraniSecme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizDataSet2.tbl_Sorular' table. You can move, or remove it, as needed.
            this.tbl_SorularTableAdapter.Fill(this.quizDataSet2.tbl_Sorular);
            // TODO: This line of code loads data into the 'quizDataSet1.Tbl_Kullanici' table. You can move, or remove it, as needed.
            this.tbl_KullaniciTableAdapter.Fill(this.quizDataSet1.Tbl_Kullanici);

        }

        private void button_kullaniciListelebutton_kullaniciListele_Click(object sender, EventArgs e)
        {
            this.tbl_KullaniciTableAdapter.Fill(this.quizDataSet1.Tbl_Kullanici);
        }

        private void button_SorulariGüncelle_Click(object sender, EventArgs e)
        {
            this.tbl_SorularTableAdapter.Fill(this.quizDataSet2.tbl_Sorular);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen_deger = dataGridView1.SelectedCells[0].RowIndex;

            label_KullaniciID.Text = dataGridView1.Rows[secilen_deger].Cells[0].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen_deger = dataGridView2.SelectedCells[0].RowIndex;

            label_soruID.Text = dataGridView2.Rows[secilen_deger].Cells[0].Value.ToString();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DFK592O;Initial Catalog=Quiz;Integrated Security=True");
        SqlCommand komut = new SqlCommand();
     
        private void button_KullaniciSil_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = "Delete from Tbl_Kullanici where KullaniciID = @pKullaniciID";
            komut.CommandType = CommandType.Text;
            komut.Parameters.AddWithValue("@pKullaniciID", label_KullaniciID.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("kayıt silindi");


            baglanti.Close();
        }

        private void button_soruSil_Click(object sender, EventArgs e)
        {
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = "Delete from tbl_Sorular where SoruID = @pSoruID";
            komut.CommandType= CommandType.Text ;
            komut.Parameters.AddWithValue("@pSoruID", label_soruID.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("soru silindi");

            baglanti.Close();
        }
    }
}
