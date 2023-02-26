using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Urunler : Form
    {
        public Urunler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MusteriGiris form = new MusteriGiris();
            form.Show();
        }

        private void UrunListele_Click(object sender, EventArgs e)
        {
            SqlBaglantisi sql = new SqlBaglantisi();
            string dt = "SELECT Urunler.Id , UrunAdi , UrunAciklamasi , UrunFiyati , AdiSoyadi FROM Urunler JOIN Kullanici ON Kullanici.Id = Urunler.KullaniciId;";
            var baglan = sql.baglanti();
            baglan.Open();
            SqlDataAdapter listele = new SqlDataAdapter(dt, baglan);
            DataSet ds = new DataSet();
            listele.Fill(ds);
            DtUrunListele.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in DtUrunListele.SelectedRows)  //Seçili Satırları Silme
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                SqlBaglantisi sql = new SqlBaglantisi();
                var baglan = sql.baglanti();
                baglan.Open();
                string dt = "DELETE FROM URUNLER WHERE Id = " + numara;
                SqlCommand com = new SqlCommand(dt , baglan);
                com.ExecuteNonQuery();
                baglan.Close();
                if (this.DtUrunListele.SelectedRows.Count > 0)
                {
                    DtUrunListele.Rows.RemoveAt(this.DtUrunListele.SelectedRows[0].Index);
                }
            }
        }

        private void Urunler_Load(object sender, EventArgs e)
        {

        }
    }
}
