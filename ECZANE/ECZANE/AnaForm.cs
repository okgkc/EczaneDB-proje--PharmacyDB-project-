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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
            
        }

        private void HastaListesiGetir_Click(object sender, EventArgs e)
        {
            HastaListe hstlst = new HastaListe();
            hstlst.Show();
        }

        private void IlacListesiGetir_Click(object sender, EventArgs e)
        {
            IlacListe ilclst = new IlacListe();
            ilclst.Show();

        }

        private void Recete_Click(object sender, EventArgs e)
        {
            ReceteListe rctlst = new ReceteListe();
            rctlst.Show();
        }

        private void IlacSatıs_Click(object sender, EventArgs e)
        {
            IlacSatisListesi isl = new IlacSatisListesi();
            isl.Show();
        }

    }
}
