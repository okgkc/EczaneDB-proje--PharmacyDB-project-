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
    public partial class ReceteListe : Form
    {
        public ReceteListe()
        {
            InitializeComponent();
            ListeGetir();
        }
        void ListeGetir()
        {
            ReceteListeGrid.DataSource = VeriTabani_SQLServer.ProsedurCalistir_TabloGelir("ReceteListe", null);
        }

        private void ReceteEkle_Click(object sender, EventArgs e)
        {
            ReceteFormu rctfrm = new ReceteFormu();
            if (rctfrm.yeniKayitEkle())
                ListeGetir();
        }

        private void ReceteGuncelle_Click(object sender, EventArgs e)
        {
            if (ReceteListeGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce Güncellenecek Kaydı Seçin.");
                return;
            }
            long f_ReceteGuncelle = Convert.ToInt64(ReceteListeGrid.SelectedRows[0].Cells["Protokol No"].Value);
            ReceteFormu rctfrm = new ReceteFormu();
            if (rctfrm.kayitGuncelle(f_ReceteGuncelle))
                ListeGetir();
        }

        private void ReceteSil_Click(object sender, EventArgs e)
        {
            if (ReceteListeGrid.SelectedRows.Count < 1)
            {
                MessageBox.Show("Önce Silinecek Kaydı Seçin.");
                return;
            }
            long f_Protokolno = Convert.ToInt64(ReceteListeGrid.SelectedRows[0].Cells["Protokol No"].Value);
            ReceteFormu rctfrm = new ReceteFormu();
            if (rctfrm.kayitSil(f_Protokolno))
                ListeGetir();

        }
    }
    }

