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

        private void main_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu form = new Menu();
            form.Show();
        }

        private void UrunListele_Click(object sender, EventArgs e)
        {
            SqlBaglantisi sql = new SqlBaglantisi();
            string dt = "SELECT Id , UrunAdi , UrunAciklamasi , UrunFiyati , Satildi FROM Urunler WHERE Satildi = 1 ;";
            var baglan = sql.baglanti();
            baglan.Open();
            SqlDataAdapter listele = new SqlDataAdapter(dt, baglan);
            DataSet ds = new DataSet();
            listele.Fill(ds);
            DtUrunListele.DataSource = ds.Tables[0];
            baglan.Close();
        }

        private void urunSil_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in DtUrunListele.SelectedRows)  
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

        private void urunEkle_Click(object sender, EventArgs e)
        {
            this.Hide();
            UrunKayit form = new UrunKayit();
            form.Show();
        }

        private void urunGuncelle_Click(object sender, EventArgs e)
        {
            this.Hide();
            UrunGuncelle form = new UrunGuncelle();
            form.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlBaglantisi sql = new SqlBaglantisi();
            string dt = "SELECT * FROM Urunler";
            var baglan = sql.baglanti();
            baglan.Open();
            SqlDataAdapter listele = new SqlDataAdapter(dt, baglan);
            DataSet ds = new DataSet();
            listele.Fill(ds);
            DtUrunListele.DataSource = ds.Tables[0];
            baglan.Close();
        }
    }
}
