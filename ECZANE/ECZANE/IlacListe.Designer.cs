namespace ECZANE
{
    partial class IlacListe
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
            this.IlacListeGrid = new System.Windows.Forms.DataGridView();
            this.yeniIlacEkle = new System.Windows.Forms.Button();
            this.IlacGuncelle = new System.Windows.Forms.Button();
            this.IlacSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.IlacListeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // IlacListeGrid
            // 
            this.IlacListeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IlacListeGrid.Location = new System.Drawing.Point(-1, 0);
            this.IlacListeGrid.Name = "IlacListeGrid";
            this.IlacListeGrid.Size = new System.Drawing.Size(734, 400);
            this.IlacListeGrid.TabIndex = 0;
            // 
            // yeniIlacEkle
            // 
            this.yeniIlacEkle.Location = new System.Drawing.Point(-1, 407);
            this.yeniIlacEkle.Name = "yeniIlacEkle";
            this.yeniIlacEkle.Size = new System.Drawing.Size(120, 45);
            this.yeniIlacEkle.TabIndex = 1;
            this.yeniIlacEkle.Text = "İlaç Ekle";
            this.yeniIlacEkle.UseVisualStyleBackColor = true;
            this.yeniIlacEkle.Click += new System.EventHandler(this.yeniIlacEkle_Click);
            // 
            // IlacGuncelle
            // 
            this.IlacGuncelle.Location = new System.Drawing.Point(125, 407);
            this.IlacGuncelle.Name = "IlacGuncelle";
            this.IlacGuncelle.Size = new System.Drawing.Size(80, 45);
            this.IlacGuncelle.TabIndex = 2;
            this.IlacGuncelle.Text = "Değiştir";
            this.IlacGuncelle.UseVisualStyleBackColor = true;
            this.IlacGuncelle.Click += new System.EventHandler(this.IlacGuncelle_Click);
            // 
            // IlacSil
            // 
            this.IlacSil.Location = new System.Drawing.Point(211, 407);
            this.IlacSil.Name = "IlacSil";
            this.IlacSil.Size = new System.Drawing.Size(80, 45);
            this.IlacSil.TabIndex = 3;
            this.IlacSil.Text = "Sil";
            this.IlacSil.UseVisualStyleBackColor = true;
            this.IlacSil.Click += new System.EventHandler(this.IlacSil_Click);
            // 
            // IlacListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.IlacSil);
            this.Controls.Add(this.IlacGuncelle);
            this.Controls.Add(this.yeniIlacEkle);
            this.Controls.Add(this.IlacListeGrid);
            this.Name = "IlacListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlaç Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.IlacListeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView IlacListeGrid;
        private System.Windows.Forms.Button yeniIlacEkle;
        private System.Windows.Forms.Button IlacGuncelle;
        private System.Windows.Forms.Button IlacSil;
    }
}