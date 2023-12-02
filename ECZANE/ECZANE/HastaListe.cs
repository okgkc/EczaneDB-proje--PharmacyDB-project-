using System;
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
    public partial class HastaListe : Form
    {

        public HastaListe()
        {
            InitializeComponent();
            ListeGetir();
        }
        void ListeGetir()
        {
            HastaListeGrid.DataSource = VeriTabani_SQLServer.ProsedurCalistir_TabloGelir("HastaListe", null);
        }

        private void YeniHastaKayit_Click(object sender, EventArgs e)
        {
            HastaFormu hstfrm = new HastaFormu();
            if (hstfrm.yeniKayiEkle())
                ListeGetir();
        }

        private void HastaGuncelle_Click(object sender, EventArgs e)
        {
            if(HastaListeGrid.SelectedRows.Count<1)
            {
                MessageBox.Show("Önce Güncellenecek Kaydı Seçin.");
                return;
            }
           long f_HastaGuncelle = Convert.ToInt64(HastaListeGrid.SelectedRows[0].Cells["TC Kimlik No"].Value);
            HastaFormu hstfrm = new HastaFormu();
            if (hstfrm.kayitGuncelle(f_HastaGuncelle))
                ListeGetir();


        }

        private void HastaSil_Click(object sender, EventArgs e)
        {
            if(HastaListeGrid.SelectedRows.Count<1)
            {
                MessageBox.Show("Önce Silinecek Kaydı Seçin.");
                return;
            }
            long f_TCno =Convert.ToInt64(HastaListeGrid.SelectedRows[0].Cells["TC Kimlik No"].Value);
            HastaFormu hstfrm = new HastaFormu();
            if (hstfrm.kayitSil(f_TCno))
                ListeGetir();
        }

    }
}