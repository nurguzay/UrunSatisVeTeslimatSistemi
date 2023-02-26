namespace proje
{
    partial class UrunKayit
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrise = new System.Windows.Forms.TextBox();
            this.txtUName = new System.Windows.Forms.TextBox();
            this.urunEkle = new System.Windows.Forms.Button();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.satildi = new System.Windows.Forms.RadioButton();
            this.satilmadi = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.urunAdet = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "ÜRÜN FİYATI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "ÜRÜN AÇIKLAMASI";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "ÜRÜN ADI";
            // 
            // txtPrise
            // 
            this.txtPrise.Location = new System.Drawing.Point(178, 158);
            this.txtPrise.Name = "txtPrise";
            this.txtPrise.Size = new System.Drawing.Size(125, 27);
            this.txtPrise.TabIndex = 14;
            // 
            // txtUName
            // 
            this.txtUName.Location = new System.Drawing.Point(178, 47);
            this.txtUName.Name = "txtUName";
            this.txtUName.Size = new System.Drawing.Size(125, 27);
            this.txtUName.TabIndex = 13;
            // 
            // urunEkle
            // 
            this.urunEkle.Location = new System.Drawing.Point(130, 398);
            this.urunEkle.Name = "urunEkle";
            this.urunEkle.Size = new System.Drawing.Size(94, 29);
            this.urunEkle.TabIndex = 12;
            this.urunEkle.Text = "KAYDET";
            this.urunEkle.UseVisualStyleBackColor = true;
            this.urunEkle.Click += new System.EventHandler(this.urunEkle_Click);
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(178, 101);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(125, 27);
            this.txtDesc.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 20;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // satildi
            // 
            this.satildi.AutoSize = true;
            this.satildi.Location = new System.Drawing.Point(15, 46);
            this.satildi.Name = "satildi";
            this.satildi.Size = new System.Drawing.Size(81, 24);
            this.satildi.TabIndex = 21;
            this.satildi.TabStop = true;
            this.satildi.Text = "SATILDI";
            this.satildi.UseVisualStyleBackColor = true;
            // 
            // satilmadi
            // 
            this.satilmadi.AutoSize = true;
            this.satilmadi.Location = new System.Drawing.Point(196, 46);
            this.satilmadi.Name = "satilmadi";
            this.satilmadi.Size = new System.Drawing.Size(104, 24);
            this.satilmadi.TabIndex = 22;
            this.satilmadi.TabStop = true;
            this.satilmadi.Text = "SATILMADI";
            this.satilmadi.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 24;
            this.label4.Text = "ÜRÜN ADETİ";
            // 
            // urunAdet
            // 
            this.urunAdet.Location = new System.Drawing.Point(178, 214);
            this.urunAdet.Name = "urunAdet";
            this.urunAdet.Size = new System.Drawing.Size(125, 27);
            this.urunAdet.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.satildi);
            this.panel1.Controls.Add(this.satilmadi);
            this.panel1.Location = new System.Drawing.Point(21, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 125);
            this.panel1.TabIndex = 25;
            // 
            // UrunKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.urunAdet);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrise);
            this.Controls.Add(this.txtUName);
            this.Controls.Add(this.urunEkle);
            this.Name = "UrunKayit";
            this.Text = "UrunKayit";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPrise;
        private TextBox txtUName;
        private Button urunEkle;
        private TextBox txtDesc;
        private Button button1;
        private RadioButton satildi;
        private RadioButton satilmadi;
        private Label label4;
        private TextBox urunAdet;
        private Panel panel1;
    }
}