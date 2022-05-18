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
    internal class PersonelDatabase
    {
        //personel kayıt işlemi icin gerekli kodlar
        SqlConnection baglanti;
        SqlCommand komut;

        public PersonelDatabase()
        {
            Baglan();
        }

        private void Baglan()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-DFK592O;Initial Catalog=Quiz;Integrated Security=True");
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }

        public void Kayit(Personel p)
        {
          try
            {
                baglanti.Open();
                komut.CommandText = "insert into Tbl_Kullanici (KullaniciAdi,Ad,Soyad,Sifre,Email,KullaniciTipiID) values (@pKullaniciAdi,@pAd,@pSoyad,@pSifre,@pEmail,@pKullaniciTipiId)"; 
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@pKullaniciAdi",p.KullaniciAdi);
                komut.Parameters.AddWithValue("@pAd", p.Ad);
                komut.Parameters.AddWithValue("@pSoyad", p.Soyad);
                komut.Parameters.AddWithValue("@pSifre", p.Sifre);
                komut.Parameters.AddWithValue("@pEmail", p.Email);
                komut.Parameters.AddWithValue("@pKullaniciTipiId", p.KullaniciTipi);
                komut.ExecuteNonQuery();
                
            }
            catch (Exception)
            {
                MessageBox.Show("sifreler eşleşmiyor.");
            }
            finally
            {
                if(baglanti != null)
                {
                  baglanti.Close();  
                }
            }
        }


        public bool Giris(Personel p)
        {
            
            try
            {
                baglanti.Open();
                //@kKullaniciTipi ile giris methodumuzu 3 tip icinde kullanabiliriz.
                komut.CommandText = "select * from Tbl_Kullanici where KullaniciTipiID = @kKullaniciTipiId";
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@kKullaniciTipiId", p.KullaniciTipi);
                SqlDataReader reader = komut.ExecuteReader();
                while (reader.Read())
                {
                    if (p.KullaniciAdi == reader["KullaniciAdi"].ToString() && p.Sifre == reader["Sifre"].ToString())
                    {
                        return true;
                    }
                    
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex + "hatası aldınız");
            }
            finally
            {
                if(baglanti!=null)
                {
                    baglanti.Close();
                }
            }
            return false;
            
        }

        public bool SifreGüncelle(Personel p)
        {

            baglanti.Open();
            //@kKullaniciTipi ile giris methodumuzu 3 tip icinde kullanabiliriz.
            komut.CommandText = "select * from Tbl_Kullanici";
            komut.CommandType = CommandType.Text;
    
            SqlDataReader reader = komut.ExecuteReader();
            while (reader.Read())
            {
                if (p.KullaniciAdi == reader["KullaniciAdi"].ToString())
                {
                    
                        SqlConnection baglanti1 = new SqlConnection("Data Source=DESKTOP-DFK592O;Initial Catalog=Quiz;Integrated Security=True");
                        SqlCommand komut1 = new SqlCommand();
                        komut1.Connection = baglanti1;
                        baglanti1.Open();
                        komut1.CommandText = "update Tbl_Kullanici Set Sifre=@pYenisifre where KullaniciAdi=@pKullaniciadi";
                        komut1.CommandType = CommandType.Text;
                        komut1.Parameters.AddWithValue("@pYeniSifre", p.Sifre);
                        komut1.Parameters.AddWithValue("@pKullaniciadi", p.KullaniciAdi);
                        komut1.ExecuteNonQuery();

                        baglanti1.Close();
                    return true;
                }

            }
            baglanti.Close();
            return false;
           
        }

    }
}