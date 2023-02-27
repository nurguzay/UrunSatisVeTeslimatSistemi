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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UrunGuncelle));
            this.dtUrunGuncelle = new System.Windows.Forms.DataGridView();
            this.guncelle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtUrunGuncelle)).BeginInit();
            this.SuspendLayout();
            // 
            // dtUrunGuncelle
            // 
            this.dtUrunGuncelle.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtUrunGuncelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtUrunGuncelle.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dtUrunGuncelle.Location = new System.Drawing.Point(15, 95);
            this.dtUrunGuncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtUrunGuncelle.Name = "dtUrunGuncelle";
            this.dtUrunGuncelle.RowHeadersWidth = 51;
            this.dtUrunGuncelle.RowTemplate.Height = 29;
            this.dtUrunGuncelle.Size = new System.Drawing.Size(970, 387);
            this.dtUrunGuncelle.TabIndex = 0;
            // 
            // guncelle
            // 
            this.guncelle.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guncelle.Location = new System.Drawing.Point(224, 56);
            this.guncelle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(214, 32);
            this.guncelle.TabIndex = 1;
            this.guncelle.Text = "GÜNCELLE";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(551, 56);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UrunGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(1000, 495);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.dtUrunGuncelle);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UrunGuncelle";
            this.Text = "Urun Guncelle";
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