using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace _6SigmaSoruProgrami
{
    internal class RaporDatabase
    {
        SqlConnection baglanti;
        SqlCommand komut;

        public RaporDatabase()
        {
            Baglan();
        }
        private void Baglan()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-DFK592O;Initial Catalog=Quiz;Integrated Security=True");
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }


        public void SonucEkle(Rapor rapor)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = "insert into Table_Sonuc (DogruSayisi , YanlisSayisi , KullaniciAdi , SinavTarihi ) values (@pDogruSayisi, @pYanlisSayisi, @pKullaniciAdi, @pSinavTarihi)";
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@pDogruSayisi", rapor.ToplamDogru);
                komut.Parameters.AddWithValue("@pYanlisSayisi", rapor.ToplamYanlıs);
                komut.Parameters.AddWithValue("@pKullaniciAdi", rapor.KullaniciAdi);
                komut.Parameters.AddWithValue("@pSinavTarihi", rapor.Tarih);
                komut.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "hatası aldınız");
                
            }
            finally
            {
                if(baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }
        


    }
}
