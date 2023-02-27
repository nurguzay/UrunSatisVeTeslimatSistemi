using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace proje
{
    public partial class MusteriKayit : Form
    {
        public MusteriKayit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void musKayit_Click(object sender, EventArgs e)
        {
            SqlBaglantisi sql = new SqlBaglantisi();

            string da = "INSERT INTO Kullanici (AdiSoyadi , DogumTarihi, Telefon, Adres , Email ) VALUES ( @p1,@p2,@p3,@p4,@p5)";
            var baglan = sql.baglanti();
            baglan.Open();
            SqlCommand ekle = new SqlCommand(da, baglan);
            ekle.Parameters.AddWithValue("@p1", txtName.Text);
            ekle.Parameters.AddWithValue("@p2", dtBirthday.Value);
            ekle.Parameters.AddWithValue("@p3", Convert.ToInt64(txtPhone.Text));
            ekle.Parameters.AddWithValue("@p4", txtAdress.Text);
            ekle.Parameters.AddWithValue("@p5", txtMail.Text);
            ekle.ExecuteNonQuery();
            baglan.Close();
            MessageBox.Show("Müþteri Kaydedildi.");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MusteriGiris form2 = new MusteriGiris();
            form2.Show();
        }
    }
}