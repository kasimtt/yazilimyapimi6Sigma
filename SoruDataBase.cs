using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _6SigmaSoruProgrami
{
    public class SoruDataBase
    {
        SqlConnection baglanti;
        SqlCommand komut;

        public SoruDataBase()
        {
            Baglan();
        }


        private void Baglan()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-DFK592O;Initial Catalog=Quiz;Integrated Security=True");
            komut = new SqlCommand();
            komut.Connection = baglanti;
        }


        public void SoruEkle(Soru soru)
        {
            
            try
            {
                baglanti.Open();
                komut.CommandText = "insert into tbl_Sorular (A,B,C,D,Dogru,UniteID,KonuID,ResimYolu1) values (@pA,@pB,@pC,@pD,@pDogru,@pUniteID,@pKonuID,@pResimYolu)";
                komut.CommandType = CommandType.Text;
                komut.Parameters.AddWithValue("@pA", soru.A);
                komut.Parameters.AddWithValue("@pB", soru.B);
                komut.Parameters.AddWithValue("@pC", soru.C);
                komut.Parameters.AddWithValue("@pD", soru.D);
                komut.Parameters.AddWithValue("@pDogru", soru.Dogru);
                komut.Parameters.AddWithValue("@pUniteID", soru.UniteID);
                komut.Parameters.AddWithValue("@pKonuID", soru.KonuID);
                komut.Parameters.AddWithValue("@pResimYolu", soru.ResimYolu);
                komut.ExecuteNonQuery();

            }
            catch (Exception EX)
            {
                MessageBox.Show(EX + "hatasi aldınız mı?");   
            }
            finally
            {
                if(baglanti != null)
                {
                    baglanti.Close();
                }
            }
        }

        public void SoruSor(Soru soru)
        {
            try
            {
                baglanti.Open();
                komut.CommandText = "select ResimYolu1 , A, B, C, D, Dogru from tbl_Sorular order by NEWID()";
                komut.CommandType = CommandType.Text;
                SqlDataReader oku = komut.ExecuteReader();

                while(oku.Read())
                {
                    soru.A = (oku["A"].ToString());
                    soru.B = (oku["B"].ToString());
                    soru.C = (oku["C"].ToString());
                    soru.D = (oku["D"].ToString());
                    soru.ResimYolu = (oku["ResimYolu1"].ToString());
                    soru.Dogru = (oku["Dogru"].ToString());

                }


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(baglanti !=null)
                {
                    baglanti.Close();
                }
            }
        }

    }
}
