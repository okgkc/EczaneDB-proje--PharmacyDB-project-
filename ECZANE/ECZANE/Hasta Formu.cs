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
    public partial class HastaFormu : Form
    {
        int islem;
        long TC_No;
        bool Sonuc = false;
        public HastaFormu()
        {
            InitializeComponent();
            ComboBoxListesiAyarla(cbxCinsiyet, "CINSIYET");
            ComboBoxListesiAyarla(cbxSGK, "SGK");
        }
        void ComboBoxListesiAyarla(ComboBox combo, string listeAdi)
        {
            combo.DisplayMember = "Baslik";
            combo.ValueMember = "Deger";
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("ListeAdi", listeAdi));
            combo.DataSource = VeriTabani_SQLServer.ProsedurCalistir_TabloGelir("ComboBoxListesi", parametreler);
        }
        public bool yeniKayiEkle()
        {
            islem = 0;
            this.ShowDialog();
            return Sonuc;
        }
        public bool kayitGuncelle(long HastaTCNo)
        {
            islem = 1;
            TC_No = HastaTCNo;
            DataTable f_kayit = VeriTabani_SQLServer.SELECTCalistir("SELECT*FROM Hasta WHERE TC_No=" + HastaTCNo);
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("Hasta Kaydı Bulunamadı!");
                return false;
            }
            nudTCNo.Value = Convert.ToInt64(f_kayit.Rows[0]["TC_No"]);
            txtAdSoyad.Text = f_kayit.Rows[0]["Adi_Soyadi"].ToString();
            cbxCinsiyet.SelectedValue = f_kayit.Rows[0]["Cinsiyet"].ToString();
            dtpDogumTarihi.Value = Convert.ToDateTime(f_kayit.Rows[0]["Dogum_Tarihi"]);
            cbxSGK.SelectedValue = f_kayit.Rows[0]["SGK"].ToString();
            txtTelefonNo.Text = f_kayit.Rows[0]["Telefon_No"].ToString();
            this.ShowDialog();
            return Sonuc;
        }
        public bool kayitSil(long HastaTCNo)
        {
            if (MessageBox.Show("Seçilen hastanın kaydı silinecek. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("TC_No", HastaTCNo));
            return (VeriTabani_SQLServer.ProsedurCalistir_MesajDegerlendir("HastaSil", parametreler));
        }
        private void HastaKaydet_Click(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("TC_No", nudTCNo.Value));
            parametreler.Add(new DictionaryEntry("Adi_Soyadi", txtAdSoyad.Text));
            parametreler.Add(new DictionaryEntry("Cinsiyet", cbxCinsiyet.Text));
            parametreler.Add(new DictionaryEntry("Dogum_Tarihi", dtpDogumTarihi.Value));
            parametreler.Add(new DictionaryEntry("SGK",cbxSGK.Text));
            parametreler.Add(new DictionaryEntry("Telefon_No", txtTelefonNo.Text));
            string f_prosedurAdi = "dbo.HastaEkle";
            if (islem == 1)
                f_prosedurAdi = "dbo.HastaGuncelle";
            if(VeriTabani_SQLServer.ProsedurCalistir_MesajDegerlendir(f_prosedurAdi, parametreler))
            {
                Sonuc = true;
                Close();
            }
        }

        private void KayitIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}

