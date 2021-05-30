using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Operasyon;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Image img;
        BusinessLogicLayer bll;

        public Form1()
        {
            InitializeComponent();
            bll = new BusinessLogicLayer();
           List<Entities.Kisi> Kisiler = bll.KisiListeGetir();
            cmbKisiListesi.DataSource = Kisiler;
        }

        private void btnResimEkle_Click(object sender, EventArgs e)
        {
            OFD.ShowDialog();
            img = Image.FromFile(OFD.FileName);
            pctResim.SizeMode = PictureBoxSizeMode.StretchImage;
            pctResim.Image = img;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            MemoryStream mem = new MemoryStream(); // ramde bir stream olusturdum.
            img.Save(mem, System.Drawing.Imaging.ImageFormat.Jpeg); // olusturdugum memory içerisine resmi atıyorum.
            int returnValue = bll.KayitEKLE(txtIsim.Text, txtSoyisim.Text, txtEMail.Text, txtTelefon.Text, mem.ToArray());
            if (returnValue>0)
            {
                MessageBox.Show("Başarılı");
            }
            else
            {
                MessageBox.Show("Başarısız");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cmbKisiListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox secilen = (ComboBox)sender;
            Entities.Kisi secilenKisi = (Entities.Kisi) secilen.SelectedItem;
            secilenKisi = bll.KisiDetayGetir(secilenKisi.ID);
            txtDGisim.Text = secilenKisi.isim;
            txtDGsoyisim.Text = secilenKisi.soyisim;
            txtDGTelefon.Text = secilenKisi.tel;
            txtDGEmail.Text = secilenKisi.EMail;

            MemoryStream mem = new MemoryStream(secilenKisi.resim); // byte diziden geri okuma işlemi
            Image img = Image.FromStream(mem);
            pctDGResim.Image = img;
            pctDGResim.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
