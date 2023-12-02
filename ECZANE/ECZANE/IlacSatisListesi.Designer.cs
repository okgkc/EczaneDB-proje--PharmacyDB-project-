namespace ECZANE
{
    partial class IlacSatisListesi
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
            this.IlacSatisGrid = new System.Windows.Forms.DataGridView();
            this.IlacSatisEkle = new System.Windows.Forms.Button();
            this.IlacSatisGuncelle = new System.Windows.Forms.Button();
            this.IlacSatisSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IlacSatisGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IlacSatisGrid
            // 
            this.IlacSatisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IlacSatisGrid.Location = new System.Drawing.Point(1, -1);
            this.IlacSatisGrid.Name = "IlacSatisGrid";
            this.IlacSatisGrid.Size = new System.Drawing.Size(734, 400);
            this.IlacSatisGrid.TabIndex = 0;
            // 
            // IlacSatisEkle
            // 
            this.IlacSatisEkle.Location = new System.Drawing.Point(1, 405);
            this.IlacSatisEkle.Name = "IlacSatisEkle";
            this.IlacSatisEkle.Size = new System.Drawing.Size(120, 45);
            this.IlacSatisEkle.TabIndex = 1;
            this.IlacSatisEkle.Text = "Satış Ekle";
            this.IlacSatisEkle.UseVisualStyleBackColor = true;
            this.IlacSatisEkle.Click += new System.EventHandler(this.IlacSatisEkle_Click);
            // 
            // IlacSatisGuncelle
            // 
            this.IlacSatisGuncelle.Location = new System.Drawing.Point(127, 406);
            this.IlacSatisGuncelle.Name = "IlacSatisGuncelle";
            this.IlacSatisGuncelle.Size = new System.Drawing.Size(120, 45);
            this.IlacSatisGuncelle.TabIndex = 2;
            this.IlacSatisGuncelle.Text = "Güncelle";
            this.IlacSatisGuncelle.UseVisualStyleBackColor = true;
            this.IlacSatisGuncelle.Click += new System.EventHandler(this.IlacSatisGuncelle_Click);
            // 
            // IlacSatisSil
            // 
            this.IlacSatisSil.Location = new System.Drawing.Point(253, 407);
            this.IlacSatisSil.Name = "IlacSatisSil";
            this.IlacSatisSil.Size = new System.Drawing.Size(80, 45);
            this.IlacSatisSil.TabIndex = 3;
            this.IlacSatisSil.Text = "Sil";
            this.IlacSatisSil.UseVisualStyleBackColor = true;
            this.IlacSatisSil.Click += new System.EventHandler(this.IlacSatisSil_Click);
            // 
            // IlacSatisListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.IlacSatisSil);
            this.Controls.Add(this.IlacSatisGuncelle);
            this.Controls.Add(this.IlacSatisEkle);
            this.Controls.Add(this.IlacSatisGrid);
            this.Name = "IlacSatisListesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlaç Satış Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.IlacSatisGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView IlacSatisGrid;
        private System.Windows.Forms.Button IlacSatisEkle;
        private System.Windows.Forms.Button IlacSatisGuncelle;
        private System.Windows.Forms.Button IlacSatisSil;
    }
}