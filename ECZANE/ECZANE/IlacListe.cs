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
    public partial class IlacListe : Form
    {
        public IlacListe()
        {
            InitializeComponent();
            ListeGetir();
        }
        void ListeGetir()
        {
           IlacListeGrid.DataSource = VeriTabani_SQLServer.ProsedurCalistir_TabloGelir("IlacListe",
            null);
        }

        private void yeniIlacEkle_Click(object sender, EventArgs e)
        {
            IlacFormu ilcfrm = new IlacFormu();
            if (ilcfrm.yeniKayitEkle())
                ListeGetir();
        }
        private void IlacGuncelle_Click(object sender, EventArgs e)
        {
            if (IlacListeGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce Güncellenecek Kaydı Seçin.");
                return;
            }
            long f_IlacGuncelle = Convert.ToInt64(IlacListeGrid.SelectedRows[0].Cells["Barkod"].Value);
            IlacFormu ilcfrm = new IlacFormu();
            if (ilcfrm.kayitGuncelle(f_IlacGuncelle))
                ListeGetir();
        }

        private void IlacSil_Click(object sender, EventArgs e)
        {
            if (IlacListeGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce Silinecek Kaydı Seçin.");
                return;
            }
            long f_Barkod = Convert.ToInt64(IlacListeGrid.SelectedRows[0].Cells["Barkod"].Value);
            IlacFormu ilcfrm = new IlacFormu();
            if (ilcfrm.kayitSil(f_Barkod))
                ListeGetir();
        }
    }
}
