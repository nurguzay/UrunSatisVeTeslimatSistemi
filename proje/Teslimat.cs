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
    public partial class Teslimat : Form
    {
        public Teslimat()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Urunler form = new Urunler();
            form.Show();
        }

        private void Teslimat_Load(object sender, EventArgs e)
        {
            SqlBaglantisi sql = new SqlBaglantisi();
            string dt = "SELECT * FROM Teslimat";
            var baglan = sql.baglanti();
            baglan.Open();
            SqlDataAdapter listele = new SqlDataAdapter(dt, baglan);
            DataSet ds = new DataSet();
            listele.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglan.Close();
        }
    }
}
