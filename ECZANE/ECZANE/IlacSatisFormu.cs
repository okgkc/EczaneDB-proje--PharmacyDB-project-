using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECZANE
{
    public partial class IlacSatisFormu : Form
    {
        int islem;//0: kayıt ekle, 1:Kayıt güncelle
        long hastaTC;//kayıt güncelleme sürecinde kullanılmaktadır.
        bool Sonuc = false;
        public IlacSatisFormu()
        {
            InitializeComponent();
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
            IlacSatisGrid.DataSource = VeriTabani_SQLServer.SELECTCalistir("SELECT * FROM Hasta_Satilan_Ilac WHERE TC_No = 00000000000");
            this.ShowDialog();
            return Sonuc;
        }
        public bool kayitGuncelle(long hsi_TC)
        {
            islem = 1;
            hastaTC = hsi_TC;
            //Kayıt bilgileri gösteriliyor..
            DataTable f_kayit = VeriTabani_SQLServer.SELECTCalistir("SELECT * FROM Hasta_Satilan_Ilac WHERE TC_No=" + hastaTC);
            nudTCNo.Value = Convert.ToInt64(f_kayit.Rows[0]["TC_No"]);
            IlacSatisGrid.DataSource = VeriTabani_SQLServer.SELECTCalistir("SELECT * FROM Hasta_Satilan_Ilac WHERE TC_No = " + hastaTC);
            this.ShowDialog();
            return Sonuc;
        }
        public bool ReceteEkle(long hsi_TC)
        {
            islem = 2;
            hastaTC = hsi_TC;
            //Kayıt bilgileri gösteriliyor..
            DataTable f_kayit = VeriTabani_SQLServer.SELECTCalistir("SELECT * FROM Hasta_Satilan_Ilac WHERE TC_No=" + hastaTC);
            nudTCNo.Value = Convert.ToInt64(f_kayit.Rows[0]["TC_No"]);
            IlacSatisGrid.DataSource = VeriTabani_SQLServer.SELECTCalistir("SELECT Barkod,Miktar FROM Recete_Ilac WHERE TC_No=" + hastaTC);
            this.ShowDialog();
            return Sonuc;
        }
        public bool kayitSil(long hsi_TC)

        {
            if (MessageBox.Show("Seçilen satılan ilaç kaydı silinecek. Emin misiniz?", "Onayla",
            MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("TC_No", hsi_TC));
            return (VeriTabani_SQLServer.ProsedurCalistir_MesajDegerlendir("SatilanIlacSil", parametreler));

        }
        private void SatisKaydet_Click(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("@TC_No", nudTCNo.Value));
            DataTable f_ilacsatis = (IlacSatisGrid.DataSource as DataTable);
            f_ilacsatis.AcceptChanges();
            parametreler.Add(new DictionaryEntry("SatilanIlac", f_ilacsatis));

            string f_prosedurAdi = "dbo.SatilanIlacEkle";
            if (islem == 1)
                f_prosedurAdi = "dbo.SatilanIlacGuncelle";
            if (VeriTabani_SQLServer.ProsedurCalistir_MesajDegerlendir(f_prosedurAdi, parametreler))
            {
                Sonuc = true;
                Close();

            }
        }
        private void SatisIptal_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}


