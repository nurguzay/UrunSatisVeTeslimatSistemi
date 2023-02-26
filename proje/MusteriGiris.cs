using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace proje
{
    public partial class MusteriGiris : Form
    {
        public MusteriGiris()
        {
            InitializeComponent();
        }

        private void musKayit_Click(object sender, EventArgs e)
        {
            this.Hide();
            MusteriKayit form = new MusteriKayit();
            form.Show();
        }

        private void musList_Click(object sender, EventArgs e)
        {
            SqlBaglantisi sql = new SqlBaglantisi();
            string dt = "SELECT AdiSoyadi , Telefon , Adres From Kullanici; ";
            var baglan = sql.baglanti();
            baglan.Open();
            SqlDataAdapter listele = new SqlDataAdapter(dt, baglan);
            DataSet ds = new DataSet();
            listele.Fill(ds);
            MusteriListele.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void UrunListele_Click(object sender, EventArgs e)
        {
            this.Hide();
            Urunler form = new Urunler();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
