using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6SigmaSoruProgrami
{
    public partial class RaporFormucs : Form
    {
        public RaporFormucs()
        {
            InitializeComponent();
        }

        private void button_Listele_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-DFK592O;Initial Catalog=Quiz;Integrated Security=True");
            SqlCommand komut = new SqlCommand();
            komut.Connection = baglanti;
            baglanti.Open();
            komut.CommandText = "select KullaniciAdi,DogruSayisi,YanlisSayisi ,SinavTarihi from Table_Sonuc where KullaniciAdi = @pKullaniciAdi";
            komut.Parameters.AddWithValue("@pKullaniciAdi", label_kullaniciAdiRapor.Text);
            komut.CommandType = CommandType.Text;
            SqlDataReader oku = komut.ExecuteReader();
            while(oku.Read())
            {
                ListViewItem oge = new ListViewItem(oku["KullaniciAdi"].ToString());
                oge.SubItems.Add(oku["DogruSayisi"].ToString());
                oge.SubItems.Add(oku["YanlisSayisi"].ToString());
                oge.SubItems.Add(oku["SinavTarihi"].ToString());
                listView1.Items.Add(oge);
            }


            baglanti.Close();

        }

        private void button_anaMenu_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
