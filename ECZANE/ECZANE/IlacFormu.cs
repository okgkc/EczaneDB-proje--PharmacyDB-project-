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
    public partial class IlacFormu : Form
    {
        int islem;
        long BarkodNo;
        bool Sonuc = false;
        public IlacFormu()
        {
            InitializeComponent();
            ComboBoxListesiAyarla(cmbIlacFormu, "ILACFORMU");
            ComboBoxListesiAyarla(cmbVerilisSekli, "VERILISSEKLI");
            ComboBoxListesiAyarla(cmbRafKodu, "RAFKODU");

        }
        void ComboBoxListesiAyarla(ComboBox combo, string listeAdi)
        {
            combo.DisplayMember = "Baslik";
            combo.ValueMember = "Deger";
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("ListeAdi", listeAdi));
            combo.DataSource = VeriTabani_SQLServer.ProsedurCalistir_TabloGelir("ComboBoxListesi", parametreler);
        }
        public bool yeniKayitEkle()
        {
            islem = 0;
            this.ShowDialog();
            return Sonuc;
        }
        public bool kayitGuncelle(long IlacBarkodNo)
        {
            islem = 1;
            BarkodNo = IlacBarkodNo;
            DataTable f_kayit = VeriTabani_SQLServer.SELECTCalistir("SELECT*FROM Ilac WHERE Barkod=" + IlacBarkodNo);
            if (f_kayit.Rows.Count < 1)
            {
                MessageBox.Show("İlaç Kaydı Bulunamadı!");
                return false;
            }
            nudBarkod.Value = Convert.ToInt64(f_kayit.Rows[0]["Barkod"]);
            txtIlacAdi.Text = f_kayit.Rows[0]["Ilac_Adi"].ToString();
            txtEtkiGrubu.Text = f_kayit.Rows[0]["Etki_Grubu"].ToString();
            cmbIlacFormu.SelectedValue= f_kayit.Rows[0]["Ilac_Formu"].ToString();
            cmbVerilisSekli.SelectedValue = f_kayit.Rows[0]["Verilis_Sekli"].ToString();
            txtFirmaAdi.Text = f_kayit.Rows[0]["Firma"].ToString();
            cmbRafKodu.SelectedValue = f_kayit.Rows[0]["Raf_Kodu"].ToString();
            nudStokAdedi.Value=Convert.ToInt32(f_kayit.Rows[0]["Stok_Adedi"]);
            nudBirimFiyat.Value= Convert.ToDecimal(f_kayit.Rows[0]["Birim_Fiyat"]);
            this.ShowDialog();
            return Sonuc;
        }
        public bool kayitSil(long IlacBarkodNo)
        {
            if (MessageBox.Show("Seçilen ilaç kaydı silinecek. Emin misiniz?", "Onayla", MessageBoxButtons.YesNo) != DialogResult.Yes)
                return false;
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("Barkod", IlacBarkodNo));
            return (VeriTabani_SQLServer.ProsedurCalistir_MesajDegerlendir("IlacSil", parametreler));
        }

        private void IlacKaydet_Click(object sender, EventArgs e)
        {
            ArrayList parametreler = new ArrayList();
            parametreler.Add(new DictionaryEntry("Barkod", nudBarkod.Value));
            parametreler.Add(new DictionaryEntry("Ilac_Adi", txtIlacAdi.Text));
            parametreler.Add(new DictionaryEntry("Etki_Grubu", txtEtkiGrubu.Text));
            parametreler.Add(new DictionaryEntry("Ilac_Formu", cmbIlacFormu.SelectedValue));
            parametreler.Add(new DictionaryEntry("Verilis_Sekli", cmbVerilisSekli.SelectedValue));
            parametreler.Add(new DictionaryEntry("Firma", txtFirmaAdi.Text));
            parametreler.Add(new DictionaryEntry("Raf_Kodu", cmbRafKodu.SelectedValue));
            parametreler.Add(new DictionaryEntry("Stok_Adedi", nudStokAdedi.Value));
            parametreler.Add(new DictionaryEntry("Birim_Fiyat", nudBirimFiyat.Value));
            string f_prosedurAdi = "dbo.IlacEkle";
            if (islem == 1)
                f_prosedurAdi = "dbo.IlacGuncelle";
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

