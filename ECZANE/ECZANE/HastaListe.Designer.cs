namespace ECZANE
{
    partial class HastaListe
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
            this.HastaListeGrid = new System.Windows.Forms.DataGridView();
            this.HastaListeKomutPaneli = new System.Windows.Forms.Panel();
            this.HastaSil = new System.Windows.Forms.Button();
            this.HastaGuncelle = new System.Windows.Forms.Button();
            this.YeniHastaKayit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.HastaListeGrid)).BeginInit();
            this.HastaListeKomutPaneli.SuspendLayout();
            this.SuspendLayout();
            // 
            // HastaListeGrid
            // 
            this.HastaListeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HastaListeGrid.Dock = System.Windows.Forms.DockStyle.Top;
            this.HastaListeGrid.Location = new System.Drawing.Point(0, 0);
            this.HastaListeGrid.Name = "HastaListeGrid";
            this.HastaListeGrid.Size = new System.Drawing.Size(734, 400);
            this.HastaListeGrid.TabIndex = 0;
            // 
            // HastaListeKomutPaneli
            // 
            this.HastaListeKomutPaneli.Controls.Add(this.HastaSil);
            this.HastaListeKomutPaneli.Controls.Add(this.HastaGuncelle);
            this.HastaListeKomutPaneli.Controls.Add(this.YeniHastaKayit);
            this.HastaListeKomutPaneli.Location = new System.Drawing.Point(0, 406);
            this.HastaListeKomutPaneli.Name = "HastaListeKomutPaneli";
            this.HastaListeKomutPaneli.Size = new System.Drawing.Size(744, 45);
            this.HastaListeKomutPaneli.TabIndex = 1;
            // 
            // HastaSil
            // 
            this.HastaSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.HastaSil.Location = new System.Drawing.Point(200, 0);
            this.HastaSil.Name = "HastaSil";
            this.HastaSil.Size = new System.Drawing.Size(80, 45);
            this.HastaSil.TabIndex = 2;
            this.HastaSil.Text = "Sil";
            this.HastaSil.UseVisualStyleBackColor = true;
            this.HastaSil.Click += new System.EventHandler(this.HastaSil_Click);
            // 
            // HastaGuncelle
            // 
            this.HastaGuncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.HastaGuncelle.Location = new System.Drawing.Point(120, 0);
            this.HastaGuncelle.Name = "HastaGuncelle";
            this.HastaGuncelle.Size = new System.Drawing.Size(80, 45);
            this.HastaGuncelle.TabIndex = 1;
            this.HastaGuncelle.Text = "Degistir";
            this.HastaGuncelle.UseVisualStyleBackColor = true;
            this.HastaGuncelle.Click += new System.EventHandler(this.HastaGuncelle_Click);
            // 
            // YeniHastaKayit
            // 
            this.YeniHastaKayit.Dock = System.Windows.Forms.DockStyle.Left;
            this.YeniHastaKayit.Location = new System.Drawing.Point(0, 0);
            this.YeniHastaKayit.Name = "YeniHastaKayit";
            this.YeniHastaKayit.Size = new System.Drawing.Size(120, 45);
            this.YeniHastaKayit.TabIndex = 0;
            this.YeniHastaKayit.Text = "Hasta Ekle";
            this.YeniHastaKayit.UseVisualStyleBackColor = true;
            this.YeniHastaKayit.Click += new System.EventHandler(this.YeniHastaKayit_Click);
            // 
            // HastaListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.HastaListeKomutPaneli);
            this.Controls.Add(this.HastaListeGrid);
            this.Name = "HastaListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.HastaListeGrid)).EndInit();
            this.HastaListeKomutPaneli.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView HastaListeGrid;
        private System.Windows.Forms.Panel HastaListeKomutPaneli;
        private System.Windows.Forms.Button HastaSil;
        private System.Windows.Forms.Button HastaGuncelle;
        private System.Windows.Forms.Button YeniHastaKayit;
    }
}