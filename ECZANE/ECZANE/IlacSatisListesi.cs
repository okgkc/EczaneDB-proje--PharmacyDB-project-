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
    public partial class IlacSatisListesi : Form
    {
        public IlacSatisListesi()
        {
            InitializeComponent();
            ListeGetir();
        }
        void ListeGetir()
        {
            IlacSatisGrid.DataSource = VeriTabani_SQLServer.ProsedurCalistir_TabloGelir("SatilanIlacListe",null);
        }

        private void IlacSatisEkle_Click(object sender, EventArgs e)
        {
            IlacSatisFormu hlc = new IlacSatisFormu();
            if (hlc.yeniKayitEkle())
                ListeGetir();
        }

        private void IlacSatisGuncelle_Click(object sender, EventArgs e)
        {
            if (IlacSatisGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce Güncellenecek Kaydı Seçin.");
                return;
            }
            long f_SatisGuncelle = Convert.ToInt64(IlacSatisGrid.SelectedRows[0].Cells["TC Kimlik No"].Value);
            IlacSatisFormu ilcsts = new IlacSatisFormu();
            if (ilcsts.kayitGuncelle(f_SatisGuncelle))
                ListeGetir();
        }

        private void IlacSatisSil_Click(object sender, EventArgs e)
        {
            if (IlacSatisGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce Silinecek Kaydı Seçin.");
                return;
            }
            long f_TCno = Convert.ToInt64(IlacSatisGrid.SelectedRows[0].Cells["TC Kimlik No"].Value);
            IlacSatisFormu rctfrm = new IlacSatisFormu();
            if (rctfrm.kayitSil(f_TCno))
                ListeGetir();
        }
    }
}


