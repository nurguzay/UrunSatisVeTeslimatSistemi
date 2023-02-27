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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusteriGiris));
            this.musList = new System.Windows.Forms.Button();
            this.musKayit = new System.Windows.Forms.Button();
            this.MusteriListele = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListele)).BeginInit();
            this.SuspendLayout();
            // 
            // musList
            // 
            this.musList.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musList.Location = new System.Drawing.Point(298, 55);
            this.musList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.musList.Name = "musList";
            this.musList.Size = new System.Drawing.Size(250, 32);
            this.musList.TabIndex = 1;
            this.musList.Text = "LİSTELE";
            this.musList.UseVisualStyleBackColor = true;
            this.musList.Click += new System.EventHandler(this.musList_Click);
            // 
            // musKayit
            // 
            this.musKayit.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musKayit.Location = new System.Drawing.Point(15, 55);
            this.musKayit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.musKayit.Name = "musKayit";
            this.musKayit.Size = new System.Drawing.Size(250, 32);
            this.musKayit.TabIndex = 2;
            this.musKayit.Text = "KAYIT";
            this.musKayit.UseVisualStyleBackColor = true;
            this.musKayit.Click += new System.EventHandler(this.musKayit_Click);
            // 
            // MusteriListele
            // 
            this.MusteriListele.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MusteriListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusteriListele.Location = new System.Drawing.Point(15, 110);
            this.MusteriListele.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MusteriListele.Name = "MusteriListele";
            this.MusteriListele.RowHeadersWidth = 51;
            this.MusteriListele.RowTemplate.Height = 29;
            this.MusteriListele.Size = new System.Drawing.Size(810, 358);
            this.MusteriListele.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(575, 55);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "GERİ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MusteriGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(840, 481);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MusteriListele);
            this.Controls.Add(this.musKayit);
            this.Controls.Add(this.musList);
            this.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MusteriGiris";
            this.Text = "Müsteri Giris";
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListele)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button musList;
        private Button musKayit;
        private DataGridView MusteriListele;
        private Button button1;
    }
}