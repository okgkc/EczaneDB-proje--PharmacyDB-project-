using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECZANE
{
    public partial class ReceteFormu : Form
    {
        int islem;
        long ProtokolNo;
        bool Sonuc = false;
        public ReceteFormu()
        {
            InitializeComponent();
            ComboBoxListesiAyarla(cbxReceteTipi, "RECETETIPI");
            ComboBoxListesiAyarla(Barkod, "ILACLISTESI");
        }
        void ComboBoxListesiAyarla(object combo, string listeAdi)
        {
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("ListeAdi", listeAdi));
            if (combo is DataGridViewComboBoxColumn)
            {
                (combo as DataGridViewComboBoxColumn).DisplayMember = "Baslik";
                (combo as DataGridViewComboBoxColumn).ValueMember = "Deger";
                (combo as DataGridViewComboBoxColumn).DataSource =
                VeriTabani_SQLServer.ProsedurCalistir_TabloGelir("ComboBoxListesi", parametreler);
            }
            else
            {
                (combo as ComboBox).DisplayMember = "Baslik";
                (combo as ComboBox).ValueMember = "Deger";
                (combo as ComboBox).DataSource =
                VeriTabani_SQLServer.ProsedurCalistir_TabloGelir("ComboBoxListesi", parametreler);
            }
        }
        public bool yeniKayitEkle()
        {
            islem = 0;
            ReceteILacGrid.DataSource = VeriTabani_SQLServer.SELECTCalistir("SELECT *FROM Recete_Ilac WHERE Barkod = 000000000000");
            this.ShowDialog();
            return Sonuc;
        }
        public bool kayitGuncelle(long ri_ProtokolNo)
        {
            islem = 1;
            ProtokolNo = ri_ProtokolNo;
            //Kayıt bilgileri gösteriliyor..
            DataTable f_kayit = VeriTabani_SQLServer.SELECTCalistir("SELECT * FROM Recete WHERE Protokol_No=" + ProtokolNo);
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("İlaç kaydı bulunamadı!..");
                return false;
            }
           
            dtpReceteTarihi.Value = Convert.ToDateTime(f_kayit.Rows[0]["Recete_Tarihi"]);
            cbxReceteTipi.SelectedValue = f_kayit.Rows[0]["Recete_Tipi"].ToString();
            nudHastaTcNo.Value = Convert.ToInt64(f_kayit.Rows[0]["TC_No"]);
            ReceteILacGrid.DataSource = VeriTabani_SQLServer.SELECTCalistir("SELECT * FROM Recete_Ilac WHERE Protokol_No = " + ProtokolNo);
            this.ShowDialog();
            return Sonuc;

        }
        public bool kayitSil(long ri_ProtokolNo)

        {
            if (MessageBox.Show("Seçilen reçete kaydı silinecek. Emin misiniz?", "Onayla",
            MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("Protokol_No", ri_ProtokolNo));
            return (VeriTabani_SQLServer.ProsedurCalistir_MesajDegerlendir("ReceteSil", parametreler));

        }

        private void ReceteKaydet_Click_1(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();
            //
            parametreler.Add(new DictionaryEntry("@Protokol_No", nudPNO.Value));
            parametreler.Add(new DictionaryEntry("Recete_Tarihi", dtpReceteTarihi.Value));
            parametreler.Add(new DictionaryEntry("Recete_Tipi", cbxReceteTipi.SelectedValue));
            parametreler.Add(new DictionaryEntry("TC_No", nudHastaTcNo.Value));

            DataTable f_ilaclar = (ReceteILacGrid.DataSource as DataTable);
            
            f_ilaclar.AcceptChanges();
            parametreler.Add(new DictionaryEntry("Recete_Ilac", f_ilaclar));

            string f_prosedurAdi = "dbo.ReceteEkle";
            if (islem == 1)
                f_prosedurAdi = "dbo.ReceteGuncelle";
            if (VeriTabani_SQLServer.ProsedurCalistir_MesajDegerlendir(f_prosedurAdi, parametreler))
            {
                Sonuc = true;
                Close();
            }
        }

        private void Iptal_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
