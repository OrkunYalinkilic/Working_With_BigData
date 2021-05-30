using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Operasyon
{
    public class DataAcessLayer : Base.Yardim
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public DataAcessLayer()
        {
            con = new SqlConnection(@"Data Source=DESKTOP-O9HL0H1\SQLEXPRESS;Initial Catalog=BuyukDatalarIleCalismak;Integrated Security=True");
        }

        public void BaglantiAyarla()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
            else
                con.Open();
        }

        public int KayitEKLE(Entities.Kisi kisi)
        {
            int returnValue = 0;

            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("KisiEkle", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.Add("@isim", SqlDbType.NVarChar).Value = kisi.isim;
                cmd.Parameters.Add("@soyisim", SqlDbType.NVarChar).Value = kisi.soyisim;
                cmd.Parameters.Add("@EmailAdres", SqlDbType.NVarChar).Value = kisi.EMail;
                cmd.Parameters.Add("@TelefonNumarasi", SqlDbType.NVarChar).Value = kisi.tel;
                cmd.Parameters.Add("@Resim", SqlDbType.VarBinary).Value = kisi.resim;
                BaglantiAyarla();
                returnValue = cmd.ExecuteNonQuery();
                BaglantiAyarla();
            });
            return returnValue;
        }

        public SqlDataReader KisiDetayGetir(int id)
        {
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("select * from Kisiler where ID = @id", con);
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;
                BaglantiAyarla();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }

        public SqlDataReader KisiListeGetir()
        {
            TryCatchKullan(() =>
            {
                cmd = new SqlCommand("select * from Kisiler", con);
                BaglantiAyarla();
                reader = cmd.ExecuteReader();
            });
            return reader;
        }


    }
}
