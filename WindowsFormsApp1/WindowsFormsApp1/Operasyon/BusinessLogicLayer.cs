using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entities;

namespace WindowsFormsApp1.Operasyon
{
    public class BusinessLogicLayer
    {
        DataAcessLayer dataAccessLayer;
        public BusinessLogicLayer()
        {
            dataAccessLayer = new DataAcessLayer();
        }
    
        public int KayitEKLE(string isim,string soyisim,string emailadres,string tel, byte[] resim)
        {
            // Kontrol işlemleri bu katmanda yapılır.

            Kisi kisi = new Kisi()
            {
                isim = isim,
                soyisim = soyisim,
                EMail = emailadres,
                tel = tel,
                resim = resim
            };
            return dataAccessLayer.KayitEKLE(kisi);

        }

        public Kisi KisiDetayGetir(int id)
        {
            // Kontrol işlemlerini yapabiliriz.
            Kisi kisi = new Kisi();
            SqlDataReader reader = dataAccessLayer.KisiDetayGetir(id);

            while (reader.Read())
            {
                kisi.ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0);
                kisi.isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                kisi.soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                kisi.EMail = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                kisi.tel = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                kisi.resim = reader.IsDBNull(5) ? null :(byte[]) reader[5];
            } 
            reader.Close();
            dataAccessLayer.BaglantiAyarla();
            //?

            return kisi;
        }

        public List<Kisi> KisiListeGetir()
        {
            List<Kisi> kisiler = new List<Kisi>();
            SqlDataReader reader = dataAccessLayer.KisiListeGetir();
            while (reader.Read())
            {
                kisiler.Add(new Kisi() // her döndüğünde yeni kisi..
                {
                ID = reader.IsDBNull(0) ? 0 : reader.GetInt32(0),
                isim = reader.IsDBNull(1) ? string.Empty : reader.GetString(1),
                soyisim = reader.IsDBNull(2) ? string.Empty : reader.GetString(2),
                EMail = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                tel = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                resim = reader.IsDBNull(5) ? null : (byte[])reader[5]
            });
            }
            reader.Close();
            dataAccessLayer.BaglantiAyarla();

            return kisiler;
        }

    }
}
