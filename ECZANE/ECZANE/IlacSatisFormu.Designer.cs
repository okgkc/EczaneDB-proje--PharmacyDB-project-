namespace ECZANE
{
    partial class IlacSatisFormu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IlacSatisGrid = new System.Windows.Forms.DataGridView();
            this.TC_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Satis_Tarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odenecek_Tutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatisKaydet = new System.Windows.Forms.Button();
            this.SatisIptal = new System.Windows.Forms.Button();
            this.nudTCNo = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.IlacSatisGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTCNo)).BeginInit();
            this.SuspendLayout();
            // 
            // IlacSatisGrid
            // 
            this.IlacSatisGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.Column;
            this.IlacSatisGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IlacSatisGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TC_No,
            this.Barkod,
            this.Satis_Tarihi,
            this.Miktar,
            this.Odenecek_Tutar});
            this.IlacSatisGrid.Location = new System.Drawing.Point(1, 0);
            this.IlacSatisGrid.Name = "IlacSatisGrid";
            this.IlacSatisGrid.Size = new System.Drawing.Size(692, 190);
            this.IlacSatisGrid.TabIndex = 1;
            // 
            // TC_No
            // 
            this.TC_No.DataPropertyName = "TC_No";
            this.TC_No.HeaderText = "TC Kimlik No";
            this.TC_No.Name = "TC_No";
            // 
            // Barkod
            // 
            this.Barkod.DataPropertyName = "Barkod";
            this.Barkod.HeaderText = "İlaç";
            this.Barkod.Name = "Barkod";
            // 
            // Satis_Tarihi
            // 
            this.Satis_Tarihi.DataPropertyName = "Satis_Tarihi";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.Satis_Tarihi.DefaultCellStyle = dataGridViewCellStyle1;
            this.Satis_Tarihi.HeaderText = "Satış Tarihi";
            this.Satis_Tarihi.Name = "Satis_Tarihi";
            // 
            // Miktar
            // 
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            // 
            // Odenecek_Tutar
            // 
            this.Odenecek_Tutar.DataPropertyName = "Odenecek_Tutar";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Odenecek_Tutar.DefaultCellStyle = dataGridViewCellStyle2;
            this.Odenecek_Tutar.HeaderText = "Tutar";
            this.Odenecek_Tutar.Name = "Odenecek_Tutar";
            // 
            // SatisKaydet
            // 
            this.SatisKaydet.Location = new System.Drawing.Point(455, 228);
            this.SatisKaydet.Name = "SatisKaydet";
            this.SatisKaydet.Size = new System.Drawing.Size(80, 45);
            this.SatisKaydet.TabIndex = 4;
            this.SatisKaydet.Text = "Kaydet";
            this.SatisKaydet.UseVisualStyleBackColor = true;
            this.SatisKaydet.Click += new System.EventHandler(this.SatisKaydet_Click);
            // 
            // SatisIptal
            // 
            this.SatisIptal.Location = new System.Drawing.Point(542, 228);
            this.SatisIptal.Name = "SatisIptal";
            this.SatisIptal.Size = new System.Drawing.Size(80, 45);
            this.SatisIptal.TabIndex = 5;
            this.SatisIptal.Text = "İptal";
            this.SatisIptal.UseVisualStyleBackColor = true;
            this.SatisIptal.Click += new System.EventHandler(this.SatisIptal_Click);
            // 
            // nudTCNo
            // 
            this.nudTCNo.Location = new System.Drawing.Point(12, 362);
            this.nudTCNo.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudTCNo.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudTCNo.Name = "nudTCNo";
            this.nudTCNo.Size = new System.Drawing.Size(120, 20);
            this.nudTCNo.TabIndex = 8;
            this.nudTCNo.Value = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudTCNo.Visible = false;
            // 
            // IlacSatisFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 281);
            this.Controls.Add(this.nudTCNo);
            this.Controls.Add(this.SatisIptal);
            this.Controls.Add(this.SatisKaydet);
            this.Controls.Add(this.IlacSatisGrid);
            this.Name = "IlacSatisFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İlaç Satış Formu";
            ((System.ComponentModel.ISupportInitialize)(this.IlacSatisGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTCNo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView IlacSatisGrid;
        private System.Windows.Forms.Button SatisKaydet;
        private System.Windows.Forms.Button SatisIptal;
        private System.Windows.Forms.NumericUpDown nudTCNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TC_No;
        private System.Windows.Forms.DataGridViewComboBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Satis_Tarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odenecek_Tutar;
    }
}