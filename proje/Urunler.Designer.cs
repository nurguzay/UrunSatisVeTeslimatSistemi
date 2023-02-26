namespace proje
{
    partial class Urunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DtUrunListele = new System.Windows.Forms.DataGridView();
            this.UrunListele = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Button();
            this.urunSil = new System.Windows.Forms.Button();
            this.urunEkle = new System.Windows.Forms.Button();
            this.urunGuncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtUrunListele)).BeginInit();
            this.SuspendLayout();
            // 
            // DtUrunListele
            // 
            this.DtUrunListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtUrunListele.Location = new System.Drawing.Point(28, 193);
            this.DtUrunListele.Name = "DtUrunListele";
            this.DtUrunListele.ReadOnly = true;
            this.DtUrunListele.RowHeadersWidth = 51;
            this.DtUrunListele.RowTemplate.Height = 29;
            this.DtUrunListele.Size = new System.Drawing.Size(451, 224);
            this.DtUrunListele.TabIndex = 0;
            // 
            // UrunListele
            // 
            this.UrunListele.Location = new System.Drawing.Point(53, 56);
            this.UrunListele.Name = "UrunListele";
            this.UrunListele.Size = new System.Drawing.Size(295, 29);
            this.UrunListele.TabIndex = 1;
            this.UrunListele.Text = "SADECE SATILAN ÜRÜNLERİ LİSTELE";
            this.UrunListele.UseVisualStyleBackColor = true;
            this.UrunListele.Click += new System.EventHandler(this.UrunListele_Click);
            // 
            // main
            // 
            this.main.Location = new System.Drawing.Point(385, 158);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(94, 29);
            this.main.TabIndex = 2;
            this.main.Text = "GERİ";
            this.main.UseVisualStyleBackColor = true;
            this.main.Click += new System.EventHandler(this.main_Click);
            // 
            // urunSil
            // 
            this.urunSil.Location = new System.Drawing.Point(211, 103);
            this.urunSil.Name = "urunSil";
            this.urunSil.Size = new System.Drawing.Size(94, 29);
            this.urunSil.TabIndex = 3;
            this.urunSil.Text = "ÜRÜN SİL";
            this.urunSil.UseVisualStyleBackColor = true;
            this.urunSil.Click += new System.EventHandler(this.urunSil_Click);
            // 
            // urunEkle
            // 
            this.urunEkle.Location = new System.Drawing.Point(53, 103);
            this.urunEkle.Name = "urunEkle";
            this.urunEkle.Size = new System.Drawing.Size(94, 29);
            this.urunEkle.TabIndex = 4;
            this.urunEkle.Text = "ÜRÜN EKLE";
            this.urunEkle.UseVisualStyleBackColor = true;
            this.urunEkle.Click += new System.EventHandler(this.urunEkle_Click);
            // 
            // urunGuncelle
            // 
            this.urunGuncelle.Location = new System.Drawing.Point(385, 103);
            this.urunGuncelle.Name = "urunGuncelle";
            this.urunGuncelle.Size = new System.Drawing.Size(94, 29);
            this.urunGuncelle.TabIndex = 5;
            this.urunGuncelle.Text = "GÜNCELLE";
            this.urunGuncelle.UseVisualStyleBackColor = true;
            this.urunGuncelle.Click += new System.EventHandler(this.urunGuncelle_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(295, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "ÜRÜNLERİ LİSTELE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.urunGuncelle);
            this.Controls.Add(this.urunEkle);
            this.Controls.Add(this.urunSil);
            this.Controls.Add(this.main);
            this.Controls.Add(this.UrunListele);
            this.Controls.Add(this.DtUrunListele);
            this.Name = "Urunler";
            this.Text = "Urunler";
            this.Load += new System.EventHandler(this.Urunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtUrunListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView DtUrunListele;
        private Button UrunListele;
        private Button main;
        private Button urunSil;
        private Button urunEkle;
        private Button urunGuncelle;
        private Button button1;
    }
}