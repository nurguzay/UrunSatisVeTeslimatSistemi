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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DtUrunListele)).BeginInit();
            this.SuspendLayout();
            // 
            // DtUrunListele
            // 
            this.DtUrunListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtUrunListele.Location = new System.Drawing.Point(41, 168);
            this.DtUrunListele.Name = "DtUrunListele";
            this.DtUrunListele.ReadOnly = true;
            this.DtUrunListele.RowHeadersWidth = 51;
            this.DtUrunListele.RowTemplate.Height = 29;
            this.DtUrunListele.Size = new System.Drawing.Size(451, 224);
            this.DtUrunListele.TabIndex = 0;
            // 
            // UrunListele
            // 
            this.UrunListele.Location = new System.Drawing.Point(53, 39);
            this.UrunListele.Name = "UrunListele";
            this.UrunListele.Size = new System.Drawing.Size(160, 29);
            this.UrunListele.TabIndex = 1;
            this.UrunListele.Text = "Ürünleri Listele";
            this.UrunListele.UseVisualStyleBackColor = true;
            this.UrunListele.Click += new System.EventHandler(this.UrunListele_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(309, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ana Sayfaya Dön";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 101);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kayıt sil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Urunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 429);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
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
        private Button button2;
        private Button button1;
    }
}