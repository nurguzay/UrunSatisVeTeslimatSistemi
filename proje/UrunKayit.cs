using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace proje
{
    public partial class UrunKayit : Form
    {
        public UrunKayit()
        {
            InitializeComponent();
        }

        private void urunEkle_Click(object sender, EventArgs e)
        {
            SqlBaglantisi sql = new SqlBaglantisi();

            string da = "INSERT INTO Urunler (UrunAdi , UrunAciklamasi, UrunFiyati, Adet, Satildi) VALUES ( @p1,@p2,@p3,@p4,@p5)";
            var baglan = sql.baglanti();
            baglan.Open();
            SqlCommand ekle = new SqlCommand(da, baglan);
            ekle.Parameters.AddWithValue("@p1", txtUName.Text);
            ekle.Parameters.AddWithValue("@p2", txtDesc.Text);
            ekle.Parameters.AddWithValue("@p3", Convert.ToInt64(txtPrise.Text));
            ekle.Parameters.AddWithValue("@p4", Convert.ToInt64(urunAdet.Text));
            if (satildi.Checked == false && satilmadi.Checked == false)
            {
                MessageBox.Show("LÜTFEN SATILIP SATILMADIĞINI İŞARETLEYİN.");
                return;
            }


            bool stat = true;
            if (satildi.Checked == true)
            {
                stat = true;
            }
            if (satilmadi.Checked == true)
            {
                stat = false;
            }
            ekle.Parameters.AddWithValue("@p5", stat);

            ekle.ExecuteNonQuery();
            MessageBox.Show("ÜRÜN KAYDEDİLDİ");
            baglan.Close();
            this.Hide();
            Urunler form = new Urunler();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Urunler form = new Urunler();
            form.Show();
        }
    }
}
