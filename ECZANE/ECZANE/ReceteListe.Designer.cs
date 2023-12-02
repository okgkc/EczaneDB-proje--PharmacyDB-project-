namespace ECZANE
{
    partial class ReceteListe
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
            this.ReceteListeGrid = new System.Windows.Forms.DataGridView();
            this.ReceteEkle = new System.Windows.Forms.Button();
            this.ReceteGuncelle = new System.Windows.Forms.Button();
            this.ReceteSil = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ReceteListeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ReceteListeGrid
            // 
            this.ReceteListeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceteListeGrid.Location = new System.Drawing.Point(-1, 1);
            this.ReceteListeGrid.Name = "ReceteListeGrid";
            this.ReceteListeGrid.Size = new System.Drawing.Size(734, 400);
            this.ReceteListeGrid.TabIndex = 0;
            // 
            // ReceteEkle
            // 
            this.ReceteEkle.Location = new System.Drawing.Point(-1, 407);
            this.ReceteEkle.Name = "ReceteEkle";
            this.ReceteEkle.Size = new System.Drawing.Size(120, 45);
            this.ReceteEkle.TabIndex = 1;
            this.ReceteEkle.Text = "ReceteEkle";
            this.ReceteEkle.UseVisualStyleBackColor = true;
            this.ReceteEkle.Click += new System.EventHandler(this.ReceteEkle_Click);
            // 
            // ReceteGuncelle
            // 
            this.ReceteGuncelle.Location = new System.Drawing.Point(125, 407);
            this.ReceteGuncelle.Name = "ReceteGuncelle";
            this.ReceteGuncelle.Size = new System.Drawing.Size(120, 45);
            this.ReceteGuncelle.TabIndex = 2;
            this.ReceteGuncelle.Text = "Değiştir";
            this.ReceteGuncelle.UseVisualStyleBackColor = true;
            this.ReceteGuncelle.Click += new System.EventHandler(this.ReceteGuncelle_Click);
            // 
            // ReceteSil
            // 
            this.ReceteSil.Location = new System.Drawing.Point(254, 408);
            this.ReceteSil.Name = "ReceteSil";
            this.ReceteSil.Size = new System.Drawing.Size(80, 45);
            this.ReceteSil.TabIndex = 3;
            this.ReceteSil.Text = "Sil";
            this.ReceteSil.UseVisualStyleBackColor = true;
            this.ReceteSil.Click += new System.EventHandler(this.ReceteSil_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(561, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ReceteListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ReceteSil);
            this.Controls.Add(this.ReceteGuncelle);
            this.Controls.Add(this.ReceteEkle);
            this.Controls.Add(this.ReceteListeGrid);
            this.Name = "ReceteListe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reçete Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.ReceteListeGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ReceteListeGrid;
        private System.Windows.Forms.Button ReceteEkle;
        private System.Windows.Forms.Button ReceteGuncelle;
        private System.Windows.Forms.Button ReceteSil;
        private System.Windows.Forms.Button button1;
    }
}