using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje
{
    public partial class UrunGuncelle : Form
    {
        public UrunGuncelle()
        {
            InitializeComponent();
        }

        SqlBaglantisi sql = new SqlBaglantisi();
        SqlCommandBuilder sqlbuild;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        
        void show()
        {
            var baglan = sql.baglanti();
            baglan.Open();
            da = new SqlDataAdapter("SELECT * FROM Urunler ", baglan);
            da.Fill(ds, "Urunler");
            dtUrunGuncelle.DataSource = ds.Tables["Urunler"];
            baglan.Close();
        }

        private void UrunGuncelle_Load(object sender, EventArgs e)
        {
            show();
        }

        private void guncelle_Click(object sender, EventArgs e)
        {
            sqlbuild = new SqlCommandBuilder(da);
            da.Update(ds, "Urunler");
            MessageBox.Show("GÜNCELLENDİ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Urunler form = new Urunler();
            form.Show();
        }
    }
}
