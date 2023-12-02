namespace ECZANE
{
    partial class HastaFormu
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefonNo = new System.Windows.Forms.TextBox();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbxCinsiyet = new System.Windows.Forms.ComboBox();
            this.cbxSGK = new System.Windows.Forms.ComboBox();
            this.nudTCNo = new System.Windows.Forms.NumericUpDown();
            this.KayitIptal = new System.Windows.Forms.Button();
            this.HastaKaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudTCNo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC Kimlik No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "SGK";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(39, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Telefon No";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(104, 55);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(154, 20);
            this.txtAdSoyad.TabIndex = 7;
            // 
            // txtTelefonNo
            // 
            this.txtTelefonNo.Location = new System.Drawing.Point(105, 141);
            this.txtTelefonNo.Name = "txtTelefonNo";
            this.txtTelefonNo.Size = new System.Drawing.Size(161, 20);
            this.txtTelefonNo.TabIndex = 8;
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.CustomFormat = "dd.MM.yyyy";
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(408, 15);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(148, 20);
            this.dtpDogumTarihi.TabIndex = 9;
            // 
            // cbxCinsiyet
            // 
            this.cbxCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCinsiyet.FormattingEnabled = true;
            this.cbxCinsiyet.Location = new System.Drawing.Point(105, 96);
            this.cbxCinsiyet.Name = "cbxCinsiyet";
            this.cbxCinsiyet.Size = new System.Drawing.Size(100, 21);
            this.cbxCinsiyet.TabIndex = 10;
            // 
            // cbxSGK
            // 
            this.cbxSGK.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSGK.FormattingEnabled = true;
            this.cbxSGK.Location = new System.Drawing.Point(408, 54);
            this.cbxSGK.Name = "cbxSGK";
            this.cbxSGK.Size = new System.Drawing.Size(121, 21);
            this.cbxSGK.TabIndex = 11;
            // 
            // nudTCNo
            // 
            this.nudTCNo.Location = new System.Drawing.Point(105, 14);
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
            this.nudTCNo.TabIndex = 15;
            this.nudTCNo.Value = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            // 
            // KayitIptal
            // 
            this.KayitIptal.Location = new System.Drawing.Point(500, 179);
            this.KayitIptal.Name = "KayitIptal";
            this.KayitIptal.Size = new System.Drawing.Size(80, 45);
            this.KayitIptal.TabIndex = 13;
            this.KayitIptal.Text = "İptal";
            this.KayitIptal.UseVisualStyleBackColor = true;
            this.KayitIptal.Click += new System.EventHandler(this.KayitIptal_Click);
            // 
            // HastaKaydet
            // 
            this.HastaKaydet.Location = new System.Drawing.Point(414, 179);
            this.HastaKaydet.Name = "HastaKaydet";
            this.HastaKaydet.Size = new System.Drawing.Size(80, 45);
            this.HastaKaydet.TabIndex = 12;
            this.HastaKaydet.Text = "Kaydet";
            this.HastaKaydet.UseVisualStyleBackColor = true;
            this.HastaKaydet.Click += new System.EventHandler(this.HastaKaydet_Click);
            // 
            // HastaFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 236);
            this.Controls.Add(this.KayitIptal);
            this.Controls.Add(this.HastaKaydet);
            this.Controls.Add(this.nudTCNo);
            this.Controls.Add(this.cbxSGK);
            this.Controls.Add(this.cbxCinsiyet);
            this.Controls.Add(this.dtpDogumTarihi);
            this.Controls.Add(this.txtTelefonNo);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "HastaFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Formu";
            ((System.ComponentModel.ISupportInitialize)(this.nudTCNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefonNo;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.ComboBox cbxCinsiyet;
        private System.Windows.Forms.ComboBox cbxSGK;
        private System.Windows.Forms.NumericUpDown nudTCNo;
        private System.Windows.Forms.Button KayitIptal;
        private System.Windows.Forms.Button HastaKaydet;
    }
}