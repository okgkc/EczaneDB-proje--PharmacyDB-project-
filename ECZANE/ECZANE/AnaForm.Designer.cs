namespace ECZANE
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            this.HastaListesiGetir = new System.Windows.Forms.Button();
            this.IlacListesiGetir = new System.Windows.Forms.Button();
            this.Recete = new System.Windows.Forms.Button();
            this.IlacSatıs = new System.Windows.Forms.Button();
            this.kayitGroupBox = new System.Windows.Forms.GroupBox();
            this.BalEczanesi = new System.Windows.Forms.Label();
            this.kayitGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // HastaListesiGetir
            // 
            this.HastaListesiGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.HastaListesiGetir.Location = new System.Drawing.Point(40, 65);
            this.HastaListesiGetir.Name = "HastaListesiGetir";
            this.HastaListesiGetir.Size = new System.Drawing.Size(145, 68);
            this.HastaListesiGetir.TabIndex = 0;
            this.HastaListesiGetir.Text = "Hasta Liste";
            this.HastaListesiGetir.UseVisualStyleBackColor = false;
            this.HastaListesiGetir.Click += new System.EventHandler(this.HastaListesiGetir_Click);
            // 
            // IlacListesiGetir
            // 
            this.IlacListesiGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IlacListesiGetir.Location = new System.Drawing.Point(225, 65);
            this.IlacListesiGetir.Name = "IlacListesiGetir";
            this.IlacListesiGetir.Size = new System.Drawing.Size(145, 66);
            this.IlacListesiGetir.TabIndex = 1;
            this.IlacListesiGetir.Text = "İlaç Liste";
            this.IlacListesiGetir.UseVisualStyleBackColor = false;
            this.IlacListesiGetir.Click += new System.EventHandler(this.IlacListesiGetir_Click);
            // 
            // Recete
            // 
            this.Recete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Recete.Location = new System.Drawing.Point(416, 64);
            this.Recete.Name = "Recete";
            this.Recete.Size = new System.Drawing.Size(144, 67);
            this.Recete.TabIndex = 2;
            this.Recete.Text = "Reçete Liste";
            this.Recete.UseVisualStyleBackColor = false;
            this.Recete.Click += new System.EventHandler(this.Recete_Click);
            // 
            // IlacSatıs
            // 
            this.IlacSatıs.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.IlacSatıs.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IlacSatıs.Location = new System.Drawing.Point(123, 253);
            this.IlacSatıs.Name = "IlacSatıs";
            this.IlacSatıs.Size = new System.Drawing.Size(443, 74);
            this.IlacSatıs.TabIndex = 3;
            this.IlacSatıs.Text = "İlaç Satış";
            this.IlacSatıs.UseVisualStyleBackColor = false;
            this.IlacSatıs.Click += new System.EventHandler(this.IlacSatıs_Click);
            // 
            // kayitGroupBox
            // 
            this.kayitGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.kayitGroupBox.Controls.Add(this.HastaListesiGetir);
            this.kayitGroupBox.Controls.Add(this.IlacListesiGetir);
            this.kayitGroupBox.Controls.Add(this.Recete);
            this.kayitGroupBox.Font = new System.Drawing.Font("Microsoft Himalaya", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayitGroupBox.Location = new System.Drawing.Point(44, 345);
            this.kayitGroupBox.Name = "kayitGroupBox";
            this.kayitGroupBox.Size = new System.Drawing.Size(628, 154);
            this.kayitGroupBox.TabIndex = 10;
            this.kayitGroupBox.TabStop = false;
            this.kayitGroupBox.Text = "KAYITLAR";
            // 
            // BalEczanesi
            // 
            this.BalEczanesi.AutoSize = true;
            this.BalEczanesi.BackColor = System.Drawing.Color.White;
            this.BalEczanesi.Font = new System.Drawing.Font("Segoe Print", 44.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BalEczanesi.Location = new System.Drawing.Point(77, 9);
            this.BalEczanesi.Name = "BalEczanesi";
            this.BalEczanesi.Size = new System.Drawing.Size(513, 104);
            this.BalEczanesi.TabIndex = 5;
            this.BalEczanesi.Text = "BAL ECZANESİ";
            this.BalEczanesi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.BalEczanesi);
            this.Controls.Add(this.kayitGroupBox);
            this.Controls.Add(this.IlacSatıs);
            this.Name = "AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bal Eczanesi Bilgi Sistemi";
            this.kayitGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button HastaListesiGetir;
        private System.Windows.Forms.Button IlacListesiGetir;
        private System.Windows.Forms.Button Recete;
        private System.Windows.Forms.Button IlacSatıs;
        private System.Windows.Forms.GroupBox kayitGroupBox;
        private System.Windows.Forms.Label BalEczanesi;
    }
}

