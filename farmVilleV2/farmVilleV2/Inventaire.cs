using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace farmVilleV2
{
    public partial class Inventaire : Form
    {
        int Argent;
        int Ble;

        public Inventaire()
        {
            InitializeComponent();
        }

        private void Inventaire_Load(object sender, EventArgs e)
        {
            Argent = frmFarmVille.Argent;
            lblArgentInventaire.Text = Argent.ToString();
            Ble = frmFarmVille.Ble;
            lblBleInventaire.Text = Ble.ToString();
        }
    }
}
