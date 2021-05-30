using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Entities
{
    public class Kisi
    {
        public int ID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string EMail { get; set; }
        public string tel { get; set; }
        public byte[] resim { get; set; }

        public override string ToString()
        {
            return isim + " " + soyisim;
        }
    }
}
