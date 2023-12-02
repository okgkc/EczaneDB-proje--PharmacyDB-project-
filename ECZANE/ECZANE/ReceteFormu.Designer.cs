namespace ECZANE
{
    partial class ReceteFormu
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
            this.Hasta = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ReceteKaydet = new System.Windows.Forms.Button();
            this.Iptal = new System.Windows.Forms.Button();
            this.nudHastaTcNo = new System.Windows.Forms.NumericUpDown();
            this.cbxReceteTipi = new System.Windows.Forms.ComboBox();
            this.dtpReceteTarihi = new System.Windows.Forms.DateTimePicker();
            this.ReceteILacGrid = new System.Windows.Forms.DataGridView();
            this.Protokol_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kullanim_Periyot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kullanim_Doz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudPNO = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nudHastaTcNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceteILacGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPNO)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hasta
            // 
            this.Hasta.AutoSize = true;
            this.Hasta.Location = new System.Drawing.Point(61, 17);
            this.Hasta.Name = "Hasta";
            this.Hasta.Size = new System.Drawing.Size(35, 13);
            this.Hasta.TabIndex = 1;
            this.Hasta.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Reçete Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Reçete Tipi";
            // 
            // ReceteKaydet
            // 
            this.ReceteKaydet.Location = new System.Drawing.Point(461, 3);
            this.ReceteKaydet.Name = "ReceteKaydet";
            this.ReceteKaydet.Size = new System.Drawing.Size(80, 45);
            this.ReceteKaydet.TabIndex = 5;
            this.ReceteKaydet.Text = "Kaydet";
            this.ReceteKaydet.UseVisualStyleBackColor = true;
            this.ReceteKaydet.Click += new System.EventHandler(this.ReceteKaydet_Click_1);
            // 
            // Iptal
            // 
            this.Iptal.Location = new System.Drawing.Point(547, 3);
            this.Iptal.Name = "Iptal";
            this.Iptal.Size = new System.Drawing.Size(80, 45);
            this.Iptal.TabIndex = 6;
            this.Iptal.Text = "Iptal";
            this.Iptal.UseVisualStyleBackColor = true;
            this.Iptal.Click += new System.EventHandler(this.Iptal_Click);
            // 
            // nudHastaTcNo
            // 
            this.nudHastaTcNo.Location = new System.Drawing.Point(110, 12);
            this.nudHastaTcNo.Maximum = new decimal(new int[] {
            1215752191,
            23,
            0,
            0});
            this.nudHastaTcNo.Minimum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nudHastaTcNo.Name = "nudHastaTcNo";
            this.nudHastaTcNo.Size = new System.Drawing.Size(164, 20);
            this.nudHastaTcNo.TabIndex = 8;
            this.nudHastaTcNo.Value = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            // 
            // cbxReceteTipi
            // 
            this.cbxReceteTipi.FormattingEnabled = true;
            this.cbxReceteTipi.Location = new System.Drawing.Point(110, 46);
            this.cbxReceteTipi.Name = "cbxReceteTipi";
            this.cbxReceteTipi.Size = new System.Drawing.Size(131, 21);
            this.cbxReceteTipi.TabIndex = 9;
            // 
            // dtpReceteTarihi
            // 
            this.dtpReceteTarihi.Location = new System.Drawing.Point(110, 84);
            this.dtpReceteTarihi.Name = "dtpReceteTarihi";
            this.dtpReceteTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpReceteTarihi.TabIndex = 10;
            // 
            // ReceteILacGrid
            // 
            this.ReceteILacGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReceteILacGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Protokol_No,
            this.Barkod,
            this.Miktar,
            this.Kullanim_Periyot,
            this.Kullanim_Doz});
            this.ReceteILacGrid.Location = new System.Drawing.Point(1, 124);
            this.ReceteILacGrid.Name = "ReceteILacGrid";
            this.ReceteILacGrid.Size = new System.Drawing.Size(639, 129);
            this.ReceteILacGrid.TabIndex = 12;
            // 
            // Protokol_No
            // 
            this.Protokol_No.DataPropertyName = "Protokol_No";
            this.Protokol_No.HeaderText = "Protokol No";
            this.Protokol_No.Name = "Protokol_No";
            // 
            // Barkod
            // 
            this.Barkod.DataPropertyName = "Barkod";
            this.Barkod.HeaderText = "İlaç";
            this.Barkod.Name = "Barkod";
            // 
            // Miktar
            // 
            this.Miktar.DataPropertyName = "Miktar";
            this.Miktar.HeaderText = "Miktar";
            this.Miktar.Name = "Miktar";
            // 
            // Kullanim_Periyot
            // 
            this.Kullanim_Periyot.DataPropertyName = "Kullanim_Periyot";
            this.Kullanim_Periyot.HeaderText = "Kullanım Periyodu";
            this.Kullanim_Periyot.Name = "Kullanim_Periyot";
            // 
            // Kullanim_Doz
            // 
            this.Kullanim_Doz.DataPropertyName = "Kullanim_Doz";
            this.Kullanim_Doz.HeaderText = "Kullanım Dozu";
            this.Kullanim_Doz.Name = "Kullanim_Doz";
            // 
            // nudPNO
            // 
            this.nudPNO.Location = new System.Drawing.Point(184, 361);
            this.nudPNO.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudPNO.Minimum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudPNO.Name = "nudPNO";
            this.nudPNO.Size = new System.Drawing.Size(176, 20);
            this.nudPNO.TabIndex = 13;
            this.nudPNO.Value = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.nudPNO.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Iptal);
            this.panel1.Controls.Add(this.ReceteKaydet);
            this.panel1.Location = new System.Drawing.Point(1, 259);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 54);
            this.panel1.TabIndex = 14;
            // 
            // ReceteFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 311);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nudPNO);
            this.Controls.Add(this.ReceteILacGrid);
            this.Controls.Add(this.dtpReceteTarihi);
            this.Controls.Add(this.cbxReceteTipi);
            this.Controls.Add(this.nudHastaTcNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Hasta);
            this.Name = "ReceteFormu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reçete Formu";
            ((System.ComponentModel.ISupportInitialize)(this.nudHastaTcNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReceteILacGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPNO)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Hasta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ReceteKaydet;
        private System.Windows.Forms.Button Iptal;
        private System.Windows.Forms.NumericUpDown nudHastaTcNo;
        private System.Windows.Forms.ComboBox cbxReceteTipi;
        private System.Windows.Forms.DateTimePicker dtpReceteTarihi;
        private System.Windows.Forms.DataGridView ReceteILacGrid;
        private System.Windows.Forms.NumericUpDown nudPNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn Protokol_No;
        private System.Windows.Forms.DataGridViewComboBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kullanim_Periyot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kullanim_Doz;
        private System.Windows.Forms.Panel panel1;
    }
}