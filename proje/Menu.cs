﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MusteriGiris giris = new MusteriGiris();
            giris.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Urunler urunler = new Urunler();
            urunler.Show();
        }
    }
}
