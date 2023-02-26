namespace proje
{
    partial class MusteriGiris
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MusteriListele = new System.Windows.Forms.DataGridView();
            this.UrunListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListele)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Müşteri Listele";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Müsteri Kayıt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MusteriListele
            // 
            this.MusteriListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusteriListele.Location = new System.Drawing.Point(12, 162);
            this.MusteriListele.Name = "MusteriListele";
            this.MusteriListele.RowHeadersWidth = 51;
            this.MusteriListele.RowTemplate.Height = 29;
            this.MusteriListele.Size = new System.Drawing.Size(399, 263);
            this.MusteriListele.TabIndex = 3;
            // 
            // UrunListele
            // 
            this.UrunListele.Location = new System.Drawing.Point(232, 12);
            this.UrunListele.Name = "UrunListele";
            this.UrunListele.Size = new System.Drawing.Size(179, 29);
            this.UrunListele.TabIndex = 4;
            this.UrunListele.Text = "Ürün Listele";
            this.UrunListele.UseVisualStyleBackColor = true;
            this.UrunListele.Click += new System.EventHandler(this.UrunListele_Click);
            // 
            // MusteriGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 437);
            this.Controls.Add(this.UrunListele);
            this.Controls.Add(this.MusteriListele);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "MusteriGiris";
            this.Text = "Müsteri Giris";
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private DataGridView MusteriListele;
        private Button UrunListele;
    }
}