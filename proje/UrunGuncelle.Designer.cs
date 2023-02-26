namespace proje
{
    partial class UrunGuncelle
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
            this.dtUrunGuncelle = new System.Windows.Forms.DataGridView();
            this.guncelle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtUrunGuncelle)).BeginInit();
            this.SuspendLayout();
            // 
            // dtUrunGuncelle
            // 
            this.dtUrunGuncelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUrunGuncelle.Location = new System.Drawing.Point(12, 12);
            this.dtUrunGuncelle.Name = "dtUrunGuncelle";
            this.dtUrunGuncelle.RowHeadersWidth = 51;
            this.dtUrunGuncelle.RowTemplate.Height = 29;
            this.dtUrunGuncelle.Size = new System.Drawing.Size(776, 352);
            this.dtUrunGuncelle.TabIndex = 0;
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(310, 390);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(94, 29);
            this.guncelle.TabIndex = 1;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(572, 390);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UrunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.dtUrunGuncelle);
            this.Name = "UrunGuncelle";
            this.Text = "UrunGuncelle";
            this.Load += new System.EventHandler(this.UrunGuncelle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtUrunGuncelle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dtUrunGuncelle;
        private Button guncelle;
        private Button button2;
    }
}